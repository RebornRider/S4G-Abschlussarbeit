using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{

    public Transform _Anchor;

    // Keep us from going past the poles
    private const float MIN_PITCH = 10f;
    private const float MAX_PITCH = 170f;

    /// <summary>
    /// Offset from the anchor that the camera will be positioned
    /// </summary>
    public Vector3 _AnchorOffset = new Vector3(0f, 2f, 0f);


    /// <summary>
    /// Radius of the orbit
    /// </summary>
    public float _Radius = 4f;

    /// <summary>
    /// Degrees per second the actor rotates
    /// </summary>
    public float _RotationSpeed = 120f;
    public float RotationSpeed
    {
        get { return _RotationSpeed; }

        set
        {
            _RotationSpeed = value;
            mDegreesPer60FPSTick = _RotationSpeed / 60f;
        }
    }

    /// <summary>
    /// Determines if we invert the pitch information we get from the input
    /// </summary>
    public bool _InvertPitch = true;


    /// <summary>
    /// Speed we'll actually apply to the rotation. This is essencially the
    /// number of degrees per tick assuming we're running at 60 FPS
    /// </summary>
    protected float mDegreesPer60FPSTick = 1f;

    /// <summary>
    /// Represents the "pole" that the camera is attched to the anchor with. This pole
    /// is the direction from the anchor to the camera (in natural "up" space)
    /// </summary>
    protected Vector3 mToCameraDirection = Vector3.back;

    /// <summary>
    /// We keep track of the tilt so we can make small changes to it as the actor rotates.
    /// This is safter than trying to do a full rotation all at once which can cause odd
    /// rotations as we hit 180 degrees.
    /// </summary>
    protected Quaternion mTilt = Quaternion.identity;


    public void LateUpdate()
    {
        Vector3 lNewAnchorPosition = _Anchor.position + (_Anchor.rotation * _AnchorOffset);
        Vector3 lNewCameraPosition = transform.position;
        Quaternion lNewCameraRotation = transform.rotation;

        //if (mInputSource.IsViewingActivated)
        // Grab the rotation amount. We do the inverse tilt so we calculate the rotation in
        // "natural up" space. Later we'll use the tilt to put it back into "anchor up" space.
        Quaternion lInvTilt = QuaternionExt.FromToRotation(_Anchor.up, Vector3.up);

        // Yaw is simple as we can go 360
        Quaternion lYaw = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * mDegreesPer60FPSTick, lInvTilt * transform.up);

        // Pitch is more complicated since we can't go beyond the north/south pole
        float lPitchAngle = Vector3.Angle(mToCameraDirection, lInvTilt * _Anchor.up);

        float lPitchDelta = (_InvertPitch ? -1f : 1f) * Input.GetAxis("Mouse Y");
        if (lPitchAngle < MIN_PITCH && lPitchDelta > 0f) { lPitchDelta = 0f; }
        else if (lPitchAngle > MAX_PITCH && lPitchDelta < 0f) { lPitchDelta = 0f; }

        Quaternion lPitch = Quaternion.AngleAxis(lPitchDelta, lInvTilt * transform.right);

        // Calculate the new "natural up" direction
        mToCameraDirection = lPitch * lYaw * mToCameraDirection;
        // end if

        // Update our tilt to match the anchor's tilt
        mTilt = QuaternionExt.FromToRotation(mTilt.Up(), _Anchor.up) * mTilt;

        // Put the new direction relative to the anchor's tilt
        Vector3 lToCameraDirection = mTilt * mToCameraDirection;
        if (lToCameraDirection.sqrMagnitude == 0f) { lToCameraDirection = -_Anchor.forward; }

        // Calculate the new orbit center (anchor) and camera position
        lNewCameraPosition = lNewAnchorPosition + (lToCameraDirection.normalized * _Radius);
        lNewCameraRotation = Quaternion.LookRotation(lNewAnchorPosition - lNewCameraPosition, _Anchor.up);


        // Set the values
        transform.position = lNewCameraPosition;
        transform.rotation = lNewCameraRotation;
    }
}

public static class QuaternionExt
{
    /// <summary>
    /// Value that identifies an inequality
    /// </summary>
    public static float EPSILON = 0.000001f;

    /// <summary>
    /// Inverse identity for testing
    /// </summary>
    public static Quaternion InverseIdentity = new Quaternion(0f, 0f, 0f, -1f);

