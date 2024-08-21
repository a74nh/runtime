// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Numerics;

namespace System.Runtime.Intrinsics.Arm
{
    /// <summary>
    /// This class provides access to the ARM SVE hardware instructions via intrinsics
    /// </summary>
    [Intrinsic]
    [CLSCompliant(false)]
    public abstract class SveFp16 : AdvSimd
    {
        internal SveFp16() { }

        public static new bool IsSupported { get => IsSupported; }

        [Intrinsic]
        public new abstract class Arm64 : AdvSimd.Arm64
        {
            internal Arm64() { }

            public static new bool IsSupported { get => IsSupported; }
        }

        // Absolute value

        /// <summary>
        /// svfloat16_t svabs[_f16]_m(svfloat16_t inactive, svbool_t pg, svfloat16_t op)
        /// svfloat16_t svabs[_f16]_x(svbool_t pg, svfloat16_t op)
        /// svfloat16_t svabs[_f16]_z(svbool_t pg, svfloat16_t op)
        ///   FABS Ztied.H, Pg/M, Zop.H
        ///   FABS Ztied.H, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<half> Abs(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Absolute compare greater than

        /// <summary>
        /// svbool_t svacgt[_f16](svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FACGT Presult.H, Pg/Z, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> AbsoluteCompareGreaterThan(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Absolute compare greater than or equal to

        /// <summary>
        /// svbool_t svacge[_f16](svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FACGE Presult.H, Pg/Z, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> AbsoluteCompareGreaterThanOrEqual(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Absolute compare less than

        /// <summary>
        /// svbool_t svaclt[_f16](svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FACGT Presult.H, Pg/Z, Zop2.H, Zop1.H
        /// </summary>
        public static unsafe Vector<half> AbsoluteCompareLessThan(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Absolute compare less than or equal to

        /// <summary>
        /// svbool_t svacle[_f16](svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FACGE Presult.H, Pg/Z, Zop2.H, Zop1.H
        /// </summary>
        public static unsafe Vector<half> AbsoluteCompareLessThanOrEqual(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Absolute difference

        /// <summary>
        /// svfloat16_t svabd[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svabd[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svabd[_f16]_z(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FABD Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FABD Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FABD Ztied2.H, Pg/M, Ztied2.H, Zop1.H
        /// </summary>
        public static unsafe Vector<half> AbsoluteDifference(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Add

        /// <summary>
        /// svfloat16_t svadd[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svadd[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svadd[_f16]_z(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FADD Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FADD Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FADD Ztied2.H, Pg/M, Ztied2.H, Zop1.H
        ///   FADD Zresult.H, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> Add(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Add reduction

        /// <summary>
        /// float16_t svaddv[_f16](svbool_t pg, svfloat16_t op)
        ///   FADDV Hresult, Pg, Zop.H
        /// </summary>
        public static unsafe Vector<half> AddAcross(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Add pairwise

        /// <summary>
        /// svfloat16_t svaddp[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svaddp[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FADDP Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FADDP Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> AddPairwise(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Complex add with rotate

        /// <summary>
        /// svfloat16_t svcadd[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2, uint64_t imm_rotation)
        /// svfloat16_t svcadd[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2, uint64_t imm_rotation)
        /// svfloat16_t svcadd[_f16]_z(svbool_t pg, svfloat16_t op1, svfloat16_t op2, uint64_t imm_rotation)
        ///   FCADD Ztied1.H, Pg/M, Ztied1.H, Zop2.H, #imm_rotation
        ///   FCADD Ztied1.H, Pg/M, Ztied1.H, Zop2.H, #imm_rotation
        /// </summary>
        public static unsafe Vector<half> AddRotateComplex(Vector<half> left, Vector<half> right, [ConstantExpected] byte rotation) { throw new PlatformNotSupportedException(); }


        // Add reduction (strictly-ordered)

        /// <summary>
        /// float16_t svadda[_f16](svbool_t pg, float16_t initial, svfloat16_t op)
        ///   FADDA Htied, Pg, Htied, Zop.H
        /// </summary>
        public static unsafe Vector<half> AddSequentialAcross(Vector<half> initial, Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Compare equal to

        /// <summary>
        /// svbool_t svcmpeq[_f16](svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FCMEQ Presult.H, Pg/Z, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> CompareEqual(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Compare greater than

        /// <summary>
        /// svbool_t svcmpgt[_f16](svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FCMGT Presult.H, Pg/Z, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> CompareGreaterThan(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Compare greater than or equal to

        /// <summary>
        /// svbool_t svcmpge[_f16](svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FCMGE Presult.H, Pg/Z, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> CompareGreaterThanOrEqual(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Compare less than

        /// <summary>
        /// svbool_t svcmplt[_f16](svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FCMGT Presult.H, Pg/Z, Zop2.H, Zop1.H
        /// </summary>
        public static unsafe Vector<half> CompareLessThan(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Compare less than or equal to

        /// <summary>
        /// svbool_t svcmple[_f16](svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FCMGE Presult.H, Pg/Z, Zop2.H, Zop1.H
        /// </summary>
        public static unsafe Vector<half> CompareLessThanOrEqual(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Compare not equal to

        /// <summary>
        /// svbool_t svcmpne[_f16](svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FCMNE Presult.H, Pg/Z, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> CompareNotEqualTo(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Compare unordered with

        /// <summary>
        /// svbool_t svcmpuo[_f16](svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FCMUO Presult.H, Pg/Z, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> CompareUnordered(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Concatenate even quadwords from two inputs

        /// <summary>
        /// svfloat16_t svuzp1q[_f16](svfloat16_t op1, svfloat16_t op2)
        ///   UZP1 Zresult.Q, Zop1.Q, Zop2.Q
        /// </summary>
        public static unsafe Vector<half> ConcatenateEvenInt128FromTwoInputs(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Concatenate odd quadwords from two inputs

        /// <summary>
        /// svfloat16_t svuzp2q[_f16](svfloat16_t op1, svfloat16_t op2)
        ///   UZP2 Zresult.Q, Zop1.Q, Zop2.Q
        /// </summary>
        public static unsafe Vector<half> ConcatenateOddInt128FromTwoInputs(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Conditionally extract element after last

        /// <summary>
        /// svfloat16_t svclasta[_f16](svbool_t pg, svfloat16_t fallback, svfloat16_t data)
        ///   CLASTA Ztied.H, Pg, Ztied.H, Zdata.H
        /// </summary>
        public static unsafe Vector<half> ConditionalExtractAfterLastActiveElement(Vector<half> mask, Vector<half> defaultValue, Vector<half> data) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// svfloat16_t svclasta[_f16](svbool_t pg, svfloat16_t fallback, svfloat16_t data)
        /// float16_t svclasta[_n_f16](svbool_t pg, float16_t fallback, svfloat16_t data)
        ///   CLASTA Ztied.H, Pg, Ztied.H, Zdata.H
        ///   CLASTA Wtied, Pg, Wtied, Zdata.H
        ///   CLASTA Htied, Pg, Htied, Zdata.H
        /// </summary>
        public static unsafe half ConditionalExtractAfterLastActiveElement(Vector<half> mask, half defaultValues, Vector<half> data) { throw new PlatformNotSupportedException(); }


        // Conditionally extract element after last

        /// <summary>
        /// svfloat16_t svclasta[_f16](svbool_t pg, svfloat16_t fallback, svfloat16_t data)
        ///   CLASTA Ztied.H, Pg, Ztied.H, Zdata.H
        /// </summary>
        public static unsafe Vector<half> ConditionalExtractAfterLastActiveElementAndReplicate(Vector<half> mask, Vector<half> defaultScalar, Vector<half> data) { throw new PlatformNotSupportedException(); }


        // Conditionally extract last element

        /// <summary>
        /// svfloat16_t svclastb[_f16](svbool_t pg, svfloat16_t fallback, svfloat16_t data)
        ///   CLASTB Ztied.H, Pg, Ztied.H, Zdata.H
        /// </summary>
        public static unsafe Vector<half> ConditionalExtractLastActiveElement(Vector<half> mask, Vector<half> defaultValue, Vector<half> data) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// svfloat16_t svclastb[_f16](svbool_t pg, svfloat16_t fallback, svfloat16_t data)
        /// float16_t svclastb[_n_f16](svbool_t pg, float16_t fallback, svfloat16_t data)
        ///   CLASTB Ztied.H, Pg, Ztied.H, Zdata.H
        ///   CLASTB Wtied, Pg, Wtied, Zdata.H
        ///   CLASTB Htied, Pg, Htied, Zdata.H
        /// </summary>
        public static unsafe half ConditionalExtractLastActiveElement(Vector<half> mask, half defaultValues, Vector<half> data) { throw new PlatformNotSupportedException(); }


        // Conditionally extract last element

        /// <summary>
        /// svfloat16_t svclastb[_f16](svbool_t pg, svfloat16_t fallback, svfloat16_t data)
        ///   CLASTB Ztied.H, Pg, Ztied.H, Zdata.H
        /// </summary>
        public static unsafe Vector<half> ConditionalExtractLastActiveElementAndReplicate(Vector<half> mask, Vector<half> fallback, Vector<half> data) { throw new PlatformNotSupportedException(); }


        // Conditionally select elements

        /// <summary>
        /// svfloat16_t svsel[_f16](svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   SEL Zresult.H, Pg, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> ConditionalSelect(Vector<half> mask, Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Floating-point convert

        /// <summary>
        /// svfloat64_t svcvt_f64[_f16]_m(svfloat64_t inactive, svbool_t pg, svfloat16_t op)
        /// svfloat64_t svcvt_f64[_f16]_x(svbool_t pg, svfloat16_t op)
        /// svfloat64_t svcvt_f64[_f16]_z(svbool_t pg, svfloat16_t op)
        ///   FCVT Ztied.D, Pg/M, Zop.H
        ///   FCVT Ztied.D, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<double> ConvertToDouble(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Floating-point convert

        /// <summary>
        /// svfloat16_t svcvt_f16[_f64]_m(svfloat16_t inactive, svbool_t pg, svfloat64_t op)
        /// svfloat16_t svcvt_f16[_f64]_x(svbool_t pg, svfloat64_t op)
        /// svfloat16_t svcvt_f16[_f64]_z(svbool_t pg, svfloat64_t op)
        ///   FCVT Ztied.H, Pg/M, Zop.D
        ///   FCVT Ztied.H, Pg/M, Ztied.D
        /// </summary>
        public static unsafe Vector<half> ConvertToHalf(Vector<double> value) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// svfloat16_t svcvt_f16[_s16]_m(svfloat16_t inactive, svbool_t pg, svint16_t op)
        /// svfloat16_t svcvt_f16[_s16]_x(svbool_t pg, svint16_t op)
        /// svfloat16_t svcvt_f16[_s16]_z(svbool_t pg, svint16_t op)
        ///   SCVTF Ztied.H, Pg/M, Zop.H
        ///   SCVTF Ztied.H, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<half> ConvertToHalf(Vector<short> value) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// svfloat16_t svcvt_f16[_s32]_m(svfloat16_t inactive, svbool_t pg, svint32_t op)
        /// svfloat16_t svcvt_f16[_s32]_x(svbool_t pg, svint32_t op)
        /// svfloat16_t svcvt_f16[_s32]_z(svbool_t pg, svint32_t op)
        ///   SCVTF Ztied.H, Pg/M, Zop.S
        ///   SCVTF Ztied.H, Pg/M, Ztied.S
        /// </summary>
        public static unsafe Vector<half> ConvertToHalf(Vector<int> value) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// svfloat16_t svcvt_f16[_s64]_m(svfloat16_t inactive, svbool_t pg, svint64_t op)
        /// svfloat16_t svcvt_f16[_s64]_x(svbool_t pg, svint64_t op)
        /// svfloat16_t svcvt_f16[_s64]_z(svbool_t pg, svint64_t op)
        ///   SCVTF Ztied.H, Pg/M, Zop.D
        ///   SCVTF Ztied.H, Pg/M, Ztied.D
        /// </summary>
        public static unsafe Vector<half> ConvertToHalf(Vector<long> value) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// svfloat16_t svcvt_f16[_f32]_m(svfloat16_t inactive, svbool_t pg, svfloat32_t op)
        /// svfloat16_t svcvt_f16[_f32]_x(svbool_t pg, svfloat32_t op)
        /// svfloat16_t svcvt_f16[_f32]_z(svbool_t pg, svfloat32_t op)
        ///   FCVT Ztied.H, Pg/M, Zop.S
        ///   FCVT Ztied.H, Pg/M, Ztied.S
        /// </summary>
        public static unsafe Vector<half> ConvertToHalf(Vector<float> value) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// svfloat16_t svcvt_f16[_u16]_m(svfloat16_t inactive, svbool_t pg, svuint16_t op)
        /// svfloat16_t svcvt_f16[_u16]_x(svbool_t pg, svuint16_t op)
        /// svfloat16_t svcvt_f16[_u16]_z(svbool_t pg, svuint16_t op)
        ///   UCVTF Ztied.H, Pg/M, Zop.H
        ///   UCVTF Ztied.H, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<half> ConvertToHalf(Vector<ushort> value) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// svfloat16_t svcvt_f16[_u32]_m(svfloat16_t inactive, svbool_t pg, svuint32_t op)
        /// svfloat16_t svcvt_f16[_u32]_x(svbool_t pg, svuint32_t op)
        /// svfloat16_t svcvt_f16[_u32]_z(svbool_t pg, svuint32_t op)
        ///   UCVTF Ztied.H, Pg/M, Zop.S
        ///   UCVTF Ztied.H, Pg/M, Ztied.S
        /// </summary>
        public static unsafe Vector<half> ConvertToHalf(Vector<uint> value) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// svfloat16_t svcvt_f16[_u64]_m(svfloat16_t inactive, svbool_t pg, svuint64_t op)
        /// svfloat16_t svcvt_f16[_u64]_x(svbool_t pg, svuint64_t op)
        /// svfloat16_t svcvt_f16[_u64]_z(svbool_t pg, svuint64_t op)
        ///   UCVTF Ztied.H, Pg/M, Zop.D
        ///   UCVTF Ztied.H, Pg/M, Ztied.D
        /// </summary>
        public static unsafe Vector<half> ConvertToHalf(Vector<ulong> value) { throw new PlatformNotSupportedException(); }


        // Floating-point convert

        /// <summary>
        /// svint16_t svcvt_s16[_f16]_m(svint16_t inactive, svbool_t pg, svfloat16_t op)
        /// svint16_t svcvt_s16[_f16]_x(svbool_t pg, svfloat16_t op)
        /// svint16_t svcvt_s16[_f16]_z(svbool_t pg, svfloat16_t op)
        ///   FCVTZS Ztied.H, Pg/M, Zop.H
        ///   FCVTZS Ztied.H, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<short> ConvertToInt16(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Floating-point convert

        /// <summary>
        /// svint32_t svcvt_s32[_f16]_m(svint32_t inactive, svbool_t pg, svfloat16_t op)
        /// svint32_t svcvt_s32[_f16]_x(svbool_t pg, svfloat16_t op)
        /// svint32_t svcvt_s32[_f16]_z(svbool_t pg, svfloat16_t op)
        ///   FCVTZS Ztied.S, Pg/M, Zop.H
        ///   FCVTZS Ztied.S, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<int> ConvertToInt32(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Floating-point convert

        /// <summary>
        /// svint64_t svcvt_s64[_f16]_m(svint64_t inactive, svbool_t pg, svfloat16_t op)
        /// svint64_t svcvt_s64[_f16]_x(svbool_t pg, svfloat16_t op)
        /// svint64_t svcvt_s64[_f16]_z(svbool_t pg, svfloat16_t op)
        ///   FCVTZS Ztied.D, Pg/M, Zop.H
        ///   FCVTZS Ztied.D, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<long> ConvertToInt64(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Floating-point convert

        /// <summary>
        /// svfloat32_t svcvt_f32[_f16]_m(svfloat32_t inactive, svbool_t pg, svfloat16_t op)
        /// svfloat32_t svcvt_f32[_f16]_x(svbool_t pg, svfloat16_t op)
        /// svfloat32_t svcvt_f32[_f16]_z(svbool_t pg, svfloat16_t op)
        ///   FCVT Ztied.S, Pg/M, Zop.H
        ///   FCVT Ztied.S, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<float> ConvertToSingle(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Floating-point convert

        /// <summary>
        /// svuint16_t svcvt_u16[_f16]_m(svuint16_t inactive, svbool_t pg, svfloat16_t op)
        /// svuint16_t svcvt_u16[_f16]_x(svbool_t pg, svfloat16_t op)
        /// svuint16_t svcvt_u16[_f16]_z(svbool_t pg, svfloat16_t op)
        ///   FCVTZU Ztied.H, Pg/M, Zop.H
        ///   FCVTZU Ztied.H, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<ushort> ConvertToUInt16(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Floating-point convert

        /// <summary>
        /// svuint32_t svcvt_u32[_f16]_m(svuint32_t inactive, svbool_t pg, svfloat16_t op)
        /// svuint32_t svcvt_u32[_f16]_x(svbool_t pg, svfloat16_t op)
        /// svuint32_t svcvt_u32[_f16]_z(svbool_t pg, svfloat16_t op)
        ///   FCVTZU Ztied.S, Pg/M, Zop.H
        ///   FCVTZU Ztied.S, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<uint> ConvertToUInt32(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Floating-point convert

        /// <summary>
        /// svuint64_t svcvt_u64[_f16]_m(svuint64_t inactive, svbool_t pg, svfloat16_t op)
        /// svuint64_t svcvt_u64[_f16]_x(svbool_t pg, svfloat16_t op)
        /// svuint64_t svcvt_u64[_f16]_z(svbool_t pg, svfloat16_t op)
        ///   FCVTZU Ztied.D, Pg/M, Zop.H
        ///   FCVTZU Ztied.D, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<ulong> ConvertToUInt64(Vector<half> value) { throw new PlatformNotSupportedException(); }



        // Set all predicate elements to false

        /// <summary>
        /// svbool_t svpfalse[_b]()
        ///   PFALSE Presult.B
        /// </summary>
        public static unsafe Vector<half> CreateFalseMaskHalf() { throw new PlatformNotSupportedException(); }


        // Set predicate elements to true

        /// <summary>
        /// svbool_t svptrue_pat_b8(enum svpattern pattern)
        ///   PTRUE Presult.B, pattern
        /// </summary>
        public static unsafe Vector<half> CreateTrueMaskHalf([ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All) { throw new PlatformNotSupportedException(); }


        // While free of read-after-write conflicts

        /// <summary>
        /// svbool_t svwhilerw[_f16](const float16_t *op1, const float16_t *op2)
        ///   WHILERW Presult.H, Xop1, Xop2
        /// </summary>
        public static unsafe Vector<half> CreateWhileReadAfterWriteMask(half* left, half* right) { throw new PlatformNotSupportedException(); }


        // While free of write-after-read conflicts

        /// <summary>
        /// svbool_t svwhilewr[_f16](const float16_t *op1, const float16_t *op2)
        ///   WHILEWR Presult.H, Xop1, Xop2
        /// </summary>
        public static unsafe Vector<half> CreateWhileWriteAfterReadMask(half* left, half* right) { throw new PlatformNotSupportedException(); }


        // Divide

        /// <summary>
        /// svfloat16_t svdiv[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svdiv[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svdiv[_f16]_z(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FDIV Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FDIV Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FDIVR Ztied2.H, Pg/M, Ztied2.H, Zop1.H
        /// </summary>
        public static unsafe Vector<half> Divide(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }



        // Down convert and narrow (top)

        /// <summary>
        /// svfloat16_t svcvtnt_f16[_f32]_m(svfloat16_t even, svbool_t pg, svfloat32_t op)
        /// svfloat16_t svcvtnt_f16[_f32]_x(svfloat16_t even, svbool_t pg, svfloat32_t op)
        ///   FCVTNT Ztied.H, Pg/M, Zop.S
        ///   FCVTNT Ztied.H, Pg/M, Zop.S
        /// </summary>
        public static unsafe Vector<half> DownConvertNarrowingUpper(Vector<float> value) { throw new PlatformNotSupportedException(); }


        // Broadcast a scalar value

        /// <summary>
        /// svfloat16_t svdup_lane[_f16](svfloat16_t data, uint16_t index)
        /// svfloat16_t svdupq_lane[_f16](svfloat16_t data, uint64_t index)
        ///   DUP Zresult.H, Zdata.H[index]
        ///   TBL Zresult.H, Zdata.H, Zindex.H
        ///   DUP Zresult.Q, Zdata.Q[index]
        ///   TBL Zresult.D, Zdata.D, Zindices_d.D
        /// </summary>
        public static unsafe Vector<half> DuplicateSelectedScalarToVector(Vector<half> data, [ConstantExpected] byte index) { throw new PlatformNotSupportedException(); }


        // Extract element after last

        /// <summary>
        /// float16_t svlasta[_f16](svbool_t pg, svfloat16_t op)
        ///   LASTA Wresult, Pg, Zop.H
        ///   LASTA Hresult, Pg, Zop.H
        /// </summary>
        public static unsafe half ExtractAfterLastScalar(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Extract element after last

        /// <summary>
        /// float16_t svlasta[_f16](svbool_t pg, svfloat16_t op)
        ///   LASTA Wresult, Pg, Zop.H
        ///   LASTA Hresult, Pg, Zop.H
        /// </summary>
        public static unsafe Vector<half> ExtractAfterLastVector(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Extract last element

        /// <summary>
        /// float16_t svlastb[_f16](svbool_t pg, svfloat16_t op)
        ///   LASTB Wresult, Pg, Zop.H
        ///   LASTB Hresult, Pg, Zop.H
        /// </summary>
        public static unsafe half ExtractLastScalar(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Extract last element

        /// <summary>
        /// float16_t svlastb[_f16](svbool_t pg, svfloat16_t op)
        ///   LASTB Wresult, Pg, Zop.H
        ///   LASTB Hresult, Pg, Zop.H
        /// </summary>
        public static unsafe Vector<half> ExtractLastVector(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Extract vector from pair of vectors

        /// <summary>
        /// svfloat16_t svext[_f16](svfloat16_t op1, svfloat16_t op2, uint64_t imm3)
        ///   EXT Ztied1.B, Ztied1.B, Zop2.B, #imm3 * 2
        /// </summary>
        public static unsafe Vector<half> ExtractVector(Vector<half> upper, Vector<half> lower, [ConstantExpected] byte index) { throw new PlatformNotSupportedException(); }


        // Floating-point exponential accelerator

        /// <summary>
        /// svfloat16_t svexpa[_f16](svuint16_t op)
        ///   FEXPA Zresult.H, Zop.H
        /// </summary>
        public static unsafe Vector<half> FloatingPointExponentialAccelerator(Vector<ushort> value) { throw new PlatformNotSupportedException(); }


        // Multiply-add, addend first

        /// <summary>
        /// svfloat16_t svmla[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2, svfloat16_t op3)
        /// svfloat16_t svmla[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2, svfloat16_t op3)
        /// svfloat16_t svmla[_f16]_z(svbool_t pg, svfloat16_t op1, svfloat16_t op2, svfloat16_t op3)
        ///   FMLA Ztied1.H, Pg/M, Zop2.H, Zop3.H
        ///   FMLA Ztied1.H, Pg/M, Zop2.H, Zop3.H
        ///   FMAD Ztied2.H, Pg/M, Zop3.H, Zop1.H
        ///   FMAD Ztied3.H, Pg/M, Zop2.H, Zop1.H
        /// </summary>
        public static unsafe Vector<half> FusedMultiplyAdd(Vector<half> addend, Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Multiply-add, addend first

        /// <summary>
        /// svfloat16_t svmla_lane[_f16](svfloat16_t op1, svfloat16_t op2, svfloat16_t op3, uint64_t imm_index)
        ///   FMLA Ztied1.H, Zop2.H, Zop3.H[imm_index]
        /// </summary>
        public static unsafe Vector<half> FusedMultiplyAddBySelectedScalar(Vector<half> addend, Vector<half> left, Vector<half> right, [ConstantExpected] byte rightIndex) { throw new PlatformNotSupportedException(); }


        // Negated multiply-add, addend first

        /// <summary>
        /// svfloat16_t svnmla[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2, svfloat16_t op3)
        /// svfloat16_t svnmla[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2, svfloat16_t op3)
        /// svfloat16_t svnmla[_f16]_z(svbool_t pg, svfloat16_t op1, svfloat16_t op2, svfloat16_t op3)
        ///   FNMLA Ztied1.H, Pg/M, Zop2.H, Zop3.H
        ///   FNMLA Ztied1.H, Pg/M, Zop2.H, Zop3.H
        ///   FNMAD Ztied2.H, Pg/M, Zop3.H, Zop1.H
        ///   FNMAD Ztied3.H, Pg/M, Zop2.H, Zop1.H
        /// </summary>
        public static unsafe Vector<half> FusedMultiplyAddNegated(Vector<half> addend, Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Multiply-subtract, minuend first

        /// <summary>
        /// svfloat16_t svmls[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2, svfloat16_t op3)
        /// svfloat16_t svmls[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2, svfloat16_t op3)
        /// svfloat16_t svmls[_f16]_z(svbool_t pg, svfloat16_t op1, svfloat16_t op2, svfloat16_t op3)
        ///   FMLS Ztied1.H, Pg/M, Zop2.H, Zop3.H
        ///   FMLS Ztied1.H, Pg/M, Zop2.H, Zop3.H
        ///   FMSB Ztied2.H, Pg/M, Zop3.H, Zop1.H
        ///   FMSB Ztied3.H, Pg/M, Zop2.H, Zop1.H
        /// </summary>
        public static unsafe Vector<half> FusedMultiplySubtract(Vector<half> minuend, Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Multiply-subtract, minuend first

        /// <summary>
        /// svfloat16_t svmls_lane[_f16](svfloat16_t op1, svfloat16_t op2, svfloat16_t op3, uint64_t imm_index)
        ///   FMLS Ztied1.H, Zop2.H, Zop3.H[imm_index]
        /// </summary>
        public static unsafe Vector<half> FusedMultiplySubtractBySelectedScalar(Vector<half> minuend, Vector<half> left, Vector<half> right, [ConstantExpected] byte rightIndex) { throw new PlatformNotSupportedException(); }


        // Negated multiply-subtract, minuend first

        /// <summary>
        /// svfloat16_t svnmls[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2, svfloat16_t op3)
        /// svfloat16_t svnmls[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2, svfloat16_t op3)
        /// svfloat16_t svnmls[_f16]_z(svbool_t pg, svfloat16_t op1, svfloat16_t op2, svfloat16_t op3)
        ///   FNMLS Ztied1.H, Pg/M, Zop2.H, Zop3.H
        ///   FNMLS Ztied1.H, Pg/M, Zop2.H, Zop3.H
        ///   FNMSB Ztied2.H, Pg/M, Zop3.H, Zop1.H
        ///   FNMSB Ztied3.H, Pg/M, Zop2.H, Zop1.H
        /// </summary>
        public static unsafe Vector<half> FusedMultiplySubtractNegated(Vector<half> minuend, Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Count set predicate bits

        /// <summary>
        /// uint64_t svcntp_b8(svbool_t pg, svbool_t op)
        ///   CNTP Xresult, Pg, Pop.B
        /// </summary>
        public static unsafe ulong GetActiveElementCount(Vector<half> mask, Vector<half> from) { throw new PlatformNotSupportedException(); }


        // Insert scalar into shifted vector

        /// <summary>
        /// svfloat16_t svinsr[_n_f16](svfloat16_t op1, float16_t op2)
        ///   INSR Ztied1.H, Wop2
        ///   INSR Ztied1.H, Hop2
        /// </summary>
        public static unsafe Vector<half> InsertIntoShiftedVector(Vector<half> left, half right) { throw new PlatformNotSupportedException(); }


        // Interleave even quadwords from two inputs

        /// <summary>
        /// svfloat16_t svtrn1q[_f16](svfloat16_t op1, svfloat16_t op2)
        ///   TRN1 Zresult.Q, Zop1.Q, Zop2.Q
        /// </summary>
        public static unsafe Vector<half> InterleaveEvenInt128FromTwoInputs(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Interleave quadwords from high halves of two inputs

        /// <summary>
        /// svfloat16_t svzip2q[_f16](svfloat16_t op1, svfloat16_t op2)
        ///   ZIP2 Zresult.Q, Zop1.Q, Zop2.Q
        /// </summary>
        public static unsafe Vector<half> InterleaveInt128FromHighHalvesOfTwoInputs(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Interleave quadwords from low halves of two inputs

        /// <summary>
        /// svfloat16_t svzip1q[_f16](svfloat16_t op1, svfloat16_t op2)
        ///   ZIP1 Zresult.Q, Zop1.Q, Zop2.Q
        /// </summary>
        public static unsafe Vector<half> InterleaveInt128FromLowHalvesOfTwoInputs(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Interleave odd quadwords from two inputs

        /// <summary>
        /// svfloat16_t svtrn2q[_f16](svfloat16_t op1, svfloat16_t op2)
        ///   TRN2 Zresult.Q, Zop1.Q, Zop2.Q
        /// </summary>
        public static unsafe Vector<half> InterleaveOddInt128FromTwoInputs(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Unextended load

        /// <summary>
        /// svfloat16_t svld1[_f16](svbool_t pg, const float16_t *base)
        ///   LD1H Zresult.H, Pg/Z, [Xarray, Xindex, LSL #1]
        ///   LD1H Zresult.H, Pg/Z, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe Vector<half> LoadVector(Vector<half> mask, half* address) { throw new PlatformNotSupportedException(); }


        // Load and replicate 128 bits of data

        /// <summary>
        /// svfloat16_t svld1rq[_f16](svbool_t pg, const float16_t *base)
        ///   LD1RQH Zresult.H, Pg/Z, [Xarray, Xindex, LSL #1]
        ///   LD1RQH Zresult.H, Pg/Z, [Xarray, #index * 2]
        ///   LD1RQH Zresult.H, Pg/Z, [Xbase, #0]
        /// </summary>
        public static unsafe Vector<half> LoadVector128AndReplicateToVector(Vector<half> mask, half* address) { throw new PlatformNotSupportedException(); }


        // Load and replicate 256 bits of data

        /// <summary>
        /// svfloat16_t svld1ro[_f16](svbool_t pg, const float16_t *base)
        ///   LD1ROH Zresult.H, Pg/Z, [Xarray, Xindex, LSL #1]
        ///   LD1ROH Zresult.H, Pg/Z, [Xarray, #index * 2]
        ///   LD1ROH Zresult.H, Pg/Z, [Xbase, #0]
        /// </summary>
        public static unsafe Vector<half> LoadVector256AndReplicateToVector(Vector<half> mask, half* address) { throw new PlatformNotSupportedException(); }


        // Unextended load, first-faulting

        /// <summary>
        /// svfloat16_t svldff1[_f16](svbool_t pg, const float16_t *base)
        ///   LDFF1H Zresult.H, Pg/Z, [Xarray, Xindex, LSL #1]
        ///   LDFF1H Zresult.H, Pg/Z, [Xbase, XZR, LSL #1]
        /// </summary>
        public static unsafe Vector<half> LoadVectorFirstFaulting(Vector<half> mask, half* address) { throw new PlatformNotSupportedException(); }


        // Unextended load, non-faulting

        /// <summary>
        /// svfloat16_t svldnf1[_f16](svbool_t pg, const float16_t *base)
        ///   LDNF1H Zresult.H, Pg/Z, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe Vector<half> LoadVectorNonFaulting(half* address) { throw new PlatformNotSupportedException(); }


        // Unextended load, non-temporal

        /// <summary>
        /// svfloat16_t svldnt1[_f16](svbool_t pg, const float16_t *base)
        ///   LDNT1H Zresult.H, Pg/Z, [Xarray, Xindex, LSL #1]
        ///   LDNT1H Zresult.H, Pg/Z, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe Vector<half> LoadVectorNonTemporal(Vector<half> mask, half* address) { throw new PlatformNotSupportedException(); }


        // Load two-element tuples into two vectors

        /// <summary>
        /// svfloat16x2_t svld2[_f16](svbool_t pg, const float16_t *base)
        ///   LD2H {Zresult0.H, Zresult1.H}, Pg/Z, [Xarray, Xindex, LSL #1]
        ///   LD2H {Zresult0.H, Zresult1.H}, Pg/Z, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe (Vector<half>, Vector<half>) LoadVectorx2(Vector<half> mask, half* address) { throw new PlatformNotSupportedException(); }


        // Load three-element tuples into three vectors

        /// <summary>
        /// svfloat16x3_t svld3[_f16](svbool_t pg, const float16_t *base)
        ///   LD3H {Zresult0.H - Zresult2.H}, Pg/Z, [Xarray, Xindex, LSL #1]
        ///   LD3H {Zresult0.H - Zresult2.H}, Pg/Z, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe (Vector<half>, Vector<half>, Vector<half>) LoadVectorx3(Vector<half> mask, half* address) { throw new PlatformNotSupportedException(); }


        // Load four-element tuples into four vectors

        /// <summary>
        /// svfloat16x4_t svld4[_f16](svbool_t pg, const float16_t *base)
        ///   LD4H {Zresult0.H - Zresult3.H}, Pg/Z, [Xarray, Xindex, LSL #1]
        ///   LD4H {Zresult0.H - Zresult3.H}, Pg/Z, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe (Vector<half>, Vector<half>, Vector<half>, Vector<half>) LoadVectorx4(Vector<half> mask, half* address) { throw new PlatformNotSupportedException(); }


        // Base 2 logarithm as integer

        /// <summary>
        /// svint16_t svlogb[_f16]_m(svint16_t inactive, svbool_t pg, svfloat16_t op)
        /// svint16_t svlogb[_f16]_x(svbool_t pg, svfloat16_t op)
        /// svint16_t svlogb[_f16]_z(svbool_t pg, svfloat16_t op)
        ///   FLOGB Ztied.H, Pg/M, Zop.H
        ///   FLOGB Ztied.H, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<short> Log2(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Maximum

        /// <summary>
        /// svfloat16_t svmax[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svmax[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svmax[_f16]_z(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FMAX Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FMAX Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FMAX Ztied2.H, Pg/M, Ztied2.H, Zop1.H
        /// </summary>
        public static unsafe Vector<half> Max(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Maximum reduction to scalar

        /// <summary>
        /// float16_t svmaxv[_f16](svbool_t pg, svfloat16_t op)
        ///   FMAXV Hresult, Pg, Zop.H
        /// </summary>
        public static unsafe Vector<half> MaxAcross(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Maximum number

        /// <summary>
        /// svfloat16_t svmaxnm[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svmaxnm[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svmaxnm[_f16]_z(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FMAXNM Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FMAXNM Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FMAXNM Ztied2.H, Pg/M, Ztied2.H, Zop1.H
        /// </summary>
        public static unsafe Vector<half> MaxNumber(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Maximum number reduction to scalar

        /// <summary>
        /// float16_t svmaxnmv[_f16](svbool_t pg, svfloat16_t op)
        ///   FMAXNMV Hresult, Pg, Zop.H
        /// </summary>
        public static unsafe Vector<half> MaxNumberAcross(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Maximum number pairwise

        /// <summary>
        /// svfloat16_t svmaxnmp[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svmaxnmp[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FMAXNMP Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FMAXNMP Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> MaxNumberPairwise(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Maximum pairwise

        /// <summary>
        /// svfloat16_t svmaxp[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svmaxp[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FMAXP Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FMAXP Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> MaxPairwise(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Minimum

        /// <summary>
        /// svfloat16_t svmin[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svmin[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svmin[_f16]_z(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FMIN Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FMIN Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FMIN Ztied2.H, Pg/M, Ztied2.H, Zop1.H
        /// </summary>
        public static unsafe Vector<half> Min(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Minimum reduction to scalar

        /// <summary>
        /// float16_t svminv[_f16](svbool_t pg, svfloat16_t op)
        ///   FMINV Hresult, Pg, Zop.H
        /// </summary>
        public static unsafe Vector<half> MinAcross(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Minimum number

        /// <summary>
        /// svfloat16_t svminnm[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svminnm[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svminnm[_f16]_z(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FMINNM Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FMINNM Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FMINNM Ztied2.H, Pg/M, Ztied2.H, Zop1.H
        /// </summary>
        public static unsafe Vector<half> MinNumber(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Minimum number reduction to scalar

        /// <summary>
        /// float16_t svminnmv[_f16](svbool_t pg, svfloat16_t op)
        ///   FMINNMV Hresult, Pg, Zop.H
        /// </summary>
        public static unsafe Vector<half> MinNumberAcross(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Minimum number pairwise

        /// <summary>
        /// svfloat16_t svminnmp[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svminnmp[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FMINNMP Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FMINNMP Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> MinNumberPairwise(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Minimum pairwise

        /// <summary>
        /// svfloat16_t svminp[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svminp[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FMINP Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FMINP Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> MinPairwise(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Multiply

        /// <summary>
        /// svfloat16_t svmul[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svmul[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svmul[_f16]_z(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FMUL Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FMUL Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FMUL Ztied2.H, Pg/M, Ztied2.H, Zop1.H
        ///   FMUL Zresult.H, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> Multiply(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }





        // Complex multiply-add with rotate

        /// <summary>
        /// svfloat16_t svcmla[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2, svfloat16_t op3, uint64_t imm_rotation)
        /// svfloat16_t svcmla[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2, svfloat16_t op3, uint64_t imm_rotation)
        /// svfloat16_t svcmla[_f16]_z(svbool_t pg, svfloat16_t op1, svfloat16_t op2, svfloat16_t op3, uint64_t imm_rotation)
        ///   FCMLA Ztied1.H, Pg/M, Zop2.H, Zop3.H, #imm_rotation
        ///   FCMLA Ztied1.H, Pg/M, Zop2.H, Zop3.H, #imm_rotation
        /// </summary>
        public static unsafe Vector<half> MultiplyAddRotateComplex(Vector<half> addend, Vector<half> left, Vector<half> right, [ConstantExpected] byte rotation) { throw new PlatformNotSupportedException(); }


        // Complex multiply-add with rotate

        /// <summary>
        /// svfloat16_t svcmla_lane[_f16](svfloat16_t op1, svfloat16_t op2, svfloat16_t op3, uint64_t imm_index, uint64_t imm_rotation)
        ///   FCMLA Ztied1.H, Zop2.H, Zop3.H[imm_index], #imm_rotation
        /// </summary>
        public static unsafe Vector<half> MultiplyAddRotateComplexBySelectedScalar(Vector<half> addend, Vector<half> left, Vector<half> right, [ConstantExpected] byte rightIndex, [ConstantExpected] byte rotation) { throw new PlatformNotSupportedException(); }


        // Multiply-add long (bottom)

        /// <summary>
        /// svfloat32_t svmlalb[_f32](svfloat32_t op1, svfloat16_t op2, svfloat16_t op3)
        ///   FMLALB Ztied1.S, Zop2.H, Zop3.H
        /// </summary>
        public static unsafe Vector<float> MultiplyAddWideningLower(Vector<float> op1, Vector<half> op2, Vector<half> op3) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// svfloat32_t svmlalb_lane[_f32](svfloat32_t op1, svfloat16_t op2, svfloat16_t op3, uint64_t imm_index)
        ///   FMLALB Ztied1.S, Zop2.H, Zop3.H[imm_index]
        /// </summary>
        public static unsafe Vector<float> MultiplyAddWideningLower(Vector<float> op1, Vector<half> op2, Vector<half> op3, ulong imm_index) { throw new PlatformNotSupportedException(); }


        // Multiply-add long (top)

        /// <summary>
        /// svfloat32_t svmlalt[_f32](svfloat32_t op1, svfloat16_t op2, svfloat16_t op3)
        ///   FMLALT Ztied1.S, Zop2.H, Zop3.H
        /// </summary>
        public static unsafe Vector<float> MultiplyAddWideningUpper(Vector<float> op1, Vector<half> op2, Vector<half> op3) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// svfloat32_t svmlalt_lane[_f32](svfloat32_t op1, svfloat16_t op2, svfloat16_t op3, uint64_t imm_index)
        ///   FMLALT Ztied1.S, Zop2.H, Zop3.H[imm_index]
        /// </summary>
        public static unsafe Vector<float> MultiplyAddWideningUpper(Vector<float> op1, Vector<half> op2, Vector<half> op3, ulong imm_index) { throw new PlatformNotSupportedException(); }


        // Multiply

        /// <summary>
        /// svfloat16_t svmul_lane[_f16](svfloat16_t op1, svfloat16_t op2, uint64_t imm_index)
        ///   FMUL Zresult.H, Zop1.H, Zop2.H[imm_index]
        /// </summary>
        public static unsafe Vector<half> MultiplyBySelectedScalar(Vector<half> left, Vector<half> right, [ConstantExpected] byte rightIndex) { throw new PlatformNotSupportedException(); }


        // Multiply extended (∞×0=2)

        /// <summary>
        /// svfloat16_t svmulx[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svmulx[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svmulx[_f16]_z(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FMULX Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FMULX Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FMULX Ztied2.H, Pg/M, Ztied2.H, Zop1.H
        /// </summary>
        public static unsafe Vector<half> MultiplyExtended(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }





        // Multiply-subtract long (bottom)

        /// <summary>
        /// svfloat32_t svmlslb[_f32](svfloat32_t op1, svfloat16_t op2, svfloat16_t op3)
        ///   FMLSLB Ztied1.S, Zop2.H, Zop3.H
        /// </summary>
        public static unsafe Vector<float> MultiplySubtractWideningLower(Vector<float> op1, Vector<half> op2, Vector<half> op3) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// svfloat32_t svmlslb_lane[_f32](svfloat32_t op1, svfloat16_t op2, svfloat16_t op3, uint64_t imm_index)
        ///   FMLSLB Ztied1.S, Zop2.H, Zop3.H[imm_index]
        /// </summary>
        public static unsafe Vector<float> MultiplySubtractWideningLower(Vector<float> op1, Vector<half> op2, Vector<half> op3, ulong imm_index) { throw new PlatformNotSupportedException(); }


        // Multiply-subtract long (top)

        /// <summary>
        /// svfloat32_t svmlslt[_f32](svfloat32_t op1, svfloat16_t op2, svfloat16_t op3)
        ///   FMLSLT Ztied1.S, Zop2.H, Zop3.H
        /// </summary>
        public static unsafe Vector<float> MultiplySubtractWideningUpper(Vector<float> op1, Vector<half> op2, Vector<half> op3) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// svfloat32_t svmlslt_lane[_f32](svfloat32_t op1, svfloat16_t op2, svfloat16_t op3, uint64_t imm_index)
        ///   FMLSLT Ztied1.S, Zop2.H, Zop3.H[imm_index]
        /// </summary>
        public static unsafe Vector<float> MultiplySubtractWideningUpper(Vector<float> op1, Vector<half> op2, Vector<half> op3, ulong imm_index) { throw new PlatformNotSupportedException(); }


        // Negate

        /// <summary>
        /// svfloat16_t svneg[_f16]_m(svfloat16_t inactive, svbool_t pg, svfloat16_t op)
        /// svfloat16_t svneg[_f16]_x(svbool_t pg, svfloat16_t op)
        /// svfloat16_t svneg[_f16]_z(svbool_t pg, svfloat16_t op)
        ///   FNEG Ztied.H, Pg/M, Zop.H
        ///   FNEG Ztied.H, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<half> Negate(Vector<half> value) { throw new PlatformNotSupportedException(); }




        // Count nonzero bits

        /// <summary>
        /// svuint16_t svcnt[_f16]_m(svuint16_t inactive, svbool_t pg, svfloat16_t op)
        /// svuint16_t svcnt[_f16]_x(svbool_t pg, svfloat16_t op)
        /// svuint16_t svcnt[_f16]_z(svbool_t pg, svfloat16_t op)
        ///   CNT Ztied.H, Pg/M, Zop.H
        ///   CNT Ztied.H, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<ushort> PopCount(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Reciprocal estimate

        /// <summary>
        /// svfloat16_t svrecpe[_f16](svfloat16_t op)
        ///   FRECPE Zresult.H, Zop.H
        /// </summary>
        public static unsafe Vector<half> ReciprocalEstimate(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Reciprocal exponent

        /// <summary>
        /// svfloat16_t svrecpx[_f16]_m(svfloat16_t inactive, svbool_t pg, svfloat16_t op)
        /// svfloat16_t svrecpx[_f16]_x(svbool_t pg, svfloat16_t op)
        /// svfloat16_t svrecpx[_f16]_z(svbool_t pg, svfloat16_t op)
        ///   FRECPX Ztied.H, Pg/M, Zop.H
        ///   FRECPX Ztied.H, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<half> ReciprocalExponent(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Reciprocal square root estimate

        /// <summary>
        /// svfloat16_t svrsqrte[_f16](svfloat16_t op)
        ///   FRSQRTE Zresult.H, Zop.H
        /// </summary>
        public static unsafe Vector<half> ReciprocalSqrtEstimate(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Reciprocal square root step

        /// <summary>
        /// svfloat16_t svrsqrts[_f16](svfloat16_t op1, svfloat16_t op2)
        ///   FRSQRTS Zresult.H, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> ReciprocalSqrtStep(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Reciprocal step

        /// <summary>
        /// svfloat16_t svrecps[_f16](svfloat16_t op1, svfloat16_t op2)
        ///   FRECPS Zresult.H, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> ReciprocalStep(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Reverse all elements

        /// <summary>
        /// svfloat16_t svrev[_f16](svfloat16_t op)
        ///   REV Zresult.H, Zop.H
        /// </summary>
        public static unsafe Vector<half> ReverseElement(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Round to nearest, ties away from zero

        /// <summary>
        /// svfloat16_t svrinta[_f16]_m(svfloat16_t inactive, svbool_t pg, svfloat16_t op)
        /// svfloat16_t svrinta[_f16]_x(svbool_t pg, svfloat16_t op)
        /// svfloat16_t svrinta[_f16]_z(svbool_t pg, svfloat16_t op)
        ///   FRINTA Ztied.H, Pg/M, Zop.H
        ///   FRINTA Ztied.H, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<half> RoundAwayFromZero(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Round to nearest, ties to even

        /// <summary>
        /// svfloat16_t svrintn[_f16]_m(svfloat16_t inactive, svbool_t pg, svfloat16_t op)
        /// svfloat16_t svrintn[_f16]_x(svbool_t pg, svfloat16_t op)
        /// svfloat16_t svrintn[_f16]_z(svbool_t pg, svfloat16_t op)
        ///   FRINTN Ztied.H, Pg/M, Zop.H
        ///   FRINTN Ztied.H, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<half> RoundToNearest(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Round towards -∞

        /// <summary>
        /// svfloat16_t svrintm[_f16]_m(svfloat16_t inactive, svbool_t pg, svfloat16_t op)
        /// svfloat16_t svrintm[_f16]_x(svbool_t pg, svfloat16_t op)
        /// svfloat16_t svrintm[_f16]_z(svbool_t pg, svfloat16_t op)
        ///   FRINTM Ztied.H, Pg/M, Zop.H
        ///   FRINTM Ztied.H, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<half> RoundToNegativeInfinity(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Round towards +∞

        /// <summary>
        /// svfloat16_t svrintp[_f16]_m(svfloat16_t inactive, svbool_t pg, svfloat16_t op)
        /// svfloat16_t svrintp[_f16]_x(svbool_t pg, svfloat16_t op)
        /// svfloat16_t svrintp[_f16]_z(svbool_t pg, svfloat16_t op)
        ///   FRINTP Ztied.H, Pg/M, Zop.H
        ///   FRINTP Ztied.H, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<half> RoundToPositiveInfinity(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Round towards zero

        /// <summary>
        /// svfloat16_t svrintz[_f16]_m(svfloat16_t inactive, svbool_t pg, svfloat16_t op)
        /// svfloat16_t svrintz[_f16]_x(svbool_t pg, svfloat16_t op)
        /// svfloat16_t svrintz[_f16]_z(svbool_t pg, svfloat16_t op)
        ///   FRINTZ Ztied.H, Pg/M, Zop.H
        ///   FRINTZ Ztied.H, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<half> RoundToZero(Vector<half> value) { throw new PlatformNotSupportedException(); }




        // Adjust exponent

        /// <summary>
        /// svfloat16_t svscale[_f16]_m(svbool_t pg, svfloat16_t op1, svint16_t op2)
        /// svfloat16_t svscale[_f16]_x(svbool_t pg, svfloat16_t op1, svint16_t op2)
        /// svfloat16_t svscale[_f16]_z(svbool_t pg, svfloat16_t op1, svint16_t op2)
        ///   FSCALE Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FSCALE Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> Scale(Vector<half> left, Vector<short> right) { throw new PlatformNotSupportedException(); }


        // Splice two vectors under predicate control

        /// <summary>
        /// svfloat16_t svsplice[_f16](svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   SPLICE Ztied1.H, Pg, Ztied1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> Splice(Vector<half> mask, Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Square root

        /// <summary>
        /// svfloat16_t svsqrt[_f16]_m(svfloat16_t inactive, svbool_t pg, svfloat16_t op)
        /// svfloat16_t svsqrt[_f16]_x(svbool_t pg, svfloat16_t op)
        /// svfloat16_t svsqrt[_f16]_z(svbool_t pg, svfloat16_t op)
        ///   FSQRT Ztied.H, Pg/M, Zop.H
        ///   FSQRT Ztied.H, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<half> Sqrt(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Non-truncating store

        /// <summary>
        /// void svst1[_f16](svbool_t pg, float16_t *base, svfloat16_t data)
        ///   ST1H Zdata.H, Pg, [Xarray, Xindex, LSL #1]
        ///   ST1H Zdata.H, Pg, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe void Store(Vector<half> mask, half* address, Vector<half> data) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// void svst2[_f16](svbool_t pg, float16_t *base, svfloat16x2_t data)
        ///   ST2H {Zdata0.H, Zdata1.H}, Pg, [Xarray, Xindex, LSL #1]
        ///   ST2H {Zdata0.H, Zdata1.H}, Pg, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe void Store(Vector<half> mask, half* address, (Vector<half> Value1, Vector<half> Value2) data) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// void svst3[_f16](svbool_t pg, float16_t *base, svfloat16x3_t data)
        ///   ST3H {Zdata0.H - Zdata2.H}, Pg, [Xarray, Xindex, LSL #1]
        ///   ST3H {Zdata0.H - Zdata2.H}, Pg, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe void Store(Vector<half> mask, half* address, (Vector<half> Value1, Vector<half> Value2, Vector<half> Value3) data) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// void svst4[_f16](svbool_t pg, float16_t *base, svfloat16x4_t data)
        ///   ST4H {Zdata0.H - Zdata3.H}, Pg, [Xarray, Xindex, LSL #1]
        ///   ST4H {Zdata0.H - Zdata3.H}, Pg, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe void Store(Vector<half> mask, half* address, (Vector<half> Value1, Vector<half> Value2, Vector<half> Value3, Vector<half> Value4) data) { throw new PlatformNotSupportedException(); }


        // Non-truncating store, non-temporal

        /// <summary>
        /// void svstnt1[_f16](svbool_t pg, float16_t *base, svfloat16_t data)
        ///   STNT1H Zdata.H, Pg, [Xarray, Xindex, LSL #1]
        ///   STNT1H Zdata.H, Pg, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe void StoreNonTemporal(Vector<half> mask, half* address, Vector<half> data) { throw new PlatformNotSupportedException(); }


        // Subtract

        /// <summary>
        /// svfloat16_t svsub[_f16]_m(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svsub[_f16]_x(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        /// svfloat16_t svsub[_f16]_z(svbool_t pg, svfloat16_t op1, svfloat16_t op2)
        ///   FSUB Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FSUB Ztied1.H, Pg/M, Ztied1.H, Zop2.H
        ///   FSUBR Ztied2.H, Pg/M, Ztied2.H, Zop1.H
        ///   FSUB Zresult.H, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> Subtract(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }



        // Interleave even elements from two inputs

        /// <summary>
        /// svfloat16_t svtrn1[_f16](svfloat16_t op1, svfloat16_t op2)
        ///   TRN1 Zresult.H, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> TransposeEven(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Interleave odd elements from two inputs

        /// <summary>
        /// svfloat16_t svtrn2[_f16](svfloat16_t op1, svfloat16_t op2)
        ///   TRN2 Zresult.H, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> TransposeOdd(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Trigonometric multiply-add coefficient

        /// <summary>
        /// svfloat16_t svtmad[_f16](svfloat16_t op1, svfloat16_t op2, uint64_t imm3)
        ///   FTMAD Ztied1.H, Ztied1.H, Zop2.H, #imm3
        /// </summary>
        public static unsafe Vector<half> TrigonometricMultiplyAddCoefficient(Vector<half> left, Vector<half> right, [ConstantExpected] byte control) { throw new PlatformNotSupportedException(); }


        // Trigonometric select coefficient

        /// <summary>
        /// svfloat16_t svtssel[_f16](svfloat16_t op1, svuint16_t op2)
        ///   FTSSEL Zresult.H, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> TrigonometricSelectCoefficient(Vector<half> value, Vector<ushort> selector) { throw new PlatformNotSupportedException(); }


        // Trigonometric starting value

        /// <summary>
        /// svfloat16_t svtsmul[_f16](svfloat16_t op1, svuint16_t op2)
        ///   FTSMUL Zresult.H, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> TrigonometricStartingValue(Vector<half> value, Vector<ushort> sign) { throw new PlatformNotSupportedException(); }


        // Concatenate even elements from two inputs

        /// <summary>
        /// svfloat16_t svuzp1[_f16](svfloat16_t op1, svfloat16_t op2)
        ///   UZP1 Zresult.H, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> UnzipEven(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Concatenate odd elements from two inputs

        /// <summary>
        /// svfloat16_t svuzp2[_f16](svfloat16_t op1, svfloat16_t op2)
        ///   UZP2 Zresult.H, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> UnzipOdd(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Up convert long (top)

        /// <summary>
        /// svfloat32_t svcvtlt_f32[_f16]_m(svfloat32_t inactive, svbool_t pg, svfloat16_t op)
        /// svfloat32_t svcvtlt_f32[_f16]_x(svbool_t pg, svfloat16_t op)
        ///   FCVTLT Ztied.S, Pg/M, Zop.H
        ///   FCVTLT Ztied.S, Pg/M, Ztied.H
        /// </summary>
        public static unsafe Vector<float> UpConvertWideningUpper(Vector<half> value) { throw new PlatformNotSupportedException(); }


        // Table lookup in single-vector table

        /// <summary>
        /// svfloat16_t svtbl[_f16](svfloat16_t data, svuint16_t indices)
        ///   TBL Zresult.H, Zdata.H, Zindices.H
        /// </summary>
        public static unsafe Vector<half> VectorTableLookup(Vector<half> data, Vector<ushort> indices) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// svfloat16_t svtbl2[_f16](svfloat16x2_t data, svuint16_t indices)
        ///   TBL Zresult.H, {Zdata0.H, Zdata1.H}, Zindices.H
        /// </summary>
        public static unsafe Vector<half> VectorTableLookup((Vector<half> data1, Vector<half> data2), Vector<ushort> indices) { throw new PlatformNotSupportedException(); }


        // Table lookup in single-vector table (merging)

        /// <summary>
        /// svfloat16_t svtbx[_f16](svfloat16_t fallback, svfloat16_t data, svuint16_t indices)
        ///   TBX Ztied.H, Zdata.H, Zindices.H
        /// </summary>
        public static unsafe Vector<half> VectorTableLookupExtension(Vector<half> fallback, Vector<half> data, Vector<ushort> indices) { throw new PlatformNotSupportedException(); }


        // Interleave elements from high halves of two inputs

        /// <summary>
        /// svfloat16_t svzip2[_f16](svfloat16_t op1, svfloat16_t op2)
        ///   ZIP2 Zresult.H, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> ZipHigh(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }


        // Interleave elements from low halves of two inputs

        /// <summary>
        /// svfloat16_t svzip1[_f16](svfloat16_t op1, svfloat16_t op2)
        ///   ZIP1 Zresult.H, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<half> ZipLow(Vector<half> left, Vector<half> right) { throw new PlatformNotSupportedException(); }

    }
}

