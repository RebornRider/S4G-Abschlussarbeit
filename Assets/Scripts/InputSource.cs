using UnityEngine;

namespace PaladinCharacter
{
    public abstract class InputSource : MonoBehaviour
    {
        public abstract Vector2 GetMovementTwoAxis();
        public abstract Vector2 GetCameraTwoAxis();
        public abstract bool WasJumpPressed();
        public abstract bool WasDashPressed();
    }
}