    /// <summary>
    /// Unity's comparison allows small values to be considered equal.
    /// For some tests, we want to be exact.
    /// </summary>
    /// <param name="rLeft"></param>
    /// <param name="rRight"></param>
    /// <returns></returns>
    public static bool IsEqual(Quaternion rLeft, Quaternion rRight)
    {
        if (Mathf.Abs(rLeft.x - rRight.x) > EPSILON) { return false; }
        if (Mathf.Abs(rLeft.y - rRight.y) > EPSILON) { return false; }
        if (Mathf.Abs(rLeft.z - rRight.z) > EPSILON) { return false; }
        if (Mathf.Abs(rLeft.w - rRight.w) > EPSILON) { return false; }

        return true;
    }

    /// <summary>
    /// Unity's comparison allows small values to be considered equal.
    /// For some tests, we want to be exact.
    /// </summary>
    /// <param name="rLeft"></param>
    /// <param name="rRight"></param>
    /// <returns></returns>
    public static bool IsEqual(ref Quaternion rLeft, ref Quaternion rRight)
    {
        if (Mathf.Abs(rLeft.x - rRight.x) > EPSILON) { return false; }
        if (Mathf.Abs(rLeft.y - rRight.y) > EPSILON) { return false; }
        if (Mathf.Abs(rLeft.z - rRight.z) > EPSILON) { return false; }
        if (Mathf.Abs(rLeft.w - rRight.w) > EPSILON) { return false; }

        return true;
    }

    /// <summary>
    /// Simple identity test that supports the inverse identity
    /// </summary>
    /// <param name="rThis"></param>
    /// <returns></returns>
    public static bool IsIdentity(this Quaternion rThis)
    {
        if (rThis.x != 0f) { return false; }
        if (rThis.y != 0f) { return false; }
        if (rThis.z != 0f) { return false; }
        if (rThis.w == 1f || rThis.w == -1f) { return true; }

        return false;
    }

    /// <summary>
    /// Creates a quaterion that represents the rotation required to turn the
    /// original quaterion to the specified quaterion
    /// </summary>
    /// <param name="rFrom">This object we're operating on</param>
    /// <param name="rTo">Quaternion to rotate towards</param>
    /// <returns>Resulting quaternion</returns>
    public static Quaternion RotationTo(this Quaternion rFrom, Quaternion rTo)
    {
        return Quaternion.Inverse(rFrom) * rTo;

        //Quaternion lInvFrom = Quaternion.Inverse(rFrom);
        //Quaternion lResult = rTo * lInvFrom;
        //return lResult;
    }

    /// <summary>
    /// Creates a rotation that when set as the 'transform.rotation' will mimic that
    /// of the 'to'.
    /// </summary>
    /// <param name="rFrom">This object we're operating on</param>
    /// <param name="rTo">Quaternion to rotate towards</param>
    /// <returns>Resulting quaternion</returns>
    public static Quaternion OrientTo(this Quaternion rFrom, Quaternion rTo)
    {
        Quaternion lInvFrom = Quaternion.Inverse(rFrom);
        Quaternion lResult = rTo * lInvFrom;
        return lResult;
    }

    ///// <summary>
    ///// Creates a quaterion that represents the rotation required to turn the
    ///// original quaterion to the specified quaterion. This version of the
    ///// function is build for the resulting quaternion to be used directly
    ///// as a Transform.localRotation value.
    ///// 
    ///// http://books.google.com/books?id=X3hmuhBoFF0C&pg=PA251&lpg=PA251&dq=quaternion+multiplicative+inverse+conjugate&source=bl&ots=tjsSJHOtr3&sig=dJJh9IarEyBFkzIKS-3H2CJEZGU&hl=en&sa=X&ei=npo1VPyxCtDxgwTwj4LwDA&ved=0CFkQ6AEwCA#v=onepage&q=quaternion%20multiplicative%20inverse%20conjugate&f=false
    ///// page 254
    ///// 
    ///// d = diff
    ///// a = start
    ///// b = end
    ///// 
    ///// da              = b
    ///// (da) Conj(a)    = b Conj(a)
    ///// d (a Conj(a))   = b Conj(a)
    ///// d (1)           = b Conj(a)
    ///// d               = b Conj(a)
    ///// 
    ///// </summary>
    ///// <param name="rFrom">This object we're operating on</param>
    ///// <param name="rTo">Quaternion to rotate towards</param>
    ///// <returns>Resulting quaternion</returns>
    //public static Quaternion RotationTo(this Quaternion rFrom, Quaternion rTo)
    //{
    //    return rFrom.Conjugate() * rTo;
    //    //return rTo * rFrom.Conjugate();
    //}

    /// <summary>
    /// Subtracts one quaternion from another and returns the resulting quaternion
    /// </summary>
    /// <param name="rLHS">Base quaternion who will have a value subtracted</param>
    /// <param name="rRHS">Value to subtract</param>
    /// <returns>Resulting quaternion</returns>
    public static Quaternion Subtract(this Quaternion rLHS, Quaternion rRHS)
    {
        Quaternion lResult;
        lResult.x = rLHS.x - rRHS.x;
        lResult.y = rLHS.y - rRHS.y;
        lResult.z = rLHS.z - rRHS.z;
        lResult.w = rLHS.w - rRHS.w;

        //Quaternion lInvRHS = Quaternion.Inverse(rRHS);
        //Quaternion lResult = rLHS * lInvRHS;

        return lResult;
    }

    /// <summary>
    /// Returns a normalized form of the quaternion
    /// </summary>
    /// <param name="rThis">Quaternion to normalize</param>
    /// <returns>Normalized form</returns>
    public static Quaternion Normalize(this Quaternion rThis)
    {
        Quaternion lResult;

        float lMagnitude = Mathf.Sqrt((rThis.w * rThis.w) + (rThis.x * rThis.x) + (rThis.y * rThis.y) + (rThis.z * rThis.z));
        lResult.x = rThis.x / lMagnitude;
        lResult.y = rThis.y / lMagnitude;
        lResult.z = rThis.z / lMagnitude;
        lResult.w = rThis.w / lMagnitude;

        return lResult;
    }

    /// <summary>
    /// Quaternions have two values that represent the same rotation.
    /// One is the axis with the base angle. The other is the -axis with
    /// a -angle. Negating the quaternion gives the same result, but
    /// represented a different way
    /// </summary>
    /// <param name="rThis"></param>
    /// <returns></returns>
    public static Quaternion Negate(this Quaternion rThis)
    {
        Quaternion lResult;

        lResult.x = -rThis.x;
        lResult.y = -rThis.y;
        lResult.z = -rThis.z;
        lResult.w = -rThis.w;

        return lResult;
    }

    /// <summary>
    /// Returns the Conjugate of the quaternion. The conjugate
    /// represents the opposite angluar displacement since the
    /// vector is reversed.
    /// </summary>
    /// <param name="rThis"></param>
    /// <returns></returns>
    public static Quaternion Conjugate(this Quaternion rThis)
    {
        Quaternion lResult;

        lResult.x = -rThis.x;
        lResult.y = -rThis.y;
        lResult.z = -rThis.z;
        lResult.w = rThis.w;

        return lResult;
    }

    /// <summary>
    /// Returns a vector representing this quaternion's forward direction
    /// </summary>
    /// <param name="rThis"></param>
    /// <returns></returns>
    public static Vector3 Forward(this Quaternion rThis)
    {
        return new Vector3(2 * (rThis.x * rThis.z + rThis.w * rThis.y),
            2 * (rThis.y * rThis.z - rThis.w * rThis.x),
            1 - 2 * (rThis.x * rThis.x + rThis.y * rThis.y));
    }

    /// <summary>
    /// Returns a vector representing this quaternion's up direction
    /// </summary>
    /// <param name="rThis"></param>
    /// <returns></returns>
    public static Vector3 Up(this Quaternion rThis)
    {
        return new Vector3(2 * (rThis.x * rThis.y - rThis.w * rThis.z),
            1 - 2 * (rThis.x * rThis.x + rThis.z * rThis.z),
            2 * (rThis.y * rThis.z + rThis.w * rThis.x));
    }

    /// <summary>
    /// Returns a vector representing this quaternion's right direction
    /// </summary>
    /// <param name="rThis"></param>
    /// <returns></returns>
    public static Vector3 Right(this Quaternion rThis)
    {
        return new Vector3(1 - 2 * (rThis.y * rThis.y + rThis.z * rThis.z),
            2 * (rThis.x * rThis.y + rThis.w * rThis.z),
            2 * (rThis.x * rThis.z - rThis.w * rThis.y));
    }

