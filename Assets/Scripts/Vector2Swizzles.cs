using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace PaladinCharacter.Utility
{
    [SuppressMessage("ReSharper", "UnusedParameter.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static class Vector2Swizzles
    {
        //swizzles of size 2
        public static Vector2 _11(this Vector2 a) { return new Vector2(1.0f, 1.0f); }
        public static Vector2 _01(this Vector2 a) { return new Vector2(0.0f, 1.0f); }
        public static Vector2 x1(this Vector2 a) { return new Vector2(a.x, 1.0f); }
        public static Vector2 y1(this Vector2 a) { return new Vector2(a.y, 1.0f); }
        public static Vector2 _10(this Vector2 a) { return new Vector2(1.0f, 0.0f); }
        public static Vector2 _00(this Vector2 a) { return new Vector2(0.0f, 0.0f); }
        public static Vector2 x0(this Vector2 a) { return new Vector2(a.x, 0.0f); }
        public static Vector2 y0(this Vector2 a) { return new Vector2(a.y, 0.0f); }
        public static Vector2 _1x(this Vector2 a) { return new Vector2(1.0f, a.x); }
        public static Vector2 _0x(this Vector2 a) { return new Vector2(0.0f, a.x); }
        public static Vector2 xx(this Vector2 a) { return new Vector2(a.x, a.x); }
        public static Vector2 yx(this Vector2 a) { return new Vector2(a.y, a.x); }
        public static Vector2 _1y(this Vector2 a) { return new Vector2(1.0f, a.y); }
        public static Vector2 _0y(this Vector2 a) { return new Vector2(0.0f, a.y); }
        public static Vector2 xy(this Vector2 a) { return new Vector2(a.x, a.y); }
        public static Vector2 yy(this Vector2 a) { return new Vector2(a.y, a.y); }
        //swizzles of size 3
        public static Vector3 _111(this Vector2 a) { return new Vector3(1.0f, 1.0f, 1.0f); }
        public static Vector3 _011(this Vector2 a) { return new Vector3(0.0f, 1.0f, 1.0f); }
        public static Vector3 x11(this Vector2 a) { return new Vector3(a.x, 1.0f, 1.0f); }
        public static Vector3 y11(this Vector2 a) { return new Vector3(a.y, 1.0f, 1.0f); }
        public static Vector3 _101(this Vector2 a) { return new Vector3(1.0f, 0.0f, 1.0f); }
        public static Vector3 _001(this Vector2 a) { return new Vector3(0.0f, 0.0f, 1.0f); }
        public static Vector3 x01(this Vector2 a) { return new Vector3(a.x, 0.0f, 1.0f); }
        public static Vector3 y01(this Vector2 a) { return new Vector3(a.y, 0.0f, 1.0f); }
        public static Vector3 _1x1(this Vector2 a) { return new Vector3(1.0f, a.x, 1.0f); }
        public static Vector3 _0x1(this Vector2 a) { return new Vector3(0.0f, a.x, 1.0f); }
        public static Vector3 xx1(this Vector2 a) { return new Vector3(a.x, a.x, 1.0f); }
        public static Vector3 yx1(this Vector2 a) { return new Vector3(a.y, a.x, 1.0f); }
        public static Vector3 _1y1(this Vector2 a) { return new Vector3(1.0f, a.y, 1.0f); }
        public static Vector3 _0y1(this Vector2 a) { return new Vector3(0.0f, a.y, 1.0f); }
        public static Vector3 xy1(this Vector2 a) { return new Vector3(a.x, a.y, 1.0f); }
        public static Vector3 yy1(this Vector2 a) { return new Vector3(a.y, a.y, 1.0f); }
        public static Vector3 _110(this Vector2 a) { return new Vector3(1.0f, 1.0f, 0.0f); }
        public static Vector3 _010(this Vector2 a) { return new Vector3(0.0f, 1.0f, 0.0f); }
        public static Vector3 x10(this Vector2 a) { return new Vector3(a.x, 1.0f, 0.0f); }
        public static Vector3 y10(this Vector2 a) { return new Vector3(a.y, 1.0f, 0.0f); }
        public static Vector3 _100(this Vector2 a) { return new Vector3(1.0f, 0.0f, 0.0f); }
        public static Vector3 _000(this Vector2 a) { return new Vector3(0.0f, 0.0f, 0.0f); }
        public static Vector3 x00(this Vector2 a) { return new Vector3(a.x, 0.0f, 0.0f); }
        public static Vector3 y00(this Vector2 a) { return new Vector3(a.y, 0.0f, 0.0f); }
        public static Vector3 _1x0(this Vector2 a) { return new Vector3(1.0f, a.x, 0.0f); }
        public static Vector3 _0x0(this Vector2 a) { return new Vector3(0.0f, a.x, 0.0f); }
        public static Vector3 xx0(this Vector2 a) { return new Vector3(a.x, a.x, 0.0f); }
        public static Vector3 yx0(this Vector2 a) { return new Vector3(a.y, a.x, 0.0f); }
        public static Vector3 _1y0(this Vector2 a) { return new Vector3(1.0f, a.y, 0.0f); }
        public static Vector3 _0y0(this Vector2 a) { return new Vector3(0.0f, a.y, 0.0f); }
        public static Vector3 xy0(this Vector2 a) { return new Vector3(a.x, a.y, 0.0f); }
        public static Vector3 yy0(this Vector2 a) { return new Vector3(a.y, a.y, 0.0f); }
        public static Vector3 _11x(this Vector2 a) { return new Vector3(1.0f, 1.0f, a.x); }
        public static Vector3 _01x(this Vector2 a) { return new Vector3(0.0f, 1.0f, a.x); }
        public static Vector3 x1x(this Vector2 a) { return new Vector3(a.x, 1.0f, a.x); }
        public static Vector3 y1x(this Vector2 a) { return new Vector3(a.y, 1.0f, a.x); }
        public static Vector3 _10x(this Vector2 a) { return new Vector3(1.0f, 0.0f, a.x); }
        public static Vector3 _00x(this Vector2 a) { return new Vector3(0.0f, 0.0f, a.x); }
        public static Vector3 x0x(this Vector2 a) { return new Vector3(a.x, 0.0f, a.x); }
        public static Vector3 y0x(this Vector2 a) { return new Vector3(a.y, 0.0f, a.x); }
        public static Vector3 _1xx(this Vector2 a) { return new Vector3(1.0f, a.x, a.x); }
        public static Vector3 _0xx(this Vector2 a) { return new Vector3(0.0f, a.x, a.x); }
        public static Vector3 xxx(this Vector2 a) { return new Vector3(a.x, a.x, a.x); }
        public static Vector3 yxx(this Vector2 a) { return new Vector3(a.y, a.x, a.x); }
        public static Vector3 _1yx(this Vector2 a) { return new Vector3(1.0f, a.y, a.x); }
        public static Vector3 _0yx(this Vector2 a) { return new Vector3(0.0f, a.y, a.x); }
        public static Vector3 xyx(this Vector2 a) { return new Vector3(a.x, a.y, a.x); }
        public static Vector3 yyx(this Vector2 a) { return new Vector3(a.y, a.y, a.x); }
        public static Vector3 _11y(this Vector2 a) { return new Vector3(1.0f, 1.0f, a.y); }
        public static Vector3 _01y(this Vector2 a) { return new Vector3(0.0f, 1.0f, a.y); }
        public static Vector3 x1y(this Vector2 a) { return new Vector3(a.x, 1.0f, a.y); }
        public static Vector3 y1y(this Vector2 a) { return new Vector3(a.y, 1.0f, a.y); }
        public static Vector3 _10y(this Vector2 a) { return new Vector3(1.0f, 0.0f, a.y); }
        public static Vector3 _00y(this Vector2 a) { return new Vector3(0.0f, 0.0f, a.y); }
        public static Vector3 x0y(this Vector2 a) { return new Vector3(a.x, 0.0f, a.y); }
        public static Vector3 y0y(this Vector2 a) { return new Vector3(a.y, 0.0f, a.y); }
        public static Vector3 _1xy(this Vector2 a) { return new Vector3(1.0f, a.x, a.y); }
        public static Vector3 _0xy(this Vector2 a) { return new Vector3(0.0f, a.x, a.y); }
        public static Vector3 xxy(this Vector2 a) { return new Vector3(a.x, a.x, a.y); }
        public static Vector3 yxy(this Vector2 a) { return new Vector3(a.y, a.x, a.y); }
        public static Vector3 _1yy(this Vector2 a) { return new Vector3(1.0f, a.y, a.y); }
        public static Vector3 _0yy(this Vector2 a) { return new Vector3(0.0f, a.y, a.y); }
        public static Vector3 xyy(this Vector2 a) { return new Vector3(a.x, a.y, a.y); }
        public static Vector3 yyy(this Vector2 a) { return new Vector3(a.y, a.y, a.y); }
        //swizzles of size 4
        public static Vector4 _1111(this Vector2 a) { return new Vector4(1.0f, 1.0f, 1.0f, 1.0f); }
        public static Vector4 _0111(this Vector2 a) { return new Vector4(0.0f, 1.0f, 1.0f, 1.0f); }
        public static Vector4 x111(this Vector2 a) { return new Vector4(a.x, 1.0f, 1.0f, 1.0f); }
        public static Vector4 y111(this Vector2 a) { return new Vector4(a.y, 1.0f, 1.0f, 1.0f); }
        public static Vector4 _1011(this Vector2 a) { return new Vector4(1.0f, 0.0f, 1.0f, 1.0f); }
        public static Vector4 _0011(this Vector2 a) { return new Vector4(0.0f, 0.0f, 1.0f, 1.0f); }
        public static Vector4 x011(this Vector2 a) { return new Vector4(a.x, 0.0f, 1.0f, 1.0f); }
        public static Vector4 y011(this Vector2 a) { return new Vector4(a.y, 0.0f, 1.0f, 1.0f); }
        public static Vector4 _1x11(this Vector2 a) { return new Vector4(1.0f, a.x, 1.0f, 1.0f); }
        public static Vector4 _0x11(this Vector2 a) { return new Vector4(0.0f, a.x, 1.0f, 1.0f); }
        public static Vector4 xx11(this Vector2 a) { return new Vector4(a.x, a.x, 1.0f, 1.0f); }
        public static Vector4 yx11(this Vector2 a) { return new Vector4(a.y, a.x, 1.0f, 1.0f); }
        public static Vector4 _1y11(this Vector2 a) { return new Vector4(1.0f, a.y, 1.0f, 1.0f); }
        public static Vector4 _0y11(this Vector2 a) { return new Vector4(0.0f, a.y, 1.0f, 1.0f); }
        public static Vector4 xy11(this Vector2 a) { return new Vector4(a.x, a.y, 1.0f, 1.0f); }
        public static Vector4 yy11(this Vector2 a) { return new Vector4(a.y, a.y, 1.0f, 1.0f); }
        public static Vector4 _1101(this Vector2 a) { return new Vector4(1.0f, 1.0f, 0.0f, 1.0f); }
        public static Vector4 _0101(this Vector2 a) { return new Vector4(0.0f, 1.0f, 0.0f, 1.0f); }
        public static Vector4 x101(this Vector2 a) { return new Vector4(a.x, 1.0f, 0.0f, 1.0f); }
        public static Vector4 y101(this Vector2 a) { return new Vector4(a.y, 1.0f, 0.0f, 1.0f); }
        public static Vector4 _1001(this Vector2 a) { return new Vector4(1.0f, 0.0f, 0.0f, 1.0f); }
        public static Vector4 _0001(this Vector2 a) { return new Vector4(0.0f, 0.0f, 0.0f, 1.0f); }
        public static Vector4 x001(this Vector2 a) { return new Vector4(a.x, 0.0f, 0.0f, 1.0f); }
        public static Vector4 y001(this Vector2 a) { return new Vector4(a.y, 0.0f, 0.0f, 1.0f); }
        public static Vector4 _1x01(this Vector2 a) { return new Vector4(1.0f, a.x, 0.0f, 1.0f); }
        public static Vector4 _0x01(this Vector2 a) { return new Vector4(0.0f, a.x, 0.0f, 1.0f); }
        public static Vector4 xx01(this Vector2 a) { return new Vector4(a.x, a.x, 0.0f, 1.0f); }
        public static Vector4 yx01(this Vector2 a) { return new Vector4(a.y, a.x, 0.0f, 1.0f); }
        public static Vector4 _1y01(this Vector2 a) { return new Vector4(1.0f, a.y, 0.0f, 1.0f); }
        public static Vector4 _0y01(this Vector2 a) { return new Vector4(0.0f, a.y, 0.0f, 1.0f); }
        public static Vector4 xy01(this Vector2 a) { return new Vector4(a.x, a.y, 0.0f, 1.0f); }
        public static Vector4 yy01(this Vector2 a) { return new Vector4(a.y, a.y, 0.0f, 1.0f); }
        public static Vector4 _11x1(this Vector2 a) { return new Vector4(1.0f, 1.0f, a.x, 1.0f); }
        public static Vector4 _01x1(this Vector2 a) { return new Vector4(0.0f, 1.0f, a.x, 1.0f); }
        public static Vector4 x1x1(this Vector2 a) { return new Vector4(a.x, 1.0f, a.x, 1.0f); }
        public static Vector4 y1x1(this Vector2 a) { return new Vector4(a.y, 1.0f, a.x, 1.0f); }
        public static Vector4 _10x1(this Vector2 a) { return new Vector4(1.0f, 0.0f, a.x, 1.0f); }
        public static Vector4 _00x1(this Vector2 a) { return new Vector4(0.0f, 0.0f, a.x, 1.0f); }
        public static Vector4 x0x1(this Vector2 a) { return new Vector4(a.x, 0.0f, a.x, 1.0f); }
        public static Vector4 y0x1(this Vector2 a) { return new Vector4(a.y, 0.0f, a.x, 1.0f); }
        public static Vector4 _1xx1(this Vector2 a) { return new Vector4(1.0f, a.x, a.x, 1.0f); }
        public static Vector4 _0xx1(this Vector2 a) { return new Vector4(0.0f, a.x, a.x, 1.0f); }
        public static Vector4 xxx1(this Vector2 a) { return new Vector4(a.x, a.x, a.x, 1.0f); }
        public static Vector4 yxx1(this Vector2 a) { return new Vector4(a.y, a.x, a.x, 1.0f); }
        public static Vector4 _1yx1(this Vector2 a) { return new Vector4(1.0f, a.y, a.x, 1.0f); }
        public static Vector4 _0yx1(this Vector2 a) { return new Vector4(0.0f, a.y, a.x, 1.0f); }
        public static Vector4 xyx1(this Vector2 a) { return new Vector4(a.x, a.y, a.x, 1.0f); }
        public static Vector4 yyx1(this Vector2 a) { return new Vector4(a.y, a.y, a.x, 1.0f); }
        public static Vector4 _11y1(this Vector2 a) { return new Vector4(1.0f, 1.0f, a.y, 1.0f); }
        public static Vector4 _01y1(this Vector2 a) { return new Vector4(0.0f, 1.0f, a.y, 1.0f); }
        public static Vector4 x1y1(this Vector2 a) { return new Vector4(a.x, 1.0f, a.y, 1.0f); }
        public static Vector4 y1y1(this Vector2 a) { return new Vector4(a.y, 1.0f, a.y, 1.0f); }
        public static Vector4 _10y1(this Vector2 a) { return new Vector4(1.0f, 0.0f, a.y, 1.0f); }
        public static Vector4 _00y1(this Vector2 a) { return new Vector4(0.0f, 0.0f, a.y, 1.0f); }
        public static Vector4 x0y1(this Vector2 a) { return new Vector4(a.x, 0.0f, a.y, 1.0f); }
        public static Vector4 y0y1(this Vector2 a) { return new Vector4(a.y, 0.0f, a.y, 1.0f); }
        public static Vector4 _1xy1(this Vector2 a) { return new Vector4(1.0f, a.x, a.y, 1.0f); }
        public static Vector4 _0xy1(this Vector2 a) { return new Vector4(0.0f, a.x, a.y, 1.0f); }
        public static Vector4 xxy1(this Vector2 a) { return new Vector4(a.x, a.x, a.y, 1.0f); }
        public static Vector4 yxy1(this Vector2 a) { return new Vector4(a.y, a.x, a.y, 1.0f); }
        public static Vector4 _1yy1(this Vector2 a) { return new Vector4(1.0f, a.y, a.y, 1.0f); }
        public static Vector4 _0yy1(this Vector2 a) { return new Vector4(0.0f, a.y, a.y, 1.0f); }
        public static Vector4 xyy1(this Vector2 a) { return new Vector4(a.x, a.y, a.y, 1.0f); }
        public static Vector4 yyy1(this Vector2 a) { return new Vector4(a.y, a.y, a.y, 1.0f); }
        public static Vector4 _1110(this Vector2 a) { return new Vector4(1.0f, 1.0f, 1.0f, 0.0f); }
        public static Vector4 _0110(this Vector2 a) { return new Vector4(0.0f, 1.0f, 1.0f, 0.0f); }
        public static Vector4 x110(this Vector2 a) { return new Vector4(a.x, 1.0f, 1.0f, 0.0f); }
        public static Vector4 y110(this Vector2 a) { return new Vector4(a.y, 1.0f, 1.0f, 0.0f); }
        public static Vector4 _1010(this Vector2 a) { return new Vector4(1.0f, 0.0f, 1.0f, 0.0f); }
        public static Vector4 _0010(this Vector2 a) { return new Vector4(0.0f, 0.0f, 1.0f, 0.0f); }
        public static Vector4 x010(this Vector2 a) { return new Vector4(a.x, 0.0f, 1.0f, 0.0f); }
        public static Vector4 y010(this Vector2 a) { return new Vector4(a.y, 0.0f, 1.0f, 0.0f); }
        public static Vector4 _1x10(this Vector2 a) { return new Vector4(1.0f, a.x, 1.0f, 0.0f); }
        public static Vector4 _0x10(this Vector2 a) { return new Vector4(0.0f, a.x, 1.0f, 0.0f); }
        public static Vector4 xx10(this Vector2 a) { return new Vector4(a.x, a.x, 1.0f, 0.0f); }
        public static Vector4 yx10(this Vector2 a) { return new Vector4(a.y, a.x, 1.0f, 0.0f); }
        public static Vector4 _1y10(this Vector2 a) { return new Vector4(1.0f, a.y, 1.0f, 0.0f); }
        public static Vector4 _0y10(this Vector2 a) { return new Vector4(0.0f, a.y, 1.0f, 0.0f); }
        public static Vector4 xy10(this Vector2 a) { return new Vector4(a.x, a.y, 1.0f, 0.0f); }
        public static Vector4 yy10(this Vector2 a) { return new Vector4(a.y, a.y, 1.0f, 0.0f); }
        public static Vector4 _1100(this Vector2 a) { return new Vector4(1.0f, 1.0f, 0.0f, 0.0f); }
        public static Vector4 _0100(this Vector2 a) { return new Vector4(0.0f, 1.0f, 0.0f, 0.0f); }
        public static Vector4 x100(this Vector2 a) { return new Vector4(a.x, 1.0f, 0.0f, 0.0f); }
        public static Vector4 y100(this Vector2 a) { return new Vector4(a.y, 1.0f, 0.0f, 0.0f); }
        public static Vector4 _1000(this Vector2 a) { return new Vector4(1.0f, 0.0f, 0.0f, 0.0f); }
        public static Vector4 _0000(this Vector2 a) { return new Vector4(0.0f, 0.0f, 0.0f, 0.0f); }
        public static Vector4 x000(this Vector2 a) { return new Vector4(a.x, 0.0f, 0.0f, 0.0f); }
        public static Vector4 y000(this Vector2 a) { return new Vector4(a.y, 0.0f, 0.0f, 0.0f); }
        public static Vector4 _1x00(this Vector2 a) { return new Vector4(1.0f, a.x, 0.0f, 0.0f); }
        public static Vector4 _0x00(this Vector2 a) { return new Vector4(0.0f, a.x, 0.0f, 0.0f); }
        public static Vector4 xx00(this Vector2 a) { return new Vector4(a.x, a.x, 0.0f, 0.0f); }
        public static Vector4 yx00(this Vector2 a) { return new Vector4(a.y, a.x, 0.0f, 0.0f); }
        public static Vector4 _1y00(this Vector2 a) { return new Vector4(1.0f, a.y, 0.0f, 0.0f); }
        public static Vector4 _0y00(this Vector2 a) { return new Vector4(0.0f, a.y, 0.0f, 0.0f); }
        public static Vector4 xy00(this Vector2 a) { return new Vector4(a.x, a.y, 0.0f, 0.0f); }
        public static Vector4 yy00(this Vector2 a) { return new Vector4(a.y, a.y, 0.0f, 0.0f); }
        public static Vector4 _11x0(this Vector2 a) { return new Vector4(1.0f, 1.0f, a.x, 0.0f); }
        public static Vector4 _01x0(this Vector2 a) { return new Vector4(0.0f, 1.0f, a.x, 0.0f); }
        public static Vector4 x1x0(this Vector2 a) { return new Vector4(a.x, 1.0f, a.x, 0.0f); }
        public static Vector4 y1x0(this Vector2 a) { return new Vector4(a.y, 1.0f, a.x, 0.0f); }
        public static Vector4 _10x0(this Vector2 a) { return new Vector4(1.0f, 0.0f, a.x, 0.0f); }
        public static Vector4 _00x0(this Vector2 a) { return new Vector4(0.0f, 0.0f, a.x, 0.0f); }
        public static Vector4 x0x0(this Vector2 a) { return new Vector4(a.x, 0.0f, a.x, 0.0f); }
        public static Vector4 y0x0(this Vector2 a) { return new Vector4(a.y, 0.0f, a.x, 0.0f); }
        public static Vector4 _1xx0(this Vector2 a) { return new Vector4(1.0f, a.x, a.x, 0.0f); }
        public static Vector4 _0xx0(this Vector2 a) { return new Vector4(0.0f, a.x, a.x, 0.0f); }
        public static Vector4 xxx0(this Vector2 a) { return new Vector4(a.x, a.x, a.x, 0.0f); }
        public static Vector4 yxx0(this Vector2 a) { return new Vector4(a.y, a.x, a.x, 0.0f); }
        public static Vector4 _1yx0(this Vector2 a) { return new Vector4(1.0f, a.y, a.x, 0.0f); }
        public static Vector4 _0yx0(this Vector2 a) { return new Vector4(0.0f, a.y, a.x, 0.0f); }
        public static Vector4 xyx0(this Vector2 a) { return new Vector4(a.x, a.y, a.x, 0.0f); }
        public static Vector4 yyx0(this Vector2 a) { return new Vector4(a.y, a.y, a.x, 0.0f); }
        public static Vector4 _11y0(this Vector2 a) { return new Vector4(1.0f, 1.0f, a.y, 0.0f); }
        public static Vector4 _01y0(this Vector2 a) { return new Vector4(0.0f, 1.0f, a.y, 0.0f); }
        public static Vector4 x1y0(this Vector2 a) { return new Vector4(a.x, 1.0f, a.y, 0.0f); }
        public static Vector4 y1y0(this Vector2 a) { return new Vector4(a.y, 1.0f, a.y, 0.0f); }
        public static Vector4 _10y0(this Vector2 a) { return new Vector4(1.0f, 0.0f, a.y, 0.0f); }
        public static Vector4 _00y0(this Vector2 a) { return new Vector4(0.0f, 0.0f, a.y, 0.0f); }
        public static Vector4 x0y0(this Vector2 a) { return new Vector4(a.x, 0.0f, a.y, 0.0f); }
        public static Vector4 y0y0(this Vector2 a) { return new Vector4(a.y, 0.0f, a.y, 0.0f); }
        public static Vector4 _1xy0(this Vector2 a) { return new Vector4(1.0f, a.x, a.y, 0.0f); }
        public static Vector4 _0xy0(this Vector2 a) { return new Vector4(0.0f, a.x, a.y, 0.0f); }
        public static Vector4 xxy0(this Vector2 a) { return new Vector4(a.x, a.x, a.y, 0.0f); }
        public static Vector4 yxy0(this Vector2 a) { return new Vector4(a.y, a.x, a.y, 0.0f); }
        public static Vector4 _1yy0(this Vector2 a) { return new Vector4(1.0f, a.y, a.y, 0.0f); }
        public static Vector4 _0yy0(this Vector2 a) { return new Vector4(0.0f, a.y, a.y, 0.0f); }
        public static Vector4 xyy0(this Vector2 a) { return new Vector4(a.x, a.y, a.y, 0.0f); }
        public static Vector4 yyy0(this Vector2 a) { return new Vector4(a.y, a.y, a.y, 0.0f); }
        public static Vector4 _111x(this Vector2 a) { return new Vector4(1.0f, 1.0f, 1.0f, a.x); }
        public static Vector4 _011x(this Vector2 a) { return new Vector4(0.0f, 1.0f, 1.0f, a.x); }
        public static Vector4 x11x(this Vector2 a) { return new Vector4(a.x, 1.0f, 1.0f, a.x); }
        public static Vector4 y11x(this Vector2 a) { return new Vector4(a.y, 1.0f, 1.0f, a.x); }
        public static Vector4 _101x(this Vector2 a) { return new Vector4(1.0f, 0.0f, 1.0f, a.x); }
        public static Vector4 _001x(this Vector2 a) { return new Vector4(0.0f, 0.0f, 1.0f, a.x); }
        public static Vector4 x01x(this Vector2 a) { return new Vector4(a.x, 0.0f, 1.0f, a.x); }
        public static Vector4 y01x(this Vector2 a) { return new Vector4(a.y, 0.0f, 1.0f, a.x); }
        public static Vector4 _1x1x(this Vector2 a) { return new Vector4(1.0f, a.x, 1.0f, a.x); }
        public static Vector4 _0x1x(this Vector2 a) { return new Vector4(0.0f, a.x, 1.0f, a.x); }
        public static Vector4 xx1x(this Vector2 a) { return new Vector4(a.x, a.x, 1.0f, a.x); }
        public static Vector4 yx1x(this Vector2 a) { return new Vector4(a.y, a.x, 1.0f, a.x); }
        public static Vector4 _1y1x(this Vector2 a) { return new Vector4(1.0f, a.y, 1.0f, a.x); }
        public static Vector4 _0y1x(this Vector2 a) { return new Vector4(0.0f, a.y, 1.0f, a.x); }
        public static Vector4 xy1x(this Vector2 a) { return new Vector4(a.x, a.y, 1.0f, a.x); }
        public static Vector4 yy1x(this Vector2 a) { return new Vector4(a.y, a.y, 1.0f, a.x); }
        public static Vector4 _110x(this Vector2 a) { return new Vector4(1.0f, 1.0f, 0.0f, a.x); }
        public static Vector4 _010x(this Vector2 a) { return new Vector4(0.0f, 1.0f, 0.0f, a.x); }
        public static Vector4 x10x(this Vector2 a) { return new Vector4(a.x, 1.0f, 0.0f, a.x); }
        public static Vector4 y10x(this Vector2 a) { return new Vector4(a.y, 1.0f, 0.0f, a.x); }
        public static Vector4 _100x(this Vector2 a) { return new Vector4(1.0f, 0.0f, 0.0f, a.x); }
        public static Vector4 _000x(this Vector2 a) { return new Vector4(0.0f, 0.0f, 0.0f, a.x); }
        public static Vector4 x00x(this Vector2 a) { return new Vector4(a.x, 0.0f, 0.0f, a.x); }
        public static Vector4 y00x(this Vector2 a) { return new Vector4(a.y, 0.0f, 0.0f, a.x); }
        public static Vector4 _1x0x(this Vector2 a) { return new Vector4(1.0f, a.x, 0.0f, a.x); }
        public static Vector4 _0x0x(this Vector2 a) { return new Vector4(0.0f, a.x, 0.0f, a.x); }
        public static Vector4 xx0x(this Vector2 a) { return new Vector4(a.x, a.x, 0.0f, a.x); }
        public static Vector4 yx0x(this Vector2 a) { return new Vector4(a.y, a.x, 0.0f, a.x); }
        public static Vector4 _1y0x(this Vector2 a) { return new Vector4(1.0f, a.y, 0.0f, a.x); }
        public static Vector4 _0y0x(this Vector2 a) { return new Vector4(0.0f, a.y, 0.0f, a.x); }
        public static Vector4 xy0x(this Vector2 a) { return new Vector4(a.x, a.y, 0.0f, a.x); }
        public static Vector4 yy0x(this Vector2 a) { return new Vector4(a.y, a.y, 0.0f, a.x); }
        public static Vector4 _11xx(this Vector2 a) { return new Vector4(1.0f, 1.0f, a.x, a.x); }
        public static Vector4 _01xx(this Vector2 a) { return new Vector4(0.0f, 1.0f, a.x, a.x); }
        public static Vector4 x1xx(this Vector2 a) { return new Vector4(a.x, 1.0f, a.x, a.x); }
        public static Vector4 y1xx(this Vector2 a) { return new Vector4(a.y, 1.0f, a.x, a.x); }
        public static Vector4 _10xx(this Vector2 a) { return new Vector4(1.0f, 0.0f, a.x, a.x); }
        public static Vector4 _00xx(this Vector2 a) { return new Vector4(0.0f, 0.0f, a.x, a.x); }
        public static Vector4 x0xx(this Vector2 a) { return new Vector4(a.x, 0.0f, a.x, a.x); }
        public static Vector4 y0xx(this Vector2 a) { return new Vector4(a.y, 0.0f, a.x, a.x); }
        public static Vector4 _1xxx(this Vector2 a) { return new Vector4(1.0f, a.x, a.x, a.x); }
        public static Vector4 _0xxx(this Vector2 a) { return new Vector4(0.0f, a.x, a.x, a.x); }
        public static Vector4 xxxx(this Vector2 a) { return new Vector4(a.x, a.x, a.x, a.x); }
        public static Vector4 yxxx(this Vector2 a) { return new Vector4(a.y, a.x, a.x, a.x); }
        public static Vector4 _1yxx(this Vector2 a) { return new Vector4(1.0f, a.y, a.x, a.x); }
        public static Vector4 _0yxx(this Vector2 a) { return new Vector4(0.0f, a.y, a.x, a.x); }
        public static Vector4 xyxx(this Vector2 a) { return new Vector4(a.x, a.y, a.x, a.x); }
        public static Vector4 yyxx(this Vector2 a) { return new Vector4(a.y, a.y, a.x, a.x); }
        public static Vector4 _11yx(this Vector2 a) { return new Vector4(1.0f, 1.0f, a.y, a.x); }
        public static Vector4 _01yx(this Vector2 a) { return new Vector4(0.0f, 1.0f, a.y, a.x); }
        public static Vector4 x1yx(this Vector2 a) { return new Vector4(a.x, 1.0f, a.y, a.x); }
        public static Vector4 y1yx(this Vector2 a) { return new Vector4(a.y, 1.0f, a.y, a.x); }
        public static Vector4 _10yx(this Vector2 a) { return new Vector4(1.0f, 0.0f, a.y, a.x); }
        public static Vector4 _00yx(this Vector2 a) { return new Vector4(0.0f, 0.0f, a.y, a.x); }
        public static Vector4 x0yx(this Vector2 a) { return new Vector4(a.x, 0.0f, a.y, a.x); }
        public static Vector4 y0yx(this Vector2 a) { return new Vector4(a.y, 0.0f, a.y, a.x); }
        public static Vector4 _1xyx(this Vector2 a) { return new Vector4(1.0f, a.x, a.y, a.x); }
        public static Vector4 _0xyx(this Vector2 a) { return new Vector4(0.0f, a.x, a.y, a.x); }
        public static Vector4 xxyx(this Vector2 a) { return new Vector4(a.x, a.x, a.y, a.x); }
        public static Vector4 yxyx(this Vector2 a) { return new Vector4(a.y, a.x, a.y, a.x); }
        public static Vector4 _1yyx(this Vector2 a) { return new Vector4(1.0f, a.y, a.y, a.x); }
        public static Vector4 _0yyx(this Vector2 a) { return new Vector4(0.0f, a.y, a.y, a.x); }
        public static Vector4 xyyx(this Vector2 a) { return new Vector4(a.x, a.y, a.y, a.x); }
        public static Vector4 yyyx(this Vector2 a) { return new Vector4(a.y, a.y, a.y, a.x); }
        public static Vector4 _111y(this Vector2 a) { return new Vector4(1.0f, 1.0f, 1.0f, a.y); }
        public static Vector4 _011y(this Vector2 a) { return new Vector4(0.0f, 1.0f, 1.0f, a.y); }
        public static Vector4 x11y(this Vector2 a) { return new Vector4(a.x, 1.0f, 1.0f, a.y); }
        public static Vector4 y11y(this Vector2 a) { return new Vector4(a.y, 1.0f, 1.0f, a.y); }
        public static Vector4 _101y(this Vector2 a) { return new Vector4(1.0f, 0.0f, 1.0f, a.y); }
        public static Vector4 _001y(this Vector2 a) { return new Vector4(0.0f, 0.0f, 1.0f, a.y); }
        public static Vector4 x01y(this Vector2 a) { return new Vector4(a.x, 0.0f, 1.0f, a.y); }
        public static Vector4 y01y(this Vector2 a) { return new Vector4(a.y, 0.0f, 1.0f, a.y); }
        public static Vector4 _1x1y(this Vector2 a) { return new Vector4(1.0f, a.x, 1.0f, a.y); }
        public static Vector4 _0x1y(this Vector2 a) { return new Vector4(0.0f, a.x, 1.0f, a.y); }
        public static Vector4 xx1y(this Vector2 a) { return new Vector4(a.x, a.x, 1.0f, a.y); }
        public static Vector4 yx1y(this Vector2 a) { return new Vector4(a.y, a.x, 1.0f, a.y); }
        public static Vector4 _1y1y(this Vector2 a) { return new Vector4(1.0f, a.y, 1.0f, a.y); }
        public static Vector4 _0y1y(this Vector2 a) { return new Vector4(0.0f, a.y, 1.0f, a.y); }
        public static Vector4 xy1y(this Vector2 a) { return new Vector4(a.x, a.y, 1.0f, a.y); }
        public static Vector4 yy1y(this Vector2 a) { return new Vector4(a.y, a.y, 1.0f, a.y); }
        public static Vector4 _110y(this Vector2 a) { return new Vector4(1.0f, 1.0f, 0.0f, a.y); }
        public static Vector4 _010y(this Vector2 a) { return new Vector4(0.0f, 1.0f, 0.0f, a.y); }
        public static Vector4 x10y(this Vector2 a) { return new Vector4(a.x, 1.0f, 0.0f, a.y); }
        public static Vector4 y10y(this Vector2 a) { return new Vector4(a.y, 1.0f, 0.0f, a.y); }
        public static Vector4 _100y(this Vector2 a) { return new Vector4(1.0f, 0.0f, 0.0f, a.y); }
        public static Vector4 _000y(this Vector2 a) { return new Vector4(0.0f, 0.0f, 0.0f, a.y); }
        public static Vector4 x00y(this Vector2 a) { return new Vector4(a.x, 0.0f, 0.0f, a.y); }
        public static Vector4 y00y(this Vector2 a) { return new Vector4(a.y, 0.0f, 0.0f, a.y); }
        public static Vector4 _1x0y(this Vector2 a) { return new Vector4(1.0f, a.x, 0.0f, a.y); }
        public static Vector4 _0x0y(this Vector2 a) { return new Vector4(0.0f, a.x, 0.0f, a.y); }
        public static Vector4 xx0y(this Vector2 a) { return new Vector4(a.x, a.x, 0.0f, a.y); }
        public static Vector4 yx0y(this Vector2 a) { return new Vector4(a.y, a.x, 0.0f, a.y); }
        public static Vector4 _1y0y(this Vector2 a) { return new Vector4(1.0f, a.y, 0.0f, a.y); }
        public static Vector4 _0y0y(this Vector2 a) { return new Vector4(0.0f, a.y, 0.0f, a.y); }
        public static Vector4 xy0y(this Vector2 a) { return new Vector4(a.x, a.y, 0.0f, a.y); }
        public static Vector4 yy0y(this Vector2 a) { return new Vector4(a.y, a.y, 0.0f, a.y); }
        public static Vector4 _11xy(this Vector2 a) { return new Vector4(1.0f, 1.0f, a.x, a.y); }
        public static Vector4 _01xy(this Vector2 a) { return new Vector4(0.0f, 1.0f, a.x, a.y); }
        public static Vector4 x1xy(this Vector2 a) { return new Vector4(a.x, 1.0f, a.x, a.y); }
        public static Vector4 y1xy(this Vector2 a) { return new Vector4(a.y, 1.0f, a.x, a.y); }
        public static Vector4 _10xy(this Vector2 a) { return new Vector4(1.0f, 0.0f, a.x, a.y); }
        public static Vector4 _00xy(this Vector2 a) { return new Vector4(0.0f, 0.0f, a.x, a.y); }
        public static Vector4 x0xy(this Vector2 a) { return new Vector4(a.x, 0.0f, a.x, a.y); }
        public static Vector4 y0xy(this Vector2 a) { return new Vector4(a.y, 0.0f, a.x, a.y); }
        public static Vector4 _1xxy(this Vector2 a) { return new Vector4(1.0f, a.x, a.x, a.y); }
        public static Vector4 _0xxy(this Vector2 a) { return new Vector4(0.0f, a.x, a.x, a.y); }
        public static Vector4 xxxy(this Vector2 a) { return new Vector4(a.x, a.x, a.x, a.y); }
        public static Vector4 yxxy(this Vector2 a) { return new Vector4(a.y, a.x, a.x, a.y); }
        public static Vector4 _1yxy(this Vector2 a) { return new Vector4(1.0f, a.y, a.x, a.y); }
        public static Vector4 _0yxy(this Vector2 a) { return new Vector4(0.0f, a.y, a.x, a.y); }
        public static Vector4 xyxy(this Vector2 a) { return new Vector4(a.x, a.y, a.x, a.y); }
        public static Vector4 yyxy(this Vector2 a) { return new Vector4(a.y, a.y, a.x, a.y); }
        public static Vector4 _11yy(this Vector2 a) { return new Vector4(1.0f, 1.0f, a.y, a.y); }
        public static Vector4 _01yy(this Vector2 a) { return new Vector4(0.0f, 1.0f, a.y, a.y); }
        public static Vector4 x1yy(this Vector2 a) { return new Vector4(a.x, 1.0f, a.y, a.y); }
        public static Vector4 y1yy(this Vector2 a) { return new Vector4(a.y, 1.0f, a.y, a.y); }
        public static Vector4 _10yy(this Vector2 a) { return new Vector4(1.0f, 0.0f, a.y, a.y); }
        public static Vector4 _00yy(this Vector2 a) { return new Vector4(0.0f, 0.0f, a.y, a.y); }
        public static Vector4 x0yy(this Vector2 a) { return new Vector4(a.x, 0.0f, a.y, a.y); }
        public static Vector4 y0yy(this Vector2 a) { return new Vector4(a.y, 0.0f, a.y, a.y); }
        public static Vector4 _1xyy(this Vector2 a) { return new Vector4(1.0f, a.x, a.y, a.y); }
        public static Vector4 _0xyy(this Vector2 a) { return new Vector4(0.0f, a.x, a.y, a.y); }
        public static Vector4 xxyy(this Vector2 a) { return new Vector4(a.x, a.x, a.y, a.y); }
        public static Vector4 yxyy(this Vector2 a) { return new Vector4(a.y, a.x, a.y, a.y); }
        public static Vector4 _1yyy(this Vector2 a) { return new Vector4(1.0f, a.y, a.y, a.y); }
        public static Vector4 _0yyy(this Vector2 a) { return new Vector4(0.0f, a.y, a.y, a.y); }
        public static Vector4 xyyy(this Vector2 a) { return new Vector4(a.x, a.y, a.y, a.y); }
        public static Vector4 yyyy(this Vector2 a) { return new Vector4(a.y, a.y, a.y, a.y); }
    }
}