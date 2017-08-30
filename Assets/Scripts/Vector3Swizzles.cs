using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace PaladinCharacter.Utility
{
    [SuppressMessage("ReSharper", "UnusedParameter.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static class Vector3Swizzles
    {
        //swizzles of size 2
        public static Vector2 _11(this Vector3 a) { return new Vector2(1.0f, 1.0f); }
        public static Vector2 _01(this Vector3 a) { return new Vector2(0.0f, 1.0f); }
        public static Vector2 x1(this Vector3 a) { return new Vector2(a.x, 1.0f); }
        public static Vector2 y1(this Vector3 a) { return new Vector2(a.y, 1.0f); }
        public static Vector2 z1(this Vector3 a) { return new Vector2(a.z, 1.0f); }
        public static Vector2 _10(this Vector3 a) { return new Vector2(1.0f, 0.0f); }
        public static Vector2 _00(this Vector3 a) { return new Vector2(0.0f, 0.0f); }
        public static Vector2 x0(this Vector3 a) { return new Vector2(a.x, 0.0f); }
        public static Vector2 y0(this Vector3 a) { return new Vector2(a.y, 0.0f); }
        public static Vector2 z0(this Vector3 a) { return new Vector2(a.z, 0.0f); }
        public static Vector2 _1x(this Vector3 a) { return new Vector2(1.0f, a.x); }
        public static Vector2 _0x(this Vector3 a) { return new Vector2(0.0f, a.x); }
        public static Vector2 xx(this Vector3 a) { return new Vector2(a.x, a.x); }
        public static Vector2 yx(this Vector3 a) { return new Vector2(a.y, a.x); }
        public static Vector2 zx(this Vector3 a) { return new Vector2(a.z, a.x); }
        public static Vector2 _1y(this Vector3 a) { return new Vector2(1.0f, a.y); }
        public static Vector2 _0y(this Vector3 a) { return new Vector2(0.0f, a.y); }
        public static Vector2 xy(this Vector3 a) { return new Vector2(a.x, a.y); }
        public static Vector2 yy(this Vector3 a) { return new Vector2(a.y, a.y); }
        public static Vector2 zy(this Vector3 a) { return new Vector2(a.z, a.y); }
        public static Vector2 _1z(this Vector3 a) { return new Vector2(1.0f, a.z); }
        public static Vector2 _0z(this Vector3 a) { return new Vector2(0.0f, a.z); }
        public static Vector2 xz(this Vector3 a) { return new Vector2(a.x, a.z); }
        public static Vector2 yz(this Vector3 a) { return new Vector2(a.y, a.z); }
        public static Vector2 zz(this Vector3 a) { return new Vector2(a.z, a.z); }
        //swizzles of size 3
        public static Vector3 _111(this Vector3 a) { return new Vector3(1.0f, 1.0f, 1.0f); }
        public static Vector3 _011(this Vector3 a) { return new Vector3(0.0f, 1.0f, 1.0f); }
        public static Vector3 x11(this Vector3 a) { return new Vector3(a.x, 1.0f, 1.0f); }
        public static Vector3 y11(this Vector3 a) { return new Vector3(a.y, 1.0f, 1.0f); }
        public static Vector3 z11(this Vector3 a) { return new Vector3(a.z, 1.0f, 1.0f); }
        public static Vector3 _101(this Vector3 a) { return new Vector3(1.0f, 0.0f, 1.0f); }
        public static Vector3 _001(this Vector3 a) { return new Vector3(0.0f, 0.0f, 1.0f); }
        public static Vector3 x01(this Vector3 a) { return new Vector3(a.x, 0.0f, 1.0f); }
        public static Vector3 y01(this Vector3 a) { return new Vector3(a.y, 0.0f, 1.0f); }
        public static Vector3 z01(this Vector3 a) { return new Vector3(a.z, 0.0f, 1.0f); }
        public static Vector3 _1x1(this Vector3 a) { return new Vector3(1.0f, a.x, 1.0f); }
        public static Vector3 _0x1(this Vector3 a) { return new Vector3(0.0f, a.x, 1.0f); }
        public static Vector3 xx1(this Vector3 a) { return new Vector3(a.x, a.x, 1.0f); }
        public static Vector3 yx1(this Vector3 a) { return new Vector3(a.y, a.x, 1.0f); }
        public static Vector3 zx1(this Vector3 a) { return new Vector3(a.z, a.x, 1.0f); }
        public static Vector3 _1y1(this Vector3 a) { return new Vector3(1.0f, a.y, 1.0f); }
        public static Vector3 _0y1(this Vector3 a) { return new Vector3(0.0f, a.y, 1.0f); }
        public static Vector3 xy1(this Vector3 a) { return new Vector3(a.x, a.y, 1.0f); }
        public static Vector3 yy1(this Vector3 a) { return new Vector3(a.y, a.y, 1.0f); }
        public static Vector3 zy1(this Vector3 a) { return new Vector3(a.z, a.y, 1.0f); }
        public static Vector3 _1z1(this Vector3 a) { return new Vector3(1.0f, a.z, 1.0f); }
        public static Vector3 _0z1(this Vector3 a) { return new Vector3(0.0f, a.z, 1.0f); }
        public static Vector3 xz1(this Vector3 a) { return new Vector3(a.x, a.z, 1.0f); }
        public static Vector3 yz1(this Vector3 a) { return new Vector3(a.y, a.z, 1.0f); }
        public static Vector3 zz1(this Vector3 a) { return new Vector3(a.z, a.z, 1.0f); }
        public static Vector3 _110(this Vector3 a) { return new Vector3(1.0f, 1.0f, 0.0f); }
        public static Vector3 _010(this Vector3 a) { return new Vector3(0.0f, 1.0f, 0.0f); }
        public static Vector3 x10(this Vector3 a) { return new Vector3(a.x, 1.0f, 0.0f); }
        public static Vector3 y10(this Vector3 a) { return new Vector3(a.y, 1.0f, 0.0f); }
        public static Vector3 z10(this Vector3 a) { return new Vector3(a.z, 1.0f, 0.0f); }
        public static Vector3 _100(this Vector3 a) { return new Vector3(1.0f, 0.0f, 0.0f); }
        public static Vector3 _000(this Vector3 a) { return new Vector3(0.0f, 0.0f, 0.0f); }
        public static Vector3 x00(this Vector3 a) { return new Vector3(a.x, 0.0f, 0.0f); }
        public static Vector3 y00(this Vector3 a) { return new Vector3(a.y, 0.0f, 0.0f); }
        public static Vector3 z00(this Vector3 a) { return new Vector3(a.z, 0.0f, 0.0f); }
        public static Vector3 _1x0(this Vector3 a) { return new Vector3(1.0f, a.x, 0.0f); }
        public static Vector3 _0x0(this Vector3 a) { return new Vector3(0.0f, a.x, 0.0f); }
        public static Vector3 xx0(this Vector3 a) { return new Vector3(a.x, a.x, 0.0f); }
        public static Vector3 yx0(this Vector3 a) { return new Vector3(a.y, a.x, 0.0f); }
        public static Vector3 zx0(this Vector3 a) { return new Vector3(a.z, a.x, 0.0f); }
        public static Vector3 _1y0(this Vector3 a) { return new Vector3(1.0f, a.y, 0.0f); }
        public static Vector3 _0y0(this Vector3 a) { return new Vector3(0.0f, a.y, 0.0f); }
        public static Vector3 xy0(this Vector3 a) { return new Vector3(a.x, a.y, 0.0f); }
        public static Vector3 yy0(this Vector3 a) { return new Vector3(a.y, a.y, 0.0f); }
        public static Vector3 zy0(this Vector3 a) { return new Vector3(a.z, a.y, 0.0f); }
        public static Vector3 _1z0(this Vector3 a) { return new Vector3(1.0f, a.z, 0.0f); }
        public static Vector3 _0z0(this Vector3 a) { return new Vector3(0.0f, a.z, 0.0f); }
        public static Vector3 xz0(this Vector3 a) { return new Vector3(a.x, a.z, 0.0f); }
        public static Vector3 yz0(this Vector3 a) { return new Vector3(a.y, a.z, 0.0f); }
        public static Vector3 zz0(this Vector3 a) { return new Vector3(a.z, a.z, 0.0f); }
        public static Vector3 _11x(this Vector3 a) { return new Vector3(1.0f, 1.0f, a.x); }
        public static Vector3 _01x(this Vector3 a) { return new Vector3(0.0f, 1.0f, a.x); }
        public static Vector3 x1x(this Vector3 a) { return new Vector3(a.x, 1.0f, a.x); }
        public static Vector3 y1x(this Vector3 a) { return new Vector3(a.y, 1.0f, a.x); }
        public static Vector3 z1x(this Vector3 a) { return new Vector3(a.z, 1.0f, a.x); }
        public static Vector3 _10x(this Vector3 a) { return new Vector3(1.0f, 0.0f, a.x); }
        public static Vector3 _00x(this Vector3 a) { return new Vector3(0.0f, 0.0f, a.x); }
        public static Vector3 x0x(this Vector3 a) { return new Vector3(a.x, 0.0f, a.x); }
        public static Vector3 y0x(this Vector3 a) { return new Vector3(a.y, 0.0f, a.x); }
        public static Vector3 z0x(this Vector3 a) { return new Vector3(a.z, 0.0f, a.x); }
        public static Vector3 _1xx(this Vector3 a) { return new Vector3(1.0f, a.x, a.x); }
        public static Vector3 _0xx(this Vector3 a) { return new Vector3(0.0f, a.x, a.x); }
        public static Vector3 xxx(this Vector3 a) { return new Vector3(a.x, a.x, a.x); }
        public static Vector3 yxx(this Vector3 a) { return new Vector3(a.y, a.x, a.x); }
        public static Vector3 zxx(this Vector3 a) { return new Vector3(a.z, a.x, a.x); }
        public static Vector3 _1yx(this Vector3 a) { return new Vector3(1.0f, a.y, a.x); }
        public static Vector3 _0yx(this Vector3 a) { return new Vector3(0.0f, a.y, a.x); }
        public static Vector3 xyx(this Vector3 a) { return new Vector3(a.x, a.y, a.x); }
        public static Vector3 yyx(this Vector3 a) { return new Vector3(a.y, a.y, a.x); }
        public static Vector3 zyx(this Vector3 a) { return new Vector3(a.z, a.y, a.x); }
        public static Vector3 _1zx(this Vector3 a) { return new Vector3(1.0f, a.z, a.x); }
        public static Vector3 _0zx(this Vector3 a) { return new Vector3(0.0f, a.z, a.x); }
        public static Vector3 xzx(this Vector3 a) { return new Vector3(a.x, a.z, a.x); }
        public static Vector3 yzx(this Vector3 a) { return new Vector3(a.y, a.z, a.x); }
        public static Vector3 zzx(this Vector3 a) { return new Vector3(a.z, a.z, a.x); }
        public static Vector3 _11y(this Vector3 a) { return new Vector3(1.0f, 1.0f, a.y); }
        public static Vector3 _01y(this Vector3 a) { return new Vector3(0.0f, 1.0f, a.y); }
        public static Vector3 x1y(this Vector3 a) { return new Vector3(a.x, 1.0f, a.y); }
        public static Vector3 y1y(this Vector3 a) { return new Vector3(a.y, 1.0f, a.y); }
        public static Vector3 z1y(this Vector3 a) { return new Vector3(a.z, 1.0f, a.y); }
        public static Vector3 _10y(this Vector3 a) { return new Vector3(1.0f, 0.0f, a.y); }
        public static Vector3 _00y(this Vector3 a) { return new Vector3(0.0f, 0.0f, a.y); }
        public static Vector3 x0y(this Vector3 a) { return new Vector3(a.x, 0.0f, a.y); }
        public static Vector3 y0y(this Vector3 a) { return new Vector3(a.y, 0.0f, a.y); }
        public static Vector3 z0y(this Vector3 a) { return new Vector3(a.z, 0.0f, a.y); }
        public static Vector3 _1xy(this Vector3 a) { return new Vector3(1.0f, a.x, a.y); }
        public static Vector3 _0xy(this Vector3 a) { return new Vector3(0.0f, a.x, a.y); }
        public static Vector3 xxy(this Vector3 a) { return new Vector3(a.x, a.x, a.y); }
        public static Vector3 yxy(this Vector3 a) { return new Vector3(a.y, a.x, a.y); }
        public static Vector3 zxy(this Vector3 a) { return new Vector3(a.z, a.x, a.y); }
        public static Vector3 _1yy(this Vector3 a) { return new Vector3(1.0f, a.y, a.y); }
        public static Vector3 _0yy(this Vector3 a) { return new Vector3(0.0f, a.y, a.y); }
        public static Vector3 xyy(this Vector3 a) { return new Vector3(a.x, a.y, a.y); }
        public static Vector3 yyy(this Vector3 a) { return new Vector3(a.y, a.y, a.y); }
        public static Vector3 zyy(this Vector3 a) { return new Vector3(a.z, a.y, a.y); }
        public static Vector3 _1zy(this Vector3 a) { return new Vector3(1.0f, a.z, a.y); }
        public static Vector3 _0zy(this Vector3 a) { return new Vector3(0.0f, a.z, a.y); }
        public static Vector3 xzy(this Vector3 a) { return new Vector3(a.x, a.z, a.y); }
        public static Vector3 yzy(this Vector3 a) { return new Vector3(a.y, a.z, a.y); }
        public static Vector3 zzy(this Vector3 a) { return new Vector3(a.z, a.z, a.y); }
        public static Vector3 _11z(this Vector3 a) { return new Vector3(1.0f, 1.0f, a.z); }
        public static Vector3 _01z(this Vector3 a) { return new Vector3(0.0f, 1.0f, a.z); }
        public static Vector3 x1z(this Vector3 a) { return new Vector3(a.x, 1.0f, a.z); }
        public static Vector3 y1z(this Vector3 a) { return new Vector3(a.y, 1.0f, a.z); }
        public static Vector3 z1z(this Vector3 a) { return new Vector3(a.z, 1.0f, a.z); }
        public static Vector3 _10z(this Vector3 a) { return new Vector3(1.0f, 0.0f, a.z); }
        public static Vector3 _00z(this Vector3 a) { return new Vector3(0.0f, 0.0f, a.z); }
        public static Vector3 x0z(this Vector3 a) { return new Vector3(a.x, 0.0f, a.z); }
        public static Vector3 y0z(this Vector3 a) { return new Vector3(a.y, 0.0f, a.z); }
        public static Vector3 z0z(this Vector3 a) { return new Vector3(a.z, 0.0f, a.z); }
        public static Vector3 _1xz(this Vector3 a) { return new Vector3(1.0f, a.x, a.z); }
        public static Vector3 _0xz(this Vector3 a) { return new Vector3(0.0f, a.x, a.z); }
        public static Vector3 xxz(this Vector3 a) { return new Vector3(a.x, a.x, a.z); }
        public static Vector3 yxz(this Vector3 a) { return new Vector3(a.y, a.x, a.z); }
        public static Vector3 zxz(this Vector3 a) { return new Vector3(a.z, a.x, a.z); }
        public static Vector3 _1yz(this Vector3 a) { return new Vector3(1.0f, a.y, a.z); }
        public static Vector3 _0yz(this Vector3 a) { return new Vector3(0.0f, a.y, a.z); }
        public static Vector3 xyz(this Vector3 a) { return new Vector3(a.x, a.y, a.z); }
        public static Vector3 yyz(this Vector3 a) { return new Vector3(a.y, a.y, a.z); }
        public static Vector3 zyz(this Vector3 a) { return new Vector3(a.z, a.y, a.z); }
        public static Vector3 _1zz(this Vector3 a) { return new Vector3(1.0f, a.z, a.z); }
        public static Vector3 _0zz(this Vector3 a) { return new Vector3(0.0f, a.z, a.z); }
        public static Vector3 xzz(this Vector3 a) { return new Vector3(a.x, a.z, a.z); }
        public static Vector3 yzz(this Vector3 a) { return new Vector3(a.y, a.z, a.z); }
        public static Vector3 zzz(this Vector3 a) { return new Vector3(a.z, a.z, a.z); }
        //swizzles of size 4
        public static Vector4 _1111(this Vector3 a) { return new Vector4(1.0f, 1.0f, 1.0f, 1.0f); }
        public static Vector4 _0111(this Vector3 a) { return new Vector4(0.0f, 1.0f, 1.0f, 1.0f); }
        public static Vector4 x111(this Vector3 a) { return new Vector4(a.x, 1.0f, 1.0f, 1.0f); }
        public static Vector4 y111(this Vector3 a) { return new Vector4(a.y, 1.0f, 1.0f, 1.0f); }
        public static Vector4 z111(this Vector3 a) { return new Vector4(a.z, 1.0f, 1.0f, 1.0f); }
        public static Vector4 _1011(this Vector3 a) { return new Vector4(1.0f, 0.0f, 1.0f, 1.0f); }
        public static Vector4 _0011(this Vector3 a) { return new Vector4(0.0f, 0.0f, 1.0f, 1.0f); }
        public static Vector4 x011(this Vector3 a) { return new Vector4(a.x, 0.0f, 1.0f, 1.0f); }
        public static Vector4 y011(this Vector3 a) { return new Vector4(a.y, 0.0f, 1.0f, 1.0f); }
        public static Vector4 z011(this Vector3 a) { return new Vector4(a.z, 0.0f, 1.0f, 1.0f); }
        public static Vector4 _1x11(this Vector3 a) { return new Vector4(1.0f, a.x, 1.0f, 1.0f); }
        public static Vector4 _0x11(this Vector3 a) { return new Vector4(0.0f, a.x, 1.0f, 1.0f); }
        public static Vector4 xx11(this Vector3 a) { return new Vector4(a.x, a.x, 1.0f, 1.0f); }
        public static Vector4 yx11(this Vector3 a) { return new Vector4(a.y, a.x, 1.0f, 1.0f); }
        public static Vector4 zx11(this Vector3 a) { return new Vector4(a.z, a.x, 1.0f, 1.0f); }
        public static Vector4 _1y11(this Vector3 a) { return new Vector4(1.0f, a.y, 1.0f, 1.0f); }
        public static Vector4 _0y11(this Vector3 a) { return new Vector4(0.0f, a.y, 1.0f, 1.0f); }
        public static Vector4 xy11(this Vector3 a) { return new Vector4(a.x, a.y, 1.0f, 1.0f); }
        public static Vector4 yy11(this Vector3 a) { return new Vector4(a.y, a.y, 1.0f, 1.0f); }
        public static Vector4 zy11(this Vector3 a) { return new Vector4(a.z, a.y, 1.0f, 1.0f); }
        public static Vector4 _1z11(this Vector3 a) { return new Vector4(1.0f, a.z, 1.0f, 1.0f); }
        public static Vector4 _0z11(this Vector3 a) { return new Vector4(0.0f, a.z, 1.0f, 1.0f); }
        public static Vector4 xz11(this Vector3 a) { return new Vector4(a.x, a.z, 1.0f, 1.0f); }
        public static Vector4 yz11(this Vector3 a) { return new Vector4(a.y, a.z, 1.0f, 1.0f); }
        public static Vector4 zz11(this Vector3 a) { return new Vector4(a.z, a.z, 1.0f, 1.0f); }
        public static Vector4 _1101(this Vector3 a) { return new Vector4(1.0f, 1.0f, 0.0f, 1.0f); }
        public static Vector4 _0101(this Vector3 a) { return new Vector4(0.0f, 1.0f, 0.0f, 1.0f); }
        public static Vector4 x101(this Vector3 a) { return new Vector4(a.x, 1.0f, 0.0f, 1.0f); }
        public static Vector4 y101(this Vector3 a) { return new Vector4(a.y, 1.0f, 0.0f, 1.0f); }
        public static Vector4 z101(this Vector3 a) { return new Vector4(a.z, 1.0f, 0.0f, 1.0f); }
        public static Vector4 _1001(this Vector3 a) { return new Vector4(1.0f, 0.0f, 0.0f, 1.0f); }
        public static Vector4 _0001(this Vector3 a) { return new Vector4(0.0f, 0.0f, 0.0f, 1.0f); }
        public static Vector4 x001(this Vector3 a) { return new Vector4(a.x, 0.0f, 0.0f, 1.0f); }
        public static Vector4 y001(this Vector3 a) { return new Vector4(a.y, 0.0f, 0.0f, 1.0f); }
        public static Vector4 z001(this Vector3 a) { return new Vector4(a.z, 0.0f, 0.0f, 1.0f); }
        public static Vector4 _1x01(this Vector3 a) { return new Vector4(1.0f, a.x, 0.0f, 1.0f); }
        public static Vector4 _0x01(this Vector3 a) { return new Vector4(0.0f, a.x, 0.0f, 1.0f); }
        public static Vector4 xx01(this Vector3 a) { return new Vector4(a.x, a.x, 0.0f, 1.0f); }
        public static Vector4 yx01(this Vector3 a) { return new Vector4(a.y, a.x, 0.0f, 1.0f); }
        public static Vector4 zx01(this Vector3 a) { return new Vector4(a.z, a.x, 0.0f, 1.0f); }
        public static Vector4 _1y01(this Vector3 a) { return new Vector4(1.0f, a.y, 0.0f, 1.0f); }
        public static Vector4 _0y01(this Vector3 a) { return new Vector4(0.0f, a.y, 0.0f, 1.0f); }
        public static Vector4 xy01(this Vector3 a) { return new Vector4(a.x, a.y, 0.0f, 1.0f); }
        public static Vector4 yy01(this Vector3 a) { return new Vector4(a.y, a.y, 0.0f, 1.0f); }
        public static Vector4 zy01(this Vector3 a) { return new Vector4(a.z, a.y, 0.0f, 1.0f); }
        public static Vector4 _1z01(this Vector3 a) { return new Vector4(1.0f, a.z, 0.0f, 1.0f); }
        public static Vector4 _0z01(this Vector3 a) { return new Vector4(0.0f, a.z, 0.0f, 1.0f); }
        public static Vector4 xz01(this Vector3 a) { return new Vector4(a.x, a.z, 0.0f, 1.0f); }
        public static Vector4 yz01(this Vector3 a) { return new Vector4(a.y, a.z, 0.0f, 1.0f); }
        public static Vector4 zz01(this Vector3 a) { return new Vector4(a.z, a.z, 0.0f, 1.0f); }
        public static Vector4 _11x1(this Vector3 a) { return new Vector4(1.0f, 1.0f, a.x, 1.0f); }
        public static Vector4 _01x1(this Vector3 a) { return new Vector4(0.0f, 1.0f, a.x, 1.0f); }
        public static Vector4 x1x1(this Vector3 a) { return new Vector4(a.x, 1.0f, a.x, 1.0f); }
        public static Vector4 y1x1(this Vector3 a) { return new Vector4(a.y, 1.0f, a.x, 1.0f); }
        public static Vector4 z1x1(this Vector3 a) { return new Vector4(a.z, 1.0f, a.x, 1.0f); }
        public static Vector4 _10x1(this Vector3 a) { return new Vector4(1.0f, 0.0f, a.x, 1.0f); }
        public static Vector4 _00x1(this Vector3 a) { return new Vector4(0.0f, 0.0f, a.x, 1.0f); }
        public static Vector4 x0x1(this Vector3 a) { return new Vector4(a.x, 0.0f, a.x, 1.0f); }
        public static Vector4 y0x1(this Vector3 a) { return new Vector4(a.y, 0.0f, a.x, 1.0f); }
        public static Vector4 z0x1(this Vector3 a) { return new Vector4(a.z, 0.0f, a.x, 1.0f); }
        public static Vector4 _1xx1(this Vector3 a) { return new Vector4(1.0f, a.x, a.x, 1.0f); }
        public static Vector4 _0xx1(this Vector3 a) { return new Vector4(0.0f, a.x, a.x, 1.0f); }
        public static Vector4 xxx1(this Vector3 a) { return new Vector4(a.x, a.x, a.x, 1.0f); }
        public static Vector4 yxx1(this Vector3 a) { return new Vector4(a.y, a.x, a.x, 1.0f); }
        public static Vector4 zxx1(this Vector3 a) { return new Vector4(a.z, a.x, a.x, 1.0f); }
        public static Vector4 _1yx1(this Vector3 a) { return new Vector4(1.0f, a.y, a.x, 1.0f); }
        public static Vector4 _0yx1(this Vector3 a) { return new Vector4(0.0f, a.y, a.x, 1.0f); }
        public static Vector4 xyx1(this Vector3 a) { return new Vector4(a.x, a.y, a.x, 1.0f); }
        public static Vector4 yyx1(this Vector3 a) { return new Vector4(a.y, a.y, a.x, 1.0f); }
        public static Vector4 zyx1(this Vector3 a) { return new Vector4(a.z, a.y, a.x, 1.0f); }
        public static Vector4 _1zx1(this Vector3 a) { return new Vector4(1.0f, a.z, a.x, 1.0f); }
        public static Vector4 _0zx1(this Vector3 a) { return new Vector4(0.0f, a.z, a.x, 1.0f); }
        public static Vector4 xzx1(this Vector3 a) { return new Vector4(a.x, a.z, a.x, 1.0f); }
        public static Vector4 yzx1(this Vector3 a) { return new Vector4(a.y, a.z, a.x, 1.0f); }
        public static Vector4 zzx1(this Vector3 a) { return new Vector4(a.z, a.z, a.x, 1.0f); }
        public static Vector4 _11y1(this Vector3 a) { return new Vector4(1.0f, 1.0f, a.y, 1.0f); }
        public static Vector4 _01y1(this Vector3 a) { return new Vector4(0.0f, 1.0f, a.y, 1.0f); }
        public static Vector4 x1y1(this Vector3 a) { return new Vector4(a.x, 1.0f, a.y, 1.0f); }
        public static Vector4 y1y1(this Vector3 a) { return new Vector4(a.y, 1.0f, a.y, 1.0f); }
        public static Vector4 z1y1(this Vector3 a) { return new Vector4(a.z, 1.0f, a.y, 1.0f); }
        public static Vector4 _10y1(this Vector3 a) { return new Vector4(1.0f, 0.0f, a.y, 1.0f); }
        public static Vector4 _00y1(this Vector3 a) { return new Vector4(0.0f, 0.0f, a.y, 1.0f); }
        public static Vector4 x0y1(this Vector3 a) { return new Vector4(a.x, 0.0f, a.y, 1.0f); }
        public static Vector4 y0y1(this Vector3 a) { return new Vector4(a.y, 0.0f, a.y, 1.0f); }
        public static Vector4 z0y1(this Vector3 a) { return new Vector4(a.z, 0.0f, a.y, 1.0f); }
        public static Vector4 _1xy1(this Vector3 a) { return new Vector4(1.0f, a.x, a.y, 1.0f); }
        public static Vector4 _0xy1(this Vector3 a) { return new Vector4(0.0f, a.x, a.y, 1.0f); }
        public static Vector4 xxy1(this Vector3 a) { return new Vector4(a.x, a.x, a.y, 1.0f); }
        public static Vector4 yxy1(this Vector3 a) { return new Vector4(a.y, a.x, a.y, 1.0f); }
        public static Vector4 zxy1(this Vector3 a) { return new Vector4(a.z, a.x, a.y, 1.0f); }
        public static Vector4 _1yy1(this Vector3 a) { return new Vector4(1.0f, a.y, a.y, 1.0f); }
        public static Vector4 _0yy1(this Vector3 a) { return new Vector4(0.0f, a.y, a.y, 1.0f); }
        public static Vector4 xyy1(this Vector3 a) { return new Vector4(a.x, a.y, a.y, 1.0f); }
        public static Vector4 yyy1(this Vector3 a) { return new Vector4(a.y, a.y, a.y, 1.0f); }
        public static Vector4 zyy1(this Vector3 a) { return new Vector4(a.z, a.y, a.y, 1.0f); }
        public static Vector4 _1zy1(this Vector3 a) { return new Vector4(1.0f, a.z, a.y, 1.0f); }
        public static Vector4 _0zy1(this Vector3 a) { return new Vector4(0.0f, a.z, a.y, 1.0f); }
        public static Vector4 xzy1(this Vector3 a) { return new Vector4(a.x, a.z, a.y, 1.0f); }
        public static Vector4 yzy1(this Vector3 a) { return new Vector4(a.y, a.z, a.y, 1.0f); }
        public static Vector4 zzy1(this Vector3 a) { return new Vector4(a.z, a.z, a.y, 1.0f); }
        public static Vector4 _11z1(this Vector3 a) { return new Vector4(1.0f, 1.0f, a.z, 1.0f); }
        public static Vector4 _01z1(this Vector3 a) { return new Vector4(0.0f, 1.0f, a.z, 1.0f); }
        public static Vector4 x1z1(this Vector3 a) { return new Vector4(a.x, 1.0f, a.z, 1.0f); }
        public static Vector4 y1z1(this Vector3 a) { return new Vector4(a.y, 1.0f, a.z, 1.0f); }
        public static Vector4 z1z1(this Vector3 a) { return new Vector4(a.z, 1.0f, a.z, 1.0f); }
        public static Vector4 _10z1(this Vector3 a) { return new Vector4(1.0f, 0.0f, a.z, 1.0f); }
        public static Vector4 _00z1(this Vector3 a) { return new Vector4(0.0f, 0.0f, a.z, 1.0f); }
        public static Vector4 x0z1(this Vector3 a) { return new Vector4(a.x, 0.0f, a.z, 1.0f); }
        public static Vector4 y0z1(this Vector3 a) { return new Vector4(a.y, 0.0f, a.z, 1.0f); }
        public static Vector4 z0z1(this Vector3 a) { return new Vector4(a.z, 0.0f, a.z, 1.0f); }
        public static Vector4 _1xz1(this Vector3 a) { return new Vector4(1.0f, a.x, a.z, 1.0f); }
        public static Vector4 _0xz1(this Vector3 a) { return new Vector4(0.0f, a.x, a.z, 1.0f); }
        public static Vector4 xxz1(this Vector3 a) { return new Vector4(a.x, a.x, a.z, 1.0f); }
        public static Vector4 yxz1(this Vector3 a) { return new Vector4(a.y, a.x, a.z, 1.0f); }
        public static Vector4 zxz1(this Vector3 a) { return new Vector4(a.z, a.x, a.z, 1.0f); }
        public static Vector4 _1yz1(this Vector3 a) { return new Vector4(1.0f, a.y, a.z, 1.0f); }
        public static Vector4 _0yz1(this Vector3 a) { return new Vector4(0.0f, a.y, a.z, 1.0f); }
        public static Vector4 xyz1(this Vector3 a) { return new Vector4(a.x, a.y, a.z, 1.0f); }
        public static Vector4 yyz1(this Vector3 a) { return new Vector4(a.y, a.y, a.z, 1.0f); }
        public static Vector4 zyz1(this Vector3 a) { return new Vector4(a.z, a.y, a.z, 1.0f); }
        public static Vector4 _1zz1(this Vector3 a) { return new Vector4(1.0f, a.z, a.z, 1.0f); }
        public static Vector4 _0zz1(this Vector3 a) { return new Vector4(0.0f, a.z, a.z, 1.0f); }
        public static Vector4 xzz1(this Vector3 a) { return new Vector4(a.x, a.z, a.z, 1.0f); }
        public static Vector4 yzz1(this Vector3 a) { return new Vector4(a.y, a.z, a.z, 1.0f); }
        public static Vector4 zzz1(this Vector3 a) { return new Vector4(a.z, a.z, a.z, 1.0f); }
        public static Vector4 _1110(this Vector3 a) { return new Vector4(1.0f, 1.0f, 1.0f, 0.0f); }
        public static Vector4 _0110(this Vector3 a) { return new Vector4(0.0f, 1.0f, 1.0f, 0.0f); }
        public static Vector4 x110(this Vector3 a) { return new Vector4(a.x, 1.0f, 1.0f, 0.0f); }
        public static Vector4 y110(this Vector3 a) { return new Vector4(a.y, 1.0f, 1.0f, 0.0f); }
        public static Vector4 z110(this Vector3 a) { return new Vector4(a.z, 1.0f, 1.0f, 0.0f); }
        public static Vector4 _1010(this Vector3 a) { return new Vector4(1.0f, 0.0f, 1.0f, 0.0f); }
        public static Vector4 _0010(this Vector3 a) { return new Vector4(0.0f, 0.0f, 1.0f, 0.0f); }
        public static Vector4 x010(this Vector3 a) { return new Vector4(a.x, 0.0f, 1.0f, 0.0f); }
        public static Vector4 y010(this Vector3 a) { return new Vector4(a.y, 0.0f, 1.0f, 0.0f); }
        public static Vector4 z010(this Vector3 a) { return new Vector4(a.z, 0.0f, 1.0f, 0.0f); }
        public static Vector4 _1x10(this Vector3 a) { return new Vector4(1.0f, a.x, 1.0f, 0.0f); }
        public static Vector4 _0x10(this Vector3 a) { return new Vector4(0.0f, a.x, 1.0f, 0.0f); }
        public static Vector4 xx10(this Vector3 a) { return new Vector4(a.x, a.x, 1.0f, 0.0f); }
        public static Vector4 yx10(this Vector3 a) { return new Vector4(a.y, a.x, 1.0f, 0.0f); }
        public static Vector4 zx10(this Vector3 a) { return new Vector4(a.z, a.x, 1.0f, 0.0f); }
        public static Vector4 _1y10(this Vector3 a) { return new Vector4(1.0f, a.y, 1.0f, 0.0f); }
        public static Vector4 _0y10(this Vector3 a) { return new Vector4(0.0f, a.y, 1.0f, 0.0f); }
        public static Vector4 xy10(this Vector3 a) { return new Vector4(a.x, a.y, 1.0f, 0.0f); }
        public static Vector4 yy10(this Vector3 a) { return new Vector4(a.y, a.y, 1.0f, 0.0f); }
        public static Vector4 zy10(this Vector3 a) { return new Vector4(a.z, a.y, 1.0f, 0.0f); }
        public static Vector4 _1z10(this Vector3 a) { return new Vector4(1.0f, a.z, 1.0f, 0.0f); }
        public static Vector4 _0z10(this Vector3 a) { return new Vector4(0.0f, a.z, 1.0f, 0.0f); }
        public static Vector4 xz10(this Vector3 a) { return new Vector4(a.x, a.z, 1.0f, 0.0f); }
        public static Vector4 yz10(this Vector3 a) { return new Vector4(a.y, a.z, 1.0f, 0.0f); }
        public static Vector4 zz10(this Vector3 a) { return new Vector4(a.z, a.z, 1.0f, 0.0f); }
        public static Vector4 _1100(this Vector3 a) { return new Vector4(1.0f, 1.0f, 0.0f, 0.0f); }
        public static Vector4 _0100(this Vector3 a) { return new Vector4(0.0f, 1.0f, 0.0f, 0.0f); }
        public static Vector4 x100(this Vector3 a) { return new Vector4(a.x, 1.0f, 0.0f, 0.0f); }
        public static Vector4 y100(this Vector3 a) { return new Vector4(a.y, 1.0f, 0.0f, 0.0f); }
        public static Vector4 z100(this Vector3 a) { return new Vector4(a.z, 1.0f, 0.0f, 0.0f); }
        public static Vector4 _1000(this Vector3 a) { return new Vector4(1.0f, 0.0f, 0.0f, 0.0f); }
        public static Vector4 _0000(this Vector3 a) { return new Vector4(0.0f, 0.0f, 0.0f, 0.0f); }
        public static Vector4 x000(this Vector3 a) { return new Vector4(a.x, 0.0f, 0.0f, 0.0f); }
        public static Vector4 y000(this Vector3 a) { return new Vector4(a.y, 0.0f, 0.0f, 0.0f); }
        public static Vector4 z000(this Vector3 a) { return new Vector4(a.z, 0.0f, 0.0f, 0.0f); }
        public static Vector4 _1x00(this Vector3 a) { return new Vector4(1.0f, a.x, 0.0f, 0.0f); }
        public static Vector4 _0x00(this Vector3 a) { return new Vector4(0.0f, a.x, 0.0f, 0.0f); }
        public static Vector4 xx00(this Vector3 a) { return new Vector4(a.x, a.x, 0.0f, 0.0f); }
        public static Vector4 yx00(this Vector3 a) { return new Vector4(a.y, a.x, 0.0f, 0.0f); }
        public static Vector4 zx00(this Vector3 a) { return new Vector4(a.z, a.x, 0.0f, 0.0f); }
        public static Vector4 _1y00(this Vector3 a) { return new Vector4(1.0f, a.y, 0.0f, 0.0f); }
        public static Vector4 _0y00(this Vector3 a) { return new Vector4(0.0f, a.y, 0.0f, 0.0f); }
        public static Vector4 xy00(this Vector3 a) { return new Vector4(a.x, a.y, 0.0f, 0.0f); }
        public static Vector4 yy00(this Vector3 a) { return new Vector4(a.y, a.y, 0.0f, 0.0f); }
        public static Vector4 zy00(this Vector3 a) { return new Vector4(a.z, a.y, 0.0f, 0.0f); }
        public static Vector4 _1z00(this Vector3 a) { return new Vector4(1.0f, a.z, 0.0f, 0.0f); }
        public static Vector4 _0z00(this Vector3 a) { return new Vector4(0.0f, a.z, 0.0f, 0.0f); }
        public static Vector4 xz00(this Vector3 a) { return new Vector4(a.x, a.z, 0.0f, 0.0f); }
        public static Vector4 yz00(this Vector3 a) { return new Vector4(a.y, a.z, 0.0f, 0.0f); }
        public static Vector4 zz00(this Vector3 a) { return new Vector4(a.z, a.z, 0.0f, 0.0f); }
        public static Vector4 _11x0(this Vector3 a) { return new Vector4(1.0f, 1.0f, a.x, 0.0f); }
        public static Vector4 _01x0(this Vector3 a) { return new Vector4(0.0f, 1.0f, a.x, 0.0f); }
        public static Vector4 x1x0(this Vector3 a) { return new Vector4(a.x, 1.0f, a.x, 0.0f); }
        public static Vector4 y1x0(this Vector3 a) { return new Vector4(a.y, 1.0f, a.x, 0.0f); }
        public static Vector4 z1x0(this Vector3 a) { return new Vector4(a.z, 1.0f, a.x, 0.0f); }
        public static Vector4 _10x0(this Vector3 a) { return new Vector4(1.0f, 0.0f, a.x, 0.0f); }
        public static Vector4 _00x0(this Vector3 a) { return new Vector4(0.0f, 0.0f, a.x, 0.0f); }
        public static Vector4 x0x0(this Vector3 a) { return new Vector4(a.x, 0.0f, a.x, 0.0f); }
        public static Vector4 y0x0(this Vector3 a) { return new Vector4(a.y, 0.0f, a.x, 0.0f); }
        public static Vector4 z0x0(this Vector3 a) { return new Vector4(a.z, 0.0f, a.x, 0.0f); }
        public static Vector4 _1xx0(this Vector3 a) { return new Vector4(1.0f, a.x, a.x, 0.0f); }
        public static Vector4 _0xx0(this Vector3 a) { return new Vector4(0.0f, a.x, a.x, 0.0f); }
        public static Vector4 xxx0(this Vector3 a) { return new Vector4(a.x, a.x, a.x, 0.0f); }
        public static Vector4 yxx0(this Vector3 a) { return new Vector4(a.y, a.x, a.x, 0.0f); }
        public static Vector4 zxx0(this Vector3 a) { return new Vector4(a.z, a.x, a.x, 0.0f); }
        public static Vector4 _1yx0(this Vector3 a) { return new Vector4(1.0f, a.y, a.x, 0.0f); }
        public static Vector4 _0yx0(this Vector3 a) { return new Vector4(0.0f, a.y, a.x, 0.0f); }
        public static Vector4 xyx0(this Vector3 a) { return new Vector4(a.x, a.y, a.x, 0.0f); }
        public static Vector4 yyx0(this Vector3 a) { return new Vector4(a.y, a.y, a.x, 0.0f); }
        public static Vector4 zyx0(this Vector3 a) { return new Vector4(a.z, a.y, a.x, 0.0f); }
        public static Vector4 _1zx0(this Vector3 a) { return new Vector4(1.0f, a.z, a.x, 0.0f); }
        public static Vector4 _0zx0(this Vector3 a) { return new Vector4(0.0f, a.z, a.x, 0.0f); }
        public static Vector4 xzx0(this Vector3 a) { return new Vector4(a.x, a.z, a.x, 0.0f); }
        public static Vector4 yzx0(this Vector3 a) { return new Vector4(a.y, a.z, a.x, 0.0f); }
        public static Vector4 zzx0(this Vector3 a) { return new Vector4(a.z, a.z, a.x, 0.0f); }
        public static Vector4 _11y0(this Vector3 a) { return new Vector4(1.0f, 1.0f, a.y, 0.0f); }
        public static Vector4 _01y0(this Vector3 a) { return new Vector4(0.0f, 1.0f, a.y, 0.0f); }
        public static Vector4 x1y0(this Vector3 a) { return new Vector4(a.x, 1.0f, a.y, 0.0f); }
        public static Vector4 y1y0(this Vector3 a) { return new Vector4(a.y, 1.0f, a.y, 0.0f); }
        public static Vector4 z1y0(this Vector3 a) { return new Vector4(a.z, 1.0f, a.y, 0.0f); }
        public static Vector4 _10y0(this Vector3 a) { return new Vector4(1.0f, 0.0f, a.y, 0.0f); }
        public static Vector4 _00y0(this Vector3 a) { return new Vector4(0.0f, 0.0f, a.y, 0.0f); }
        public static Vector4 x0y0(this Vector3 a) { return new Vector4(a.x, 0.0f, a.y, 0.0f); }
        public static Vector4 y0y0(this Vector3 a) { return new Vector4(a.y, 0.0f, a.y, 0.0f); }
        public static Vector4 z0y0(this Vector3 a) { return new Vector4(a.z, 0.0f, a.y, 0.0f); }
        public static Vector4 _1xy0(this Vector3 a) { return new Vector4(1.0f, a.x, a.y, 0.0f); }
        public static Vector4 _0xy0(this Vector3 a) { return new Vector4(0.0f, a.x, a.y, 0.0f); }
        public static Vector4 xxy0(this Vector3 a) { return new Vector4(a.x, a.x, a.y, 0.0f); }
        public static Vector4 yxy0(this Vector3 a) { return new Vector4(a.y, a.x, a.y, 0.0f); }
        public static Vector4 zxy0(this Vector3 a) { return new Vector4(a.z, a.x, a.y, 0.0f); }
        public static Vector4 _1yy0(this Vector3 a) { return new Vector4(1.0f, a.y, a.y, 0.0f); }
        public static Vector4 _0yy0(this Vector3 a) { return new Vector4(0.0f, a.y, a.y, 0.0f); }
        public static Vector4 xyy0(this Vector3 a) { return new Vector4(a.x, a.y, a.y, 0.0f); }
        public static Vector4 yyy0(this Vector3 a) { return new Vector4(a.y, a.y, a.y, 0.0f); }
        public static Vector4 zyy0(this Vector3 a) { return new Vector4(a.z, a.y, a.y, 0.0f); }
        public static Vector4 _1zy0(this Vector3 a) { return new Vector4(1.0f, a.z, a.y, 0.0f); }
        public static Vector4 _0zy0(this Vector3 a) { return new Vector4(0.0f, a.z, a.y, 0.0f); }
        public static Vector4 xzy0(this Vector3 a) { return new Vector4(a.x, a.z, a.y, 0.0f); }
        public static Vector4 yzy0(this Vector3 a) { return new Vector4(a.y, a.z, a.y, 0.0f); }
        public static Vector4 zzy0(this Vector3 a) { return new Vector4(a.z, a.z, a.y, 0.0f); }
        public static Vector4 _11z0(this Vector3 a) { return new Vector4(1.0f, 1.0f, a.z, 0.0f); }
        public static Vector4 _01z0(this Vector3 a) { return new Vector4(0.0f, 1.0f, a.z, 0.0f); }
        public static Vector4 x1z0(this Vector3 a) { return new Vector4(a.x, 1.0f, a.z, 0.0f); }
        public static Vector4 y1z0(this Vector3 a) { return new Vector4(a.y, 1.0f, a.z, 0.0f); }
        public static Vector4 z1z0(this Vector3 a) { return new Vector4(a.z, 1.0f, a.z, 0.0f); }
        public static Vector4 _10z0(this Vector3 a) { return new Vector4(1.0f, 0.0f, a.z, 0.0f); }
        public static Vector4 _00z0(this Vector3 a) { return new Vector4(0.0f, 0.0f, a.z, 0.0f); }
        public static Vector4 x0z0(this Vector3 a) { return new Vector4(a.x, 0.0f, a.z, 0.0f); }
        public static Vector4 y0z0(this Vector3 a) { return new Vector4(a.y, 0.0f, a.z, 0.0f); }
        public static Vector4 z0z0(this Vector3 a) { return new Vector4(a.z, 0.0f, a.z, 0.0f); }
        public static Vector4 _1xz0(this Vector3 a) { return new Vector4(1.0f, a.x, a.z, 0.0f); }
        public static Vector4 _0xz0(this Vector3 a) { return new Vector4(0.0f, a.x, a.z, 0.0f); }
        public static Vector4 xxz0(this Vector3 a) { return new Vector4(a.x, a.x, a.z, 0.0f); }
        public static Vector4 yxz0(this Vector3 a) { return new Vector4(a.y, a.x, a.z, 0.0f); }
        public static Vector4 zxz0(this Vector3 a) { return new Vector4(a.z, a.x, a.z, 0.0f); }
        public static Vector4 _1yz0(this Vector3 a) { return new Vector4(1.0f, a.y, a.z, 0.0f); }
        public static Vector4 _0yz0(this Vector3 a) { return new Vector4(0.0f, a.y, a.z, 0.0f); }
        public static Vector4 xyz0(this Vector3 a) { return new Vector4(a.x, a.y, a.z, 0.0f); }
        public static Vector4 yyz0(this Vector3 a) { return new Vector4(a.y, a.y, a.z, 0.0f); }
        public static Vector4 zyz0(this Vector3 a) { return new Vector4(a.z, a.y, a.z, 0.0f); }
        public static Vector4 _1zz0(this Vector3 a) { return new Vector4(1.0f, a.z, a.z, 0.0f); }
        public static Vector4 _0zz0(this Vector3 a) { return new Vector4(0.0f, a.z, a.z, 0.0f); }
        public static Vector4 xzz0(this Vector3 a) { return new Vector4(a.x, a.z, a.z, 0.0f); }
        public static Vector4 yzz0(this Vector3 a) { return new Vector4(a.y, a.z, a.z, 0.0f); }
        public static Vector4 zzz0(this Vector3 a) { return new Vector4(a.z, a.z, a.z, 0.0f); }
        public static Vector4 _111x(this Vector3 a) { return new Vector4(1.0f, 1.0f, 1.0f, a.x); }
        public static Vector4 _011x(this Vector3 a) { return new Vector4(0.0f, 1.0f, 1.0f, a.x); }
        public static Vector4 x11x(this Vector3 a) { return new Vector4(a.x, 1.0f, 1.0f, a.x); }
        public static Vector4 y11x(this Vector3 a) { return new Vector4(a.y, 1.0f, 1.0f, a.x); }
        public static Vector4 z11x(this Vector3 a) { return new Vector4(a.z, 1.0f, 1.0f, a.x); }
        public static Vector4 _101x(this Vector3 a) { return new Vector4(1.0f, 0.0f, 1.0f, a.x); }
        public static Vector4 _001x(this Vector3 a) { return new Vector4(0.0f, 0.0f, 1.0f, a.x); }
        public static Vector4 x01x(this Vector3 a) { return new Vector4(a.x, 0.0f, 1.0f, a.x); }
        public static Vector4 y01x(this Vector3 a) { return new Vector4(a.y, 0.0f, 1.0f, a.x); }
        public static Vector4 z01x(this Vector3 a) { return new Vector4(a.z, 0.0f, 1.0f, a.x); }
        public static Vector4 _1x1x(this Vector3 a) { return new Vector4(1.0f, a.x, 1.0f, a.x); }
        public static Vector4 _0x1x(this Vector3 a) { return new Vector4(0.0f, a.x, 1.0f, a.x); }
        public static Vector4 xx1x(this Vector3 a) { return new Vector4(a.x, a.x, 1.0f, a.x); }
        public static Vector4 yx1x(this Vector3 a) { return new Vector4(a.y, a.x, 1.0f, a.x); }
        public static Vector4 zx1x(this Vector3 a) { return new Vector4(a.z, a.x, 1.0f, a.x); }
        public static Vector4 _1y1x(this Vector3 a) { return new Vector4(1.0f, a.y, 1.0f, a.x); }
        public static Vector4 _0y1x(this Vector3 a) { return new Vector4(0.0f, a.y, 1.0f, a.x); }
        public static Vector4 xy1x(this Vector3 a) { return new Vector4(a.x, a.y, 1.0f, a.x); }
        public static Vector4 yy1x(this Vector3 a) { return new Vector4(a.y, a.y, 1.0f, a.x); }
        public static Vector4 zy1x(this Vector3 a) { return new Vector4(a.z, a.y, 1.0f, a.x); }
        public static Vector4 _1z1x(this Vector3 a) { return new Vector4(1.0f, a.z, 1.0f, a.x); }
        public static Vector4 _0z1x(this Vector3 a) { return new Vector4(0.0f, a.z, 1.0f, a.x); }
        public static Vector4 xz1x(this Vector3 a) { return new Vector4(a.x, a.z, 1.0f, a.x); }
        public static Vector4 yz1x(this Vector3 a) { return new Vector4(a.y, a.z, 1.0f, a.x); }
        public static Vector4 zz1x(this Vector3 a) { return new Vector4(a.z, a.z, 1.0f, a.x); }
        public static Vector4 _110x(this Vector3 a) { return new Vector4(1.0f, 1.0f, 0.0f, a.x); }
        public static Vector4 _010x(this Vector3 a) { return new Vector4(0.0f, 1.0f, 0.0f, a.x); }
        public static Vector4 x10x(this Vector3 a) { return new Vector4(a.x, 1.0f, 0.0f, a.x); }
        public static Vector4 y10x(this Vector3 a) { return new Vector4(a.y, 1.0f, 0.0f, a.x); }
        public static Vector4 z10x(this Vector3 a) { return new Vector4(a.z, 1.0f, 0.0f, a.x); }
        public static Vector4 _100x(this Vector3 a) { return new Vector4(1.0f, 0.0f, 0.0f, a.x); }
        public static Vector4 _000x(this Vector3 a) { return new Vector4(0.0f, 0.0f, 0.0f, a.x); }
        public static Vector4 x00x(this Vector3 a) { return new Vector4(a.x, 0.0f, 0.0f, a.x); }
        public static Vector4 y00x(this Vector3 a) { return new Vector4(a.y, 0.0f, 0.0f, a.x); }
        public static Vector4 z00x(this Vector3 a) { return new Vector4(a.z, 0.0f, 0.0f, a.x); }
        public static Vector4 _1x0x(this Vector3 a) { return new Vector4(1.0f, a.x, 0.0f, a.x); }
        public static Vector4 _0x0x(this Vector3 a) { return new Vector4(0.0f, a.x, 0.0f, a.x); }
        public static Vector4 xx0x(this Vector3 a) { return new Vector4(a.x, a.x, 0.0f, a.x); }
        public static Vector4 yx0x(this Vector3 a) { return new Vector4(a.y, a.x, 0.0f, a.x); }
        public static Vector4 zx0x(this Vector3 a) { return new Vector4(a.z, a.x, 0.0f, a.x); }
        public static Vector4 _1y0x(this Vector3 a) { return new Vector4(1.0f, a.y, 0.0f, a.x); }
        public static Vector4 _0y0x(this Vector3 a) { return new Vector4(0.0f, a.y, 0.0f, a.x); }
        public static Vector4 xy0x(this Vector3 a) { return new Vector4(a.x, a.y, 0.0f, a.x); }
        public static Vector4 yy0x(this Vector3 a) { return new Vector4(a.y, a.y, 0.0f, a.x); }
        public static Vector4 zy0x(this Vector3 a) { return new Vector4(a.z, a.y, 0.0f, a.x); }
        public static Vector4 _1z0x(this Vector3 a) { return new Vector4(1.0f, a.z, 0.0f, a.x); }
        public static Vector4 _0z0x(this Vector3 a) { return new Vector4(0.0f, a.z, 0.0f, a.x); }
        public static Vector4 xz0x(this Vector3 a) { return new Vector4(a.x, a.z, 0.0f, a.x); }
        public static Vector4 yz0x(this Vector3 a) { return new Vector4(a.y, a.z, 0.0f, a.x); }
        public static Vector4 zz0x(this Vector3 a) { return new Vector4(a.z, a.z, 0.0f, a.x); }
        public static Vector4 _11xx(this Vector3 a) { return new Vector4(1.0f, 1.0f, a.x, a.x); }
        public static Vector4 _01xx(this Vector3 a) { return new Vector4(0.0f, 1.0f, a.x, a.x); }
        public static Vector4 x1xx(this Vector3 a) { return new Vector4(a.x, 1.0f, a.x, a.x); }
        public static Vector4 y1xx(this Vector3 a) { return new Vector4(a.y, 1.0f, a.x, a.x); }
        public static Vector4 z1xx(this Vector3 a) { return new Vector4(a.z, 1.0f, a.x, a.x); }
        public static Vector4 _10xx(this Vector3 a) { return new Vector4(1.0f, 0.0f, a.x, a.x); }
        public static Vector4 _00xx(this Vector3 a) { return new Vector4(0.0f, 0.0f, a.x, a.x); }
        public static Vector4 x0xx(this Vector3 a) { return new Vector4(a.x, 0.0f, a.x, a.x); }
        public static Vector4 y0xx(this Vector3 a) { return new Vector4(a.y, 0.0f, a.x, a.x); }
        public static Vector4 z0xx(this Vector3 a) { return new Vector4(a.z, 0.0f, a.x, a.x); }
        public static Vector4 _1xxx(this Vector3 a) { return new Vector4(1.0f, a.x, a.x, a.x); }
        public static Vector4 _0xxx(this Vector3 a) { return new Vector4(0.0f, a.x, a.x, a.x); }
        public static Vector4 xxxx(this Vector3 a) { return new Vector4(a.x, a.x, a.x, a.x); }
        public static Vector4 yxxx(this Vector3 a) { return new Vector4(a.y, a.x, a.x, a.x); }
        public static Vector4 zxxx(this Vector3 a) { return new Vector4(a.z, a.x, a.x, a.x); }
        public static Vector4 _1yxx(this Vector3 a) { return new Vector4(1.0f, a.y, a.x, a.x); }
        public static Vector4 _0yxx(this Vector3 a) { return new Vector4(0.0f, a.y, a.x, a.x); }
        public static Vector4 xyxx(this Vector3 a) { return new Vector4(a.x, a.y, a.x, a.x); }
        public static Vector4 yyxx(this Vector3 a) { return new Vector4(a.y, a.y, a.x, a.x); }
        public static Vector4 zyxx(this Vector3 a) { return new Vector4(a.z, a.y, a.x, a.x); }
        public static Vector4 _1zxx(this Vector3 a) { return new Vector4(1.0f, a.z, a.x, a.x); }
        public static Vector4 _0zxx(this Vector3 a) { return new Vector4(0.0f, a.z, a.x, a.x); }
        public static Vector4 xzxx(this Vector3 a) { return new Vector4(a.x, a.z, a.x, a.x); }
        public static Vector4 yzxx(this Vector3 a) { return new Vector4(a.y, a.z, a.x, a.x); }
        public static Vector4 zzxx(this Vector3 a) { return new Vector4(a.z, a.z, a.x, a.x); }
        public static Vector4 _11yx(this Vector3 a) { return new Vector4(1.0f, 1.0f, a.y, a.x); }
        public static Vector4 _01yx(this Vector3 a) { return new Vector4(0.0f, 1.0f, a.y, a.x); }
        public static Vector4 x1yx(this Vector3 a) { return new Vector4(a.x, 1.0f, a.y, a.x); }
        public static Vector4 y1yx(this Vector3 a) { return new Vector4(a.y, 1.0f, a.y, a.x); }
        public static Vector4 z1yx(this Vector3 a) { return new Vector4(a.z, 1.0f, a.y, a.x); }
        public static Vector4 _10yx(this Vector3 a) { return new Vector4(1.0f, 0.0f, a.y, a.x); }
        public static Vector4 _00yx(this Vector3 a) { return new Vector4(0.0f, 0.0f, a.y, a.x); }
        public static Vector4 x0yx(this Vector3 a) { return new Vector4(a.x, 0.0f, a.y, a.x); }
        public static Vector4 y0yx(this Vector3 a) { return new Vector4(a.y, 0.0f, a.y, a.x); }
        public static Vector4 z0yx(this Vector3 a) { return new Vector4(a.z, 0.0f, a.y, a.x); }
        public static Vector4 _1xyx(this Vector3 a) { return new Vector4(1.0f, a.x, a.y, a.x); }
        public static Vector4 _0xyx(this Vector3 a) { return new Vector4(0.0f, a.x, a.y, a.x); }
        public static Vector4 xxyx(this Vector3 a) { return new Vector4(a.x, a.x, a.y, a.x); }
        public static Vector4 yxyx(this Vector3 a) { return new Vector4(a.y, a.x, a.y, a.x); }
        public static Vector4 zxyx(this Vector3 a) { return new Vector4(a.z, a.x, a.y, a.x); }
        public static Vector4 _1yyx(this Vector3 a) { return new Vector4(1.0f, a.y, a.y, a.x); }
        public static Vector4 _0yyx(this Vector3 a) { return new Vector4(0.0f, a.y, a.y, a.x); }
        public static Vector4 xyyx(this Vector3 a) { return new Vector4(a.x, a.y, a.y, a.x); }
        public static Vector4 yyyx(this Vector3 a) { return new Vector4(a.y, a.y, a.y, a.x); }
        public static Vector4 zyyx(this Vector3 a) { return new Vector4(a.z, a.y, a.y, a.x); }
        public static Vector4 _1zyx(this Vector3 a) { return new Vector4(1.0f, a.z, a.y, a.x); }
        public static Vector4 _0zyx(this Vector3 a) { return new Vector4(0.0f, a.z, a.y, a.x); }
        public static Vector4 xzyx(this Vector3 a) { return new Vector4(a.x, a.z, a.y, a.x); }
        public static Vector4 yzyx(this Vector3 a) { return new Vector4(a.y, a.z, a.y, a.x); }
        public static Vector4 zzyx(this Vector3 a) { return new Vector4(a.z, a.z, a.y, a.x); }
        public static Vector4 _11zx(this Vector3 a) { return new Vector4(1.0f, 1.0f, a.z, a.x); }
        public static Vector4 _01zx(this Vector3 a) { return new Vector4(0.0f, 1.0f, a.z, a.x); }
        public static Vector4 x1zx(this Vector3 a) { return new Vector4(a.x, 1.0f, a.z, a.x); }
        public static Vector4 y1zx(this Vector3 a) { return new Vector4(a.y, 1.0f, a.z, a.x); }
        public static Vector4 z1zx(this Vector3 a) { return new Vector4(a.z, 1.0f, a.z, a.x); }
        public static Vector4 _10zx(this Vector3 a) { return new Vector4(1.0f, 0.0f, a.z, a.x); }
        public static Vector4 _00zx(this Vector3 a) { return new Vector4(0.0f, 0.0f, a.z, a.x); }
        public static Vector4 x0zx(this Vector3 a) { return new Vector4(a.x, 0.0f, a.z, a.x); }
        public static Vector4 y0zx(this Vector3 a) { return new Vector4(a.y, 0.0f, a.z, a.x); }
        public static Vector4 z0zx(this Vector3 a) { return new Vector4(a.z, 0.0f, a.z, a.x); }
        public static Vector4 _1xzx(this Vector3 a) { return new Vector4(1.0f, a.x, a.z, a.x); }
        public static Vector4 _0xzx(this Vector3 a) { return new Vector4(0.0f, a.x, a.z, a.x); }
        public static Vector4 xxzx(this Vector3 a) { return new Vector4(a.x, a.x, a.z, a.x); }
        public static Vector4 yxzx(this Vector3 a) { return new Vector4(a.y, a.x, a.z, a.x); }
        public static Vector4 zxzx(this Vector3 a) { return new Vector4(a.z, a.x, a.z, a.x); }
        public static Vector4 _1yzx(this Vector3 a) { return new Vector4(1.0f, a.y, a.z, a.x); }
        public static Vector4 _0yzx(this Vector3 a) { return new Vector4(0.0f, a.y, a.z, a.x); }
        public static Vector4 xyzx(this Vector3 a) { return new Vector4(a.x, a.y, a.z, a.x); }
        public static Vector4 yyzx(this Vector3 a) { return new Vector4(a.y, a.y, a.z, a.x); }
        public static Vector4 zyzx(this Vector3 a) { return new Vector4(a.z, a.y, a.z, a.x); }
        public static Vector4 _1zzx(this Vector3 a) { return new Vector4(1.0f, a.z, a.z, a.x); }
        public static Vector4 _0zzx(this Vector3 a) { return new Vector4(0.0f, a.z, a.z, a.x); }
        public static Vector4 xzzx(this Vector3 a) { return new Vector4(a.x, a.z, a.z, a.x); }
        public static Vector4 yzzx(this Vector3 a) { return new Vector4(a.y, a.z, a.z, a.x); }
        public static Vector4 zzzx(this Vector3 a) { return new Vector4(a.z, a.z, a.z, a.x); }
        public static Vector4 _111y(this Vector3 a) { return new Vector4(1.0f, 1.0f, 1.0f, a.y); }
        public static Vector4 _011y(this Vector3 a) { return new Vector4(0.0f, 1.0f, 1.0f, a.y); }
        public static Vector4 x11y(this Vector3 a) { return new Vector4(a.x, 1.0f, 1.0f, a.y); }
        public static Vector4 y11y(this Vector3 a) { return new Vector4(a.y, 1.0f, 1.0f, a.y); }
        public static Vector4 z11y(this Vector3 a) { return new Vector4(a.z, 1.0f, 1.0f, a.y); }
        public static Vector4 _101y(this Vector3 a) { return new Vector4(1.0f, 0.0f, 1.0f, a.y); }
        public static Vector4 _001y(this Vector3 a) { return new Vector4(0.0f, 0.0f, 1.0f, a.y); }
        public static Vector4 x01y(this Vector3 a) { return new Vector4(a.x, 0.0f, 1.0f, a.y); }
        public static Vector4 y01y(this Vector3 a) { return new Vector4(a.y, 0.0f, 1.0f, a.y); }
        public static Vector4 z01y(this Vector3 a) { return new Vector4(a.z, 0.0f, 1.0f, a.y); }
        public static Vector4 _1x1y(this Vector3 a) { return new Vector4(1.0f, a.x, 1.0f, a.y); }
        public static Vector4 _0x1y(this Vector3 a) { return new Vector4(0.0f, a.x, 1.0f, a.y); }
        public static Vector4 xx1y(this Vector3 a) { return new Vector4(a.x, a.x, 1.0f, a.y); }
        public static Vector4 yx1y(this Vector3 a) { return new Vector4(a.y, a.x, 1.0f, a.y); }
        public static Vector4 zx1y(this Vector3 a) { return new Vector4(a.z, a.x, 1.0f, a.y); }
        public static Vector4 _1y1y(this Vector3 a) { return new Vector4(1.0f, a.y, 1.0f, a.y); }
        public static Vector4 _0y1y(this Vector3 a) { return new Vector4(0.0f, a.y, 1.0f, a.y); }
        public static Vector4 xy1y(this Vector3 a) { return new Vector4(a.x, a.y, 1.0f, a.y); }
        public static Vector4 yy1y(this Vector3 a) { return new Vector4(a.y, a.y, 1.0f, a.y); }
        public static Vector4 zy1y(this Vector3 a) { return new Vector4(a.z, a.y, 1.0f, a.y); }
        public static Vector4 _1z1y(this Vector3 a) { return new Vector4(1.0f, a.z, 1.0f, a.y); }
        public static Vector4 _0z1y(this Vector3 a) { return new Vector4(0.0f, a.z, 1.0f, a.y); }
        public static Vector4 xz1y(this Vector3 a) { return new Vector4(a.x, a.z, 1.0f, a.y); }
        public static Vector4 yz1y(this Vector3 a) { return new Vector4(a.y, a.z, 1.0f, a.y); }
        public static Vector4 zz1y(this Vector3 a) { return new Vector4(a.z, a.z, 1.0f, a.y); }
        public static Vector4 _110y(this Vector3 a) { return new Vector4(1.0f, 1.0f, 0.0f, a.y); }
        public static Vector4 _010y(this Vector3 a) { return new Vector4(0.0f, 1.0f, 0.0f, a.y); }
        public static Vector4 x10y(this Vector3 a) { return new Vector4(a.x, 1.0f, 0.0f, a.y); }
        public static Vector4 y10y(this Vector3 a) { return new Vector4(a.y, 1.0f, 0.0f, a.y); }
        public static Vector4 z10y(this Vector3 a) { return new Vector4(a.z, 1.0f, 0.0f, a.y); }
        public static Vector4 _100y(this Vector3 a) { return new Vector4(1.0f, 0.0f, 0.0f, a.y); }
        public static Vector4 _000y(this Vector3 a) { return new Vector4(0.0f, 0.0f, 0.0f, a.y); }
        public static Vector4 x00y(this Vector3 a) { return new Vector4(a.x, 0.0f, 0.0f, a.y); }
        public static Vector4 y00y(this Vector3 a) { return new Vector4(a.y, 0.0f, 0.0f, a.y); }
        public static Vector4 z00y(this Vector3 a) { return new Vector4(a.z, 0.0f, 0.0f, a.y); }
        public static Vector4 _1x0y(this Vector3 a) { return new Vector4(1.0f, a.x, 0.0f, a.y); }
        public static Vector4 _0x0y(this Vector3 a) { return new Vector4(0.0f, a.x, 0.0f, a.y); }
        public static Vector4 xx0y(this Vector3 a) { return new Vector4(a.x, a.x, 0.0f, a.y); }
        public static Vector4 yx0y(this Vector3 a) { return new Vector4(a.y, a.x, 0.0f, a.y); }
        public static Vector4 zx0y(this Vector3 a) { return new Vector4(a.z, a.x, 0.0f, a.y); }
        public static Vector4 _1y0y(this Vector3 a) { return new Vector4(1.0f, a.y, 0.0f, a.y); }
        public static Vector4 _0y0y(this Vector3 a) { return new Vector4(0.0f, a.y, 0.0f, a.y); }
        public static Vector4 xy0y(this Vector3 a) { return new Vector4(a.x, a.y, 0.0f, a.y); }
        public static Vector4 yy0y(this Vector3 a) { return new Vector4(a.y, a.y, 0.0f, a.y); }
        public static Vector4 zy0y(this Vector3 a) { return new Vector4(a.z, a.y, 0.0f, a.y); }
        public static Vector4 _1z0y(this Vector3 a) { return new Vector4(1.0f, a.z, 0.0f, a.y); }
        public static Vector4 _0z0y(this Vector3 a) { return new Vector4(0.0f, a.z, 0.0f, a.y); }
        public static Vector4 xz0y(this Vector3 a) { return new Vector4(a.x, a.z, 0.0f, a.y); }
        public static Vector4 yz0y(this Vector3 a) { return new Vector4(a.y, a.z, 0.0f, a.y); }
        public static Vector4 zz0y(this Vector3 a) { return new Vector4(a.z, a.z, 0.0f, a.y); }
        public static Vector4 _11xy(this Vector3 a) { return new Vector4(1.0f, 1.0f, a.x, a.y); }
        public static Vector4 _01xy(this Vector3 a) { return new Vector4(0.0f, 1.0f, a.x, a.y); }
        public static Vector4 x1xy(this Vector3 a) { return new Vector4(a.x, 1.0f, a.x, a.y); }
        public static Vector4 y1xy(this Vector3 a) { return new Vector4(a.y, 1.0f, a.x, a.y); }
        public static Vector4 z1xy(this Vector3 a) { return new Vector4(a.z, 1.0f, a.x, a.y); }
        public static Vector4 _10xy(this Vector3 a) { return new Vector4(1.0f, 0.0f, a.x, a.y); }
        public static Vector4 _00xy(this Vector3 a) { return new Vector4(0.0f, 0.0f, a.x, a.y); }
        public static Vector4 x0xy(this Vector3 a) { return new Vector4(a.x, 0.0f, a.x, a.y); }
        public static Vector4 y0xy(this Vector3 a) { return new Vector4(a.y, 0.0f, a.x, a.y); }
        public static Vector4 z0xy(this Vector3 a) { return new Vector4(a.z, 0.0f, a.x, a.y); }
        public static Vector4 _1xxy(this Vector3 a) { return new Vector4(1.0f, a.x, a.x, a.y); }
        public static Vector4 _0xxy(this Vector3 a) { return new Vector4(0.0f, a.x, a.x, a.y); }
        public static Vector4 xxxy(this Vector3 a) { return new Vector4(a.x, a.x, a.x, a.y); }
        public static Vector4 yxxy(this Vector3 a) { return new Vector4(a.y, a.x, a.x, a.y); }
        public static Vector4 zxxy(this Vector3 a) { return new Vector4(a.z, a.x, a.x, a.y); }
        public static Vector4 _1yxy(this Vector3 a) { return new Vector4(1.0f, a.y, a.x, a.y); }
        public static Vector4 _0yxy(this Vector3 a) { return new Vector4(0.0f, a.y, a.x, a.y); }
        public static Vector4 xyxy(this Vector3 a) { return new Vector4(a.x, a.y, a.x, a.y); }
        public static Vector4 yyxy(this Vector3 a) { return new Vector4(a.y, a.y, a.x, a.y); }
        public static Vector4 zyxy(this Vector3 a) { return new Vector4(a.z, a.y, a.x, a.y); }
        public static Vector4 _1zxy(this Vector3 a) { return new Vector4(1.0f, a.z, a.x, a.y); }
        public static Vector4 _0zxy(this Vector3 a) { return new Vector4(0.0f, a.z, a.x, a.y); }
        public static Vector4 xzxy(this Vector3 a) { return new Vector4(a.x, a.z, a.x, a.y); }
        public static Vector4 yzxy(this Vector3 a) { return new Vector4(a.y, a.z, a.x, a.y); }
        public static Vector4 zzxy(this Vector3 a) { return new Vector4(a.z, a.z, a.x, a.y); }
        public static Vector4 _11yy(this Vector3 a) { return new Vector4(1.0f, 1.0f, a.y, a.y); }
        public static Vector4 _01yy(this Vector3 a) { return new Vector4(0.0f, 1.0f, a.y, a.y); }
        public static Vector4 x1yy(this Vector3 a) { return new Vector4(a.x, 1.0f, a.y, a.y); }
        public static Vector4 y1yy(this Vector3 a) { return new Vector4(a.y, 1.0f, a.y, a.y); }
        public static Vector4 z1yy(this Vector3 a) { return new Vector4(a.z, 1.0f, a.y, a.y); }
        public static Vector4 _10yy(this Vector3 a) { return new Vector4(1.0f, 0.0f, a.y, a.y); }
        public static Vector4 _00yy(this Vector3 a) { return new Vector4(0.0f, 0.0f, a.y, a.y); }
        public static Vector4 x0yy(this Vector3 a) { return new Vector4(a.x, 0.0f, a.y, a.y); }
        public static Vector4 y0yy(this Vector3 a) { return new Vector4(a.y, 0.0f, a.y, a.y); }
        public static Vector4 z0yy(this Vector3 a) { return new Vector4(a.z, 0.0f, a.y, a.y); }
        public static Vector4 _1xyy(this Vector3 a) { return new Vector4(1.0f, a.x, a.y, a.y); }
        public static Vector4 _0xyy(this Vector3 a) { return new Vector4(0.0f, a.x, a.y, a.y); }
        public static Vector4 xxyy(this Vector3 a) { return new Vector4(a.x, a.x, a.y, a.y); }
        public static Vector4 yxyy(this Vector3 a) { return new Vector4(a.y, a.x, a.y, a.y); }
        public static Vector4 zxyy(this Vector3 a) { return new Vector4(a.z, a.x, a.y, a.y); }
        public static Vector4 _1yyy(this Vector3 a) { return new Vector4(1.0f, a.y, a.y, a.y); }
        public static Vector4 _0yyy(this Vector3 a) { return new Vector4(0.0f, a.y, a.y, a.y); }
        public static Vector4 xyyy(this Vector3 a) { return new Vector4(a.x, a.y, a.y, a.y); }
        public static Vector4 yyyy(this Vector3 a) { return new Vector4(a.y, a.y, a.y, a.y); }
        public static Vector4 zyyy(this Vector3 a) { return new Vector4(a.z, a.y, a.y, a.y); }
        public static Vector4 _1zyy(this Vector3 a) { return new Vector4(1.0f, a.z, a.y, a.y); }
        public static Vector4 _0zyy(this Vector3 a) { return new Vector4(0.0f, a.z, a.y, a.y); }
        public static Vector4 xzyy(this Vector3 a) { return new Vector4(a.x, a.z, a.y, a.y); }
        public static Vector4 yzyy(this Vector3 a) { return new Vector4(a.y, a.z, a.y, a.y); }
        public static Vector4 zzyy(this Vector3 a) { return new Vector4(a.z, a.z, a.y, a.y); }
        public static Vector4 _11zy(this Vector3 a) { return new Vector4(1.0f, 1.0f, a.z, a.y); }
        public static Vector4 _01zy(this Vector3 a) { return new Vector4(0.0f, 1.0f, a.z, a.y); }
        public static Vector4 x1zy(this Vector3 a) { return new Vector4(a.x, 1.0f, a.z, a.y); }
        public static Vector4 y1zy(this Vector3 a) { return new Vector4(a.y, 1.0f, a.z, a.y); }
        public static Vector4 z1zy(this Vector3 a) { return new Vector4(a.z, 1.0f, a.z, a.y); }
        public static Vector4 _10zy(this Vector3 a) { return new Vector4(1.0f, 0.0f, a.z, a.y); }
        public static Vector4 _00zy(this Vector3 a) { return new Vector4(0.0f, 0.0f, a.z, a.y); }
        public static Vector4 x0zy(this Vector3 a) { return new Vector4(a.x, 0.0f, a.z, a.y); }
        public static Vector4 y0zy(this Vector3 a) { return new Vector4(a.y, 0.0f, a.z, a.y); }
        public static Vector4 z0zy(this Vector3 a) { return new Vector4(a.z, 0.0f, a.z, a.y); }
        public static Vector4 _1xzy(this Vector3 a) { return new Vector4(1.0f, a.x, a.z, a.y); }
        public static Vector4 _0xzy(this Vector3 a) { return new Vector4(0.0f, a.x, a.z, a.y); }
        public static Vector4 xxzy(this Vector3 a) { return new Vector4(a.x, a.x, a.z, a.y); }
        public static Vector4 yxzy(this Vector3 a) { return new Vector4(a.y, a.x, a.z, a.y); }
        public static Vector4 zxzy(this Vector3 a) { return new Vector4(a.z, a.x, a.z, a.y); }
        public static Vector4 _1yzy(this Vector3 a) { return new Vector4(1.0f, a.y, a.z, a.y); }
        public static Vector4 _0yzy(this Vector3 a) { return new Vector4(0.0f, a.y, a.z, a.y); }
        public static Vector4 xyzy(this Vector3 a) { return new Vector4(a.x, a.y, a.z, a.y); }
        public static Vector4 yyzy(this Vector3 a) { return new Vector4(a.y, a.y, a.z, a.y); }
        public static Vector4 zyzy(this Vector3 a) { return new Vector4(a.z, a.y, a.z, a.y); }
        public static Vector4 _1zzy(this Vector3 a) { return new Vector4(1.0f, a.z, a.z, a.y); }
        public static Vector4 _0zzy(this Vector3 a) { return new Vector4(0.0f, a.z, a.z, a.y); }
        public static Vector4 xzzy(this Vector3 a) { return new Vector4(a.x, a.z, a.z, a.y); }
        public static Vector4 yzzy(this Vector3 a) { return new Vector4(a.y, a.z, a.z, a.y); }
        public static Vector4 zzzy(this Vector3 a) { return new Vector4(a.z, a.z, a.z, a.y); }
        public static Vector4 _111z(this Vector3 a) { return new Vector4(1.0f, 1.0f, 1.0f, a.z); }
        public static Vector4 _011z(this Vector3 a) { return new Vector4(0.0f, 1.0f, 1.0f, a.z); }
        public static Vector4 x11z(this Vector3 a) { return new Vector4(a.x, 1.0f, 1.0f, a.z); }
        public static Vector4 y11z(this Vector3 a) { return new Vector4(a.y, 1.0f, 1.0f, a.z); }
        public static Vector4 z11z(this Vector3 a) { return new Vector4(a.z, 1.0f, 1.0f, a.z); }
        public static Vector4 _101z(this Vector3 a) { return new Vector4(1.0f, 0.0f, 1.0f, a.z); }
        public static Vector4 _001z(this Vector3 a) { return new Vector4(0.0f, 0.0f, 1.0f, a.z); }
        public static Vector4 x01z(this Vector3 a) { return new Vector4(a.x, 0.0f, 1.0f, a.z); }
        public static Vector4 y01z(this Vector3 a) { return new Vector4(a.y, 0.0f, 1.0f, a.z); }
        public static Vector4 z01z(this Vector3 a) { return new Vector4(a.z, 0.0f, 1.0f, a.z); }
        public static Vector4 _1x1z(this Vector3 a) { return new Vector4(1.0f, a.x, 1.0f, a.z); }
        public static Vector4 _0x1z(this Vector3 a) { return new Vector4(0.0f, a.x, 1.0f, a.z); }
        public static Vector4 xx1z(this Vector3 a) { return new Vector4(a.x, a.x, 1.0f, a.z); }
        public static Vector4 yx1z(this Vector3 a) { return new Vector4(a.y, a.x, 1.0f, a.z); }
        public static Vector4 zx1z(this Vector3 a) { return new Vector4(a.z, a.x, 1.0f, a.z); }
        public static Vector4 _1y1z(this Vector3 a) { return new Vector4(1.0f, a.y, 1.0f, a.z); }
        public static Vector4 _0y1z(this Vector3 a) { return new Vector4(0.0f, a.y, 1.0f, a.z); }
        public static Vector4 xy1z(this Vector3 a) { return new Vector4(a.x, a.y, 1.0f, a.z); }
        public static Vector4 yy1z(this Vector3 a) { return new Vector4(a.y, a.y, 1.0f, a.z); }
        public static Vector4 zy1z(this Vector3 a) { return new Vector4(a.z, a.y, 1.0f, a.z); }
        public static Vector4 _1z1z(this Vector3 a) { return new Vector4(1.0f, a.z, 1.0f, a.z); }
        public static Vector4 _0z1z(this Vector3 a) { return new Vector4(0.0f, a.z, 1.0f, a.z); }
        public static Vector4 xz1z(this Vector3 a) { return new Vector4(a.x, a.z, 1.0f, a.z); }
        public static Vector4 yz1z(this Vector3 a) { return new Vector4(a.y, a.z, 1.0f, a.z); }
        public static Vector4 zz1z(this Vector3 a) { return new Vector4(a.z, a.z, 1.0f, a.z); }
        public static Vector4 _110z(this Vector3 a) { return new Vector4(1.0f, 1.0f, 0.0f, a.z); }
        public static Vector4 _010z(this Vector3 a) { return new Vector4(0.0f, 1.0f, 0.0f, a.z); }
        public static Vector4 x10z(this Vector3 a) { return new Vector4(a.x, 1.0f, 0.0f, a.z); }
        public static Vector4 y10z(this Vector3 a) { return new Vector4(a.y, 1.0f, 0.0f, a.z); }
        public static Vector4 z10z(this Vector3 a) { return new Vector4(a.z, 1.0f, 0.0f, a.z); }
        public static Vector4 _100z(this Vector3 a) { return new Vector4(1.0f, 0.0f, 0.0f, a.z); }
        public static Vector4 _000z(this Vector3 a) { return new Vector4(0.0f, 0.0f, 0.0f, a.z); }
        public static Vector4 x00z(this Vector3 a) { return new Vector4(a.x, 0.0f, 0.0f, a.z); }
        public static Vector4 y00z(this Vector3 a) { return new Vector4(a.y, 0.0f, 0.0f, a.z); }
        public static Vector4 z00z(this Vector3 a) { return new Vector4(a.z, 0.0f, 0.0f, a.z); }
        public static Vector4 _1x0z(this Vector3 a) { return new Vector4(1.0f, a.x, 0.0f, a.z); }
        public static Vector4 _0x0z(this Vector3 a) { return new Vector4(0.0f, a.x, 0.0f, a.z); }
        public static Vector4 xx0z(this Vector3 a) { return new Vector4(a.x, a.x, 0.0f, a.z); }
        public static Vector4 yx0z(this Vector3 a) { return new Vector4(a.y, a.x, 0.0f, a.z); }
        public static Vector4 zx0z(this Vector3 a) { return new Vector4(a.z, a.x, 0.0f, a.z); }
        public static Vector4 _1y0z(this Vector3 a) { return new Vector4(1.0f, a.y, 0.0f, a.z); }
        public static Vector4 _0y0z(this Vector3 a) { return new Vector4(0.0f, a.y, 0.0f, a.z); }
        public static Vector4 xy0z(this Vector3 a) { return new Vector4(a.x, a.y, 0.0f, a.z); }
        public static Vector4 yy0z(this Vector3 a) { return new Vector4(a.y, a.y, 0.0f, a.z); }
        public static Vector4 zy0z(this Vector3 a) { return new Vector4(a.z, a.y, 0.0f, a.z); }
        public static Vector4 _1z0z(this Vector3 a) { return new Vector4(1.0f, a.z, 0.0f, a.z); }
        public static Vector4 _0z0z(this Vector3 a) { return new Vector4(0.0f, a.z, 0.0f, a.z); }
        public static Vector4 xz0z(this Vector3 a) { return new Vector4(a.x, a.z, 0.0f, a.z); }
        public static Vector4 yz0z(this Vector3 a) { return new Vector4(a.y, a.z, 0.0f, a.z); }
        public static Vector4 zz0z(this Vector3 a) { return new Vector4(a.z, a.z, 0.0f, a.z); }
        public static Vector4 _11xz(this Vector3 a) { return new Vector4(1.0f, 1.0f, a.x, a.z); }
        public static Vector4 _01xz(this Vector3 a) { return new Vector4(0.0f, 1.0f, a.x, a.z); }
        public static Vector4 x1xz(this Vector3 a) { return new Vector4(a.x, 1.0f, a.x, a.z); }
        public static Vector4 y1xz(this Vector3 a) { return new Vector4(a.y, 1.0f, a.x, a.z); }
        public static Vector4 z1xz(this Vector3 a) { return new Vector4(a.z, 1.0f, a.x, a.z); }
        public static Vector4 _10xz(this Vector3 a) { return new Vector4(1.0f, 0.0f, a.x, a.z); }
        public static Vector4 _00xz(this Vector3 a) { return new Vector4(0.0f, 0.0f, a.x, a.z); }
        public static Vector4 x0xz(this Vector3 a) { return new Vector4(a.x, 0.0f, a.x, a.z); }
        public static Vector4 y0xz(this Vector3 a) { return new Vector4(a.y, 0.0f, a.x, a.z); }
        public static Vector4 z0xz(this Vector3 a) { return new Vector4(a.z, 0.0f, a.x, a.z); }
        public static Vector4 _1xxz(this Vector3 a) { return new Vector4(1.0f, a.x, a.x, a.z); }
        public static Vector4 _0xxz(this Vector3 a) { return new Vector4(0.0f, a.x, a.x, a.z); }
        public static Vector4 xxxz(this Vector3 a) { return new Vector4(a.x, a.x, a.x, a.z); }
        public static Vector4 yxxz(this Vector3 a) { return new Vector4(a.y, a.x, a.x, a.z); }
        public static Vector4 zxxz(this Vector3 a) { return new Vector4(a.z, a.x, a.x, a.z); }
        public static Vector4 _1yxz(this Vector3 a) { return new Vector4(1.0f, a.y, a.x, a.z); }
        public static Vector4 _0yxz(this Vector3 a) { return new Vector4(0.0f, a.y, a.x, a.z); }
        public static Vector4 xyxz(this Vector3 a) { return new Vector4(a.x, a.y, a.x, a.z); }
        public static Vector4 yyxz(this Vector3 a) { return new Vector4(a.y, a.y, a.x, a.z); }
        public static Vector4 zyxz(this Vector3 a) { return new Vector4(a.z, a.y, a.x, a.z); }
        public static Vector4 _1zxz(this Vector3 a) { return new Vector4(1.0f, a.z, a.x, a.z); }
        public static Vector4 _0zxz(this Vector3 a) { return new Vector4(0.0f, a.z, a.x, a.z); }
        public static Vector4 xzxz(this Vector3 a) { return new Vector4(a.x, a.z, a.x, a.z); }
        public static Vector4 yzxz(this Vector3 a) { return new Vector4(a.y, a.z, a.x, a.z); }
        public static Vector4 zzxz(this Vector3 a) { return new Vector4(a.z, a.z, a.x, a.z); }
        public static Vector4 _11yz(this Vector3 a) { return new Vector4(1.0f, 1.0f, a.y, a.z); }
        public static Vector4 _01yz(this Vector3 a) { return new Vector4(0.0f, 1.0f, a.y, a.z); }
        public static Vector4 x1yz(this Vector3 a) { return new Vector4(a.x, 1.0f, a.y, a.z); }
        public static Vector4 y1yz(this Vector3 a) { return new Vector4(a.y, 1.0f, a.y, a.z); }
        public static Vector4 z1yz(this Vector3 a) { return new Vector4(a.z, 1.0f, a.y, a.z); }
        public static Vector4 _10yz(this Vector3 a) { return new Vector4(1.0f, 0.0f, a.y, a.z); }
        public static Vector4 _00yz(this Vector3 a) { return new Vector4(0.0f, 0.0f, a.y, a.z); }
        public static Vector4 x0yz(this Vector3 a) { return new Vector4(a.x, 0.0f, a.y, a.z); }
        public static Vector4 y0yz(this Vector3 a) { return new Vector4(a.y, 0.0f, a.y, a.z); }
        public static Vector4 z0yz(this Vector3 a) { return new Vector4(a.z, 0.0f, a.y, a.z); }
        public static Vector4 _1xyz(this Vector3 a) { return new Vector4(1.0f, a.x, a.y, a.z); }
        public static Vector4 _0xyz(this Vector3 a) { return new Vector4(0.0f, a.x, a.y, a.z); }
        public static Vector4 xxyz(this Vector3 a) { return new Vector4(a.x, a.x, a.y, a.z); }
        public static Vector4 yxyz(this Vector3 a) { return new Vector4(a.y, a.x, a.y, a.z); }
        public static Vector4 zxyz(this Vector3 a) { return new Vector4(a.z, a.x, a.y, a.z); }
        public static Vector4 _1yyz(this Vector3 a) { return new Vector4(1.0f, a.y, a.y, a.z); }
        public static Vector4 _0yyz(this Vector3 a) { return new Vector4(0.0f, a.y, a.y, a.z); }
        public static Vector4 xyyz(this Vector3 a) { return new Vector4(a.x, a.y, a.y, a.z); }
        public static Vector4 yyyz(this Vector3 a) { return new Vector4(a.y, a.y, a.y, a.z); }
        public static Vector4 zyyz(this Vector3 a) { return new Vector4(a.z, a.y, a.y, a.z); }
        public static Vector4 _1zyz(this Vector3 a) { return new Vector4(1.0f, a.z, a.y, a.z); }
        public static Vector4 _0zyz(this Vector3 a) { return new Vector4(0.0f, a.z, a.y, a.z); }
        public static Vector4 xzyz(this Vector3 a) { return new Vector4(a.x, a.z, a.y, a.z); }
        public static Vector4 yzyz(this Vector3 a) { return new Vector4(a.y, a.z, a.y, a.z); }
        public static Vector4 zzyz(this Vector3 a) { return new Vector4(a.z, a.z, a.y, a.z); }
        public static Vector4 _11zz(this Vector3 a) { return new Vector4(1.0f, 1.0f, a.z, a.z); }
        public static Vector4 _01zz(this Vector3 a) { return new Vector4(0.0f, 1.0f, a.z, a.z); }
        public static Vector4 x1zz(this Vector3 a) { return new Vector4(a.x, 1.0f, a.z, a.z); }
        public static Vector4 y1zz(this Vector3 a) { return new Vector4(a.y, 1.0f, a.z, a.z); }
        public static Vector4 z1zz(this Vector3 a) { return new Vector4(a.z, 1.0f, a.z, a.z); }
        public static Vector4 _10zz(this Vector3 a) { return new Vector4(1.0f, 0.0f, a.z, a.z); }
        public static Vector4 _00zz(this Vector3 a) { return new Vector4(0.0f, 0.0f, a.z, a.z); }
        public static Vector4 x0zz(this Vector3 a) { return new Vector4(a.x, 0.0f, a.z, a.z); }
        public static Vector4 y0zz(this Vector3 a) { return new Vector4(a.y, 0.0f, a.z, a.z); }
        public static Vector4 z0zz(this Vector3 a) { return new Vector4(a.z, 0.0f, a.z, a.z); }
        public static Vector4 _1xzz(this Vector3 a) { return new Vector4(1.0f, a.x, a.z, a.z); }
        public static Vector4 _0xzz(this Vector3 a) { return new Vector4(0.0f, a.x, a.z, a.z); }
        public static Vector4 xxzz(this Vector3 a) { return new Vector4(a.x, a.x, a.z, a.z); }
        public static Vector4 yxzz(this Vector3 a) { return new Vector4(a.y, a.x, a.z, a.z); }
        public static Vector4 zxzz(this Vector3 a) { return new Vector4(a.z, a.x, a.z, a.z); }
        public static Vector4 _1yzz(this Vector3 a) { return new Vector4(1.0f, a.y, a.z, a.z); }
        public static Vector4 _0yzz(this Vector3 a) { return new Vector4(0.0f, a.y, a.z, a.z); }
        public static Vector4 xyzz(this Vector3 a) { return new Vector4(a.x, a.y, a.z, a.z); }
        public static Vector4 yyzz(this Vector3 a) { return new Vector4(a.y, a.y, a.z, a.z); }
        public static Vector4 zyzz(this Vector3 a) { return new Vector4(a.z, a.y, a.z, a.z); }
        public static Vector4 _1zzz(this Vector3 a) { return new Vector4(1.0f, a.z, a.z, a.z); }
        public static Vector4 _0zzz(this Vector3 a) { return new Vector4(0.0f, a.z, a.z, a.z); }
        public static Vector4 xzzz(this Vector3 a) { return new Vector4(a.x, a.z, a.z, a.z); }
        public static Vector4 yzzz(this Vector3 a) { return new Vector4(a.y, a.z, a.z, a.z); }
        public static Vector4 zzzz(this Vector3 a) { return new Vector4(a.z, a.z, a.z, a.z); }
    }
}