    /// <summary>
    /// Handles smaller values better than Unity's version.
    /// </summary>
    /// <param name="u"></param>
    /// <param name="v"></param>
    /// <returns></returns>
    public static Quaternion FromToRotation(Vector3 u, Vector3 v)
    {
        float lTheta = Vector3.Dot(u.normalized, v.normalized);

        if (lTheta >= 1f)
        {
            return Quaternion.identity;
        }
        else if (lTheta <= -1f)
        {
            Vector3 lSimpleAxis = Vector3.Cross(u, Vector3.right);
            if (lSimpleAxis.sqrMagnitude == 0f) { lSimpleAxis = Vector3.Cross(u, Vector3.up); }

            return Quaternion.AngleAxis(180f, lSimpleAxis);
        }

        float lRadians = Mathf.Acos(lTheta);
        Vector3 lAxis = (Vector3.Cross(u, v)).normalized;

        return Quaternion.AngleAxis(lRadians * Mathf.Rad2Deg, lAxis);
    }

    /// <summary>
    /// Decomposes the quaterniong into a twist (around the axis) and a swing (rotation) around a vector perpendicular
    /// to the axis.
    /// 
    /// To rebuild, use:
    /// rThis = rSwing * rTwist
    /// 
    /// http://www.alinenormoyle.com/weblog/?p=726
    /// </summary>
    /// <param name="rThis"></param>
    /// <param name="rAxis"></param>
    /// <param name="rSwing"></param>
    /// <param name="rTwist"></param>
    public static void DecomposeSwingTwist(this Quaternion rThis, Vector3 rAxis, ref Quaternion rSwing, ref Quaternion rTwist)
    {
        Vector3 lTwistAxis = rAxis.normalized;

        // Dot(v, vTwist)
        float lDot = Vector3.Dot(new Vector3(rThis.x, rThis.y, rThis.z), lTwistAxis);

        // p = dot * vTwist
        lTwistAxis = lTwistAxis * lDot;

        // qTwist = (p, w)
        rTwist.x = lTwistAxis.x;
        rTwist.y = lTwistAxis.y;
        rTwist.z = lTwistAxis.z;
        rTwist.w = rThis.w;

        // qTwist.Normalize
        rTwist = rTwist.Normalize();

        rSwing = rThis * Quaternion.Inverse(rTwist);
    }

    /// <summary>
    /// Extracts out the rotational axis and angles for a swing and twist. Note that this function expects the
    /// bone to be oriented along the 'Y' axis.
    /// </summary>
    /// <param name="rThis"></param>
    /// <param name="rTwistAxis"></param>
    /// <param name="rTwistAngle"></param>
    /// <param name="rSwingAxis"></param>
    /// <param name="rSwingAngle"></param>
    public static void DecomposeTwistSwingAxisAngles(this Quaternion rThis, Vector3 rTwistAxis, ref float rTwistAngle, ref Vector3 rSwingAxis, ref float rSwingAngle)
    {
        rTwistAngle = 2.0f * Mathf.Atan2(rThis.y, rThis.w) * Mathf.Rad2Deg;

        Vector4 lComponents = new Vector4(0, rThis.y, 0, rThis.w) / Mathf.Sqrt(rThis.y * rThis.y + rThis.w * rThis.w);
        Quaternion lTwist = new Quaternion(lComponents.x, lComponents.y, lComponents.z, lComponents.w);

        Quaternion lSwing = rThis * lTwist.Conjugate();

        float lLength = Mathf.Sqrt(lSwing.x * lSwing.x + lSwing.y * lSwing.y + lSwing.z * lSwing.z);
        if (lLength > 0.000001f)
        {
            float lInvLength = 1.0f / lLength;
            rSwingAxis.x = lSwing.x * lInvLength;
            rSwingAxis.y = lSwing.y * lInvLength;
            rSwingAxis.z = lSwing.z * lInvLength;

            if (lSwing.w < 0.0f)
                rSwingAngle = 2.0f * Mathf.Atan2(-lLength, -lSwing.w) * Mathf.Rad2Deg; //-PI,0 
            else
                rSwingAngle = 2.0f * Mathf.Atan2(lLength, lSwing.w) * Mathf.Rad2Deg; //0,PI 
        }
        else
        {
            rSwingAxis = Vector3.right;
            rSwingAngle = 0.0f;
        }
    }

    /// <summary>
    /// Parses out the vector values given a string
    /// </summary>
    /// <param name="rThis">Vector we are filling</param>
    /// <param name="rString">String containing the vector values. In the form of "(0,0,0)"</param>
    public static Quaternion FromString(this Quaternion rThis, string rString)
    {
        string[] lTemp = rString.Substring(1, rString.Length - 2).Split(',');
        if (lTemp.Length != 4) { return rThis; }

        rThis.x = float.Parse(lTemp[0]);
        rThis.y = float.Parse(lTemp[1]);
        rThis.z = float.Parse(lTemp[2]);
        rThis.w = float.Parse(lTemp[3]);
        return rThis;
    }
}
