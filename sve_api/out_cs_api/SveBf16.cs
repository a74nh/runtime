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
    public abstract class SveBf16 : AdvSimd
    {
        internal SveBf16() { }

        public static new bool IsSupported { get => IsSupported; }

        [Intrinsic]
        public new abstract class Arm64 : AdvSimd.Arm64
        {
            internal Arm64() { }

            public static new bool IsSupported { get => IsSupported; }
        }

        ///  Bfloat16DotProduct : BFloat16 dot product

        /// <summary>
        /// svfloat32_t svbfdot[_f32](svfloat32_t op1, svbfloat16_t op2, svbfloat16_t op3)
        ///   BFDOT Ztied1.S, Zop2.H, Zop3.H
        ///   MOVPRFX Zresult, Zop1; BFDOT Zresult.S, Zop2.H, Zop3.H
        /// </summary>
        public static unsafe Vector<float> Bfloat16DotProduct(Vector<float> addend, Vector<bfloat16> left, Vector<bfloat16> right) => Bfloat16DotProduct(addend, left, right);


        ///  Bfloat16MatrixMultiplyAccumulate : BFloat16 matrix multiply-accumulate

        /// <summary>
        /// svfloat32_t svbfmmla[_f32](svfloat32_t op1, svbfloat16_t op2, svbfloat16_t op3)
        ///   BFMMLA Ztied1.S, Zop2.H, Zop3.H
        ///   MOVPRFX Zresult, Zop1; BFMMLA Zresult.S, Zop2.H, Zop3.H
        /// </summary>
        public static unsafe Vector<float> Bfloat16MatrixMultiplyAccumulate(Vector<float> op1, Vector<bfloat16> op2, Vector<bfloat16> op3) => Bfloat16MatrixMultiplyAccumulate(op1, op2, op3);


        ///  Bfloat16MultiplyAddWideningToSinglePrecisionLower : BFloat16 multiply-add long to single-precision (bottom)

        /// <summary>
        /// svfloat32_t svbfmlalb[_f32](svfloat32_t op1, svbfloat16_t op2, svbfloat16_t op3)
        ///   BFMLALB Ztied1.S, Zop2.H, Zop3.H
        ///   MOVPRFX Zresult, Zop1; BFMLALB Zresult.S, Zop2.H, Zop3.H
        /// </summary>
        public static unsafe Vector<float> Bfloat16MultiplyAddWideningToSinglePrecisionLower(Vector<float> op1, Vector<bfloat16> op2, Vector<bfloat16> op3) => Bfloat16MultiplyAddWideningToSinglePrecisionLower(op1, op2, op3);

        /// <summary>
        /// svfloat32_t svbfmlalb_lane[_f32](svfloat32_t op1, svbfloat16_t op2, svbfloat16_t op3, uint64_t imm_index)
        ///   BFMLALB Ztied1.S, Zop2.H, Zop3.H[imm_index]
        ///   MOVPRFX Zresult, Zop1; BFMLALB Zresult.S, Zop2.H, Zop3.H[imm_index]
        /// </summary>
        public static unsafe Vector<float> Bfloat16MultiplyAddWideningToSinglePrecisionLower(Vector<float> op1, Vector<bfloat16> op2, Vector<bfloat16> op3, ulong imm_index) => Bfloat16MultiplyAddWideningToSinglePrecisionLower(op1, op2, op3, imm_index);


        ///  Bfloat16MultiplyAddWideningToSinglePrecisionUpper : BFloat16 multiply-add long to single-precision (top)

        /// <summary>
        /// svfloat32_t svbfmlalt[_f32](svfloat32_t op1, svbfloat16_t op2, svbfloat16_t op3)
        ///   BFMLALT Ztied1.S, Zop2.H, Zop3.H
        ///   MOVPRFX Zresult, Zop1; BFMLALT Zresult.S, Zop2.H, Zop3.H
        /// </summary>
        public static unsafe Vector<float> Bfloat16MultiplyAddWideningToSinglePrecisionUpper(Vector<float> op1, Vector<bfloat16> op2, Vector<bfloat16> op3) => Bfloat16MultiplyAddWideningToSinglePrecisionUpper(op1, op2, op3);

        /// <summary>
        /// svfloat32_t svbfmlalt_lane[_f32](svfloat32_t op1, svbfloat16_t op2, svbfloat16_t op3, uint64_t imm_index)
        ///   BFMLALT Ztied1.S, Zop2.H, Zop3.H[imm_index]
        ///   MOVPRFX Zresult, Zop1; BFMLALT Zresult.S, Zop2.H, Zop3.H[imm_index]
        /// </summary>
        public static unsafe Vector<float> Bfloat16MultiplyAddWideningToSinglePrecisionUpper(Vector<float> op1, Vector<bfloat16> op2, Vector<bfloat16> op3, ulong imm_index) => Bfloat16MultiplyAddWideningToSinglePrecisionUpper(op1, op2, op3, imm_index);


        ///  ConcatenateEvenInt128FromTwoInputs : Concatenate even quadwords from two inputs

        /// <summary>
        /// svbfloat16_t svuzp1q[_bf16](svbfloat16_t op1, svbfloat16_t op2)
        ///   UZP1 Zresult.Q, Zop1.Q, Zop2.Q
        /// </summary>
        public static unsafe Vector<bfloat16> ConcatenateEvenInt128FromTwoInputs(Vector<bfloat16> left, Vector<bfloat16> right) => ConcatenateEvenInt128FromTwoInputs(left, right);


        ///  ConcatenateOddInt128FromTwoInputs : Concatenate odd quadwords from two inputs

        /// <summary>
        /// svbfloat16_t svuzp2q[_bf16](svbfloat16_t op1, svbfloat16_t op2)
        ///   UZP2 Zresult.Q, Zop1.Q, Zop2.Q
        /// </summary>
        public static unsafe Vector<bfloat16> ConcatenateOddInt128FromTwoInputs(Vector<bfloat16> left, Vector<bfloat16> right) => ConcatenateOddInt128FromTwoInputs(left, right);


        ///  ConditionalExtractAfterLastActiveElement : Conditionally extract element after last

        /// <summary>
        /// svbfloat16_t svclasta[_bf16](svbool_t pg, svbfloat16_t fallback, svbfloat16_t data)
        ///   CLASTA Ztied.H, Pg, Ztied.H, Zdata.H
        ///   MOVPRFX Zresult, Zfallback; CLASTA Zresult.H, Pg, Zresult.H, Zdata.H
        /// </summary>
        public static unsafe Vector<bfloat16> ConditionalExtractAfterLastActiveElement(Vector<bfloat16> mask, Vector<bfloat16> defaultValue, Vector<bfloat16> data) => ConditionalExtractAfterLastActiveElement(mask, defaultValue, data);

        /// <summary>
        /// svbfloat16_t svclasta[_bf16](svbool_t pg, svbfloat16_t fallback, svbfloat16_t data)
        ///   CLASTA Ztied.H, Pg, Ztied.H, Zdata.H
        ///   MOVPRFX Zresult, Zfallback; CLASTA Zresult.H, Pg, Zresult.H, Zdata.H
        /// bfloat16_t svclasta[_n_bf16](svbool_t pg, bfloat16_t fallback, svbfloat16_t data)
        ///   CLASTA Wtied, Pg, Wtied, Zdata.H
        ///   CLASTA Htied, Pg, Htied, Zdata.H
        /// </summary>
        public static unsafe bfloat16 ConditionalExtractAfterLastActiveElement(Vector<bfloat16> mask, bfloat16 defaultValues, Vector<bfloat16> data) => ConditionalExtractAfterLastActiveElement(mask, defaultValues, data);


        ///  ConditionalExtractAfterLastActiveElementAndReplicate : Conditionally extract element after last

        /// <summary>
        /// svbfloat16_t svclasta[_bf16](svbool_t pg, svbfloat16_t fallback, svbfloat16_t data)
        ///   CLASTA Ztied.H, Pg, Ztied.H, Zdata.H
        ///   MOVPRFX Zresult, Zfallback; CLASTA Zresult.H, Pg, Zresult.H, Zdata.H
        /// </summary>
        public static unsafe Vector<bfloat16> ConditionalExtractAfterLastActiveElementAndReplicate(Vector<bfloat16> mask, Vector<bfloat16> defaultScalar, Vector<bfloat16> data) => ConditionalExtractAfterLastActiveElementAndReplicate(mask, defaultScalar, data);


        ///  ConditionalExtractLastActiveElement : Conditionally extract last element

        /// <summary>
        /// svbfloat16_t svclastb[_bf16](svbool_t pg, svbfloat16_t fallback, svbfloat16_t data)
        ///   CLASTB Ztied.H, Pg, Ztied.H, Zdata.H
        ///   MOVPRFX Zresult, Zfallback; CLASTB Zresult.H, Pg, Zresult.H, Zdata.H
        /// </summary>
        public static unsafe Vector<bfloat16> ConditionalExtractLastActiveElement(Vector<bfloat16> mask, Vector<bfloat16> defaultValue, Vector<bfloat16> data) => ConditionalExtractLastActiveElement(mask, defaultValue, data);

        /// <summary>
        /// svbfloat16_t svclastb[_bf16](svbool_t pg, svbfloat16_t fallback, svbfloat16_t data)
        ///   CLASTB Ztied.H, Pg, Ztied.H, Zdata.H
        ///   MOVPRFX Zresult, Zfallback; CLASTB Zresult.H, Pg, Zresult.H, Zdata.H
        /// bfloat16_t svclastb[_n_bf16](svbool_t pg, bfloat16_t fallback, svbfloat16_t data)
        ///   CLASTB Wtied, Pg, Wtied, Zdata.H
        ///   CLASTB Htied, Pg, Htied, Zdata.H
        /// </summary>
        public static unsafe bfloat16 ConditionalExtractLastActiveElement(Vector<bfloat16> mask, bfloat16 defaultValues, Vector<bfloat16> data) => ConditionalExtractLastActiveElement(mask, defaultValues, data);


        ///  ConditionalExtractLastActiveElementAndReplicate : Conditionally extract last element

        /// <summary>
        /// svbfloat16_t svclastb[_bf16](svbool_t pg, svbfloat16_t fallback, svbfloat16_t data)
        ///   CLASTB Ztied.H, Pg, Ztied.H, Zdata.H
        ///   MOVPRFX Zresult, Zfallback; CLASTB Zresult.H, Pg, Zresult.H, Zdata.H
        /// </summary>
        public static unsafe Vector<bfloat16> ConditionalExtractLastActiveElementAndReplicate(Vector<bfloat16> mask, Vector<bfloat16> fallback, Vector<bfloat16> data) => ConditionalExtractLastActiveElementAndReplicate(mask, fallback, data);


        ///  ConditionalSelect : Conditionally select elements

        /// <summary>
        /// svbfloat16_t svsel[_bf16](svbool_t pg, svbfloat16_t op1, svbfloat16_t op2)
        ///   SEL Zresult.H, Pg, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<bfloat16> ConditionalSelect(Vector<bfloat16> mask, Vector<bfloat16> left, Vector<bfloat16> right) => ConditionalSelect(mask, left, right);


        ///  ConvertToBFloat16 : Floating-point convert

        /// <summary>
        /// svbfloat16_t svcvt_bf16[_f32]_m(svbfloat16_t inactive, svbool_t pg, svfloat32_t op)
        ///   BFCVT Ztied.H, Pg/M, Zop.S
        ///   MOVPRFX Zresult, Zinactive; BFCVT Zresult.H, Pg/M, Zop.S
        /// svbfloat16_t svcvt_bf16[_f32]_x(svbool_t pg, svfloat32_t op)
        ///   BFCVT Ztied.H, Pg/M, Ztied.S
        ///   MOVPRFX Zresult, Zop; BFCVT Zresult.H, Pg/M, Zop.S
        /// svbfloat16_t svcvt_bf16[_f32]_z(svbool_t pg, svfloat32_t op)
        ///   MOVPRFX Zresult.S, Pg/Z, Zop.S; BFCVT Zresult.H, Pg/M, Zop.S
        /// </summary>
        public static unsafe Vector<bfloat16> ConvertToBFloat16(Vector<float> value) => ConvertToBFloat16(value);



        ///  CreateFalseMaskBFloat16 : Set all predicate elements to false

        /// <summary>
        /// svbool_t svpfalse[_b]()
        ///   PFALSE Presult.B
        /// </summary>
        public static unsafe Vector<bfloat16> CreateFalseMaskBFloat16() => CreateFalseMaskBFloat16();


        ///  CreateTrueMaskBFloat16 : Set predicate elements to true

        /// <summary>
        /// svbool_t svptrue_pat_b8(enum svpattern pattern)
        ///   PTRUE Presult.B, pattern
        /// </summary>
        public static unsafe Vector<bfloat16> CreateTrueMaskBFloat16([ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All) => CreateTrueMaskBFloat16(pattern);


        ///  CreateWhileReadAfterWriteMask : While free of read-after-write conflicts

        /// <summary>
        /// svbool_t svwhilerw[_bf16](const bfloat16_t *op1, const bfloat16_t *op2)
        ///   WHILERW Presult.H, Xop1, Xop2
        /// </summary>
        public static unsafe Vector<bfloat16> CreateWhileReadAfterWriteMask(bfloat16* left, bfloat16* right) => CreateWhileReadAfterWriteMask(left, right);


        ///  CreateWhileWriteAfterReadMask : While free of write-after-read conflicts

        /// <summary>
        /// svbool_t svwhilewr[_bf16](const bfloat16_t *op1, const bfloat16_t *op2)
        ///   WHILEWR Presult.H, Xop1, Xop2
        /// </summary>
        public static unsafe Vector<bfloat16> CreateWhileWriteAfterReadMask(bfloat16* left, bfloat16* right) => CreateWhileWriteAfterReadMask(left, right);


        ///  DotProductBySelectedScalar : BFloat16 dot product

        /// <summary>
        /// svfloat32_t svbfdot_lane[_f32](svfloat32_t op1, svbfloat16_t op2, svbfloat16_t op3, uint64_t imm_index)
        ///   BFDOT Ztied1.S, Zop2.H, Zop3.H[imm_index]
        ///   MOVPRFX Zresult, Zop1; BFDOT Zresult.S, Zop2.H, Zop3.H[imm_index]
        /// </summary>
        public static unsafe Vector<float> DotProductBySelectedScalar(Vector<float> addend, Vector<bfloat16> left, Vector<bfloat16> right, [ConstantExpected] byte rightIndex) => DotProductBySelectedScalar(addend, left, right, rightIndex);


        ///  DownConvertNarrowingUpper : Down convert and narrow (top)

        /// <summary>
        /// svbfloat16_t svcvtnt_bf16[_f32]_m(svbfloat16_t even, svbool_t pg, svfloat32_t op)
        ///   BFCVTNT Ztied.H, Pg/M, Zop.S
        /// svbfloat16_t svcvtnt_bf16[_f32]_x(svbfloat16_t even, svbool_t pg, svfloat32_t op)
        ///   BFCVTNT Ztied.H, Pg/M, Zop.S
        /// </summary>
        public static unsafe Vector<bfloat16> DownConvertNarrowingUpper(Vector<float> value) => DownConvertNarrowingUpper(value);


        ///  DuplicateSelectedScalarToVector : Broadcast a scalar value

        /// <summary>
        /// svbfloat16_t svdup_lane[_bf16](svbfloat16_t data, uint16_t index)
        ///   DUP Zresult.H, Zdata.H[index]
        ///   TBL Zresult.H, Zdata.H, Zindex.H
        /// svbfloat16_t svdupq_lane[_bf16](svbfloat16_t data, uint64_t index)
        ///   DUP Zresult.Q, Zdata.Q[index]
        ///   TBL Zresult.D, Zdata.D, Zindices_d.D
        /// </summary>
        public static unsafe Vector<bfloat16> DuplicateSelectedScalarToVector(Vector<bfloat16> data, [ConstantExpected] byte index) => DuplicateSelectedScalarToVector(data, index);


        ///  ExtractAfterLastScalar : Extract element after last

        /// <summary>
        /// bfloat16_t svlasta[_bf16](svbool_t pg, svbfloat16_t op)
        ///   LASTA Wresult, Pg, Zop.H
        ///   LASTA Hresult, Pg, Zop.H
        /// </summary>
        public static unsafe bfloat16 ExtractAfterLastScalar(Vector<bfloat16> value) => ExtractAfterLastScalar(value);


        ///  ExtractAfterLastVector : Extract element after last

        /// <summary>
        /// bfloat16_t svlasta[_bf16](svbool_t pg, svbfloat16_t op)
        ///   LASTA Wresult, Pg, Zop.H
        ///   LASTA Hresult, Pg, Zop.H
        /// </summary>
        public static unsafe Vector<bfloat16> ExtractAfterLastVector(Vector<bfloat16> value) => ExtractAfterLastVector(value);


        ///  ExtractLastScalar : Extract last element

        /// <summary>
        /// bfloat16_t svlastb[_bf16](svbool_t pg, svbfloat16_t op)
        ///   LASTB Wresult, Pg, Zop.H
        ///   LASTB Hresult, Pg, Zop.H
        /// </summary>
        public static unsafe bfloat16 ExtractLastScalar(Vector<bfloat16> value) => ExtractLastScalar(value);


        ///  ExtractLastVector : Extract last element

        /// <summary>
        /// bfloat16_t svlastb[_bf16](svbool_t pg, svbfloat16_t op)
        ///   LASTB Wresult, Pg, Zop.H
        ///   LASTB Hresult, Pg, Zop.H
        /// </summary>
        public static unsafe Vector<bfloat16> ExtractLastVector(Vector<bfloat16> value) => ExtractLastVector(value);


        ///  ExtractVector : Extract vector from pair of vectors

        /// <summary>
        /// svbfloat16_t svext[_bf16](svbfloat16_t op1, svbfloat16_t op2, uint64_t imm3)
        ///   EXT Ztied1.B, Ztied1.B, Zop2.B, #imm3 * 2
        ///   MOVPRFX Zresult, Zop1; EXT Zresult.B, Zresult.B, Zop2.B, #imm3 * 2
        /// </summary>
        public static unsafe Vector<bfloat16> ExtractVector(Vector<bfloat16> upper, Vector<bfloat16> lower, [ConstantExpected] byte index) => ExtractVector(upper, lower, index);


        ///  GetActiveElementCount : Count set predicate bits

        /// <summary>
        /// uint64_t svcntp_b8(svbool_t pg, svbool_t op)
        ///   CNTP Xresult, Pg, Pop.B
        /// </summary>
        public static unsafe ulong GetActiveElementCount(Vector<bfloat16> mask, Vector<bfloat16> from) => GetActiveElementCount(mask, from);


        ///  InsertIntoShiftedVector : Insert scalar into shifted vector

        /// <summary>
        /// svbfloat16_t svinsr[_n_bf16](svbfloat16_t op1, bfloat16_t op2)
        ///   INSR Ztied1.H, Wop2
        ///   INSR Ztied1.H, Hop2
        /// </summary>
        public static unsafe Vector<bfloat16> InsertIntoShiftedVector(Vector<bfloat16> left, bfloat16 right) => InsertIntoShiftedVector(left, right);


        ///  InterleaveEvenInt128FromTwoInputs : Interleave even quadwords from two inputs

        /// <summary>
        /// svbfloat16_t svtrn1q[_bf16](svbfloat16_t op1, svbfloat16_t op2)
        ///   TRN1 Zresult.Q, Zop1.Q, Zop2.Q
        /// </summary>
        public static unsafe Vector<bfloat16> InterleaveEvenInt128FromTwoInputs(Vector<bfloat16> left, Vector<bfloat16> right) => InterleaveEvenInt128FromTwoInputs(left, right);


        ///  InterleaveInt128FromHighHalvesOfTwoInputs : Interleave quadwords from high halves of two inputs

        /// <summary>
        /// svbfloat16_t svzip2q[_bf16](svbfloat16_t op1, svbfloat16_t op2)
        ///   ZIP2 Zresult.Q, Zop1.Q, Zop2.Q
        /// </summary>
        public static unsafe Vector<bfloat16> InterleaveInt128FromHighHalvesOfTwoInputs(Vector<bfloat16> left, Vector<bfloat16> right) => InterleaveInt128FromHighHalvesOfTwoInputs(left, right);


        ///  InterleaveInt128FromLowHalvesOfTwoInputs : Interleave quadwords from low halves of two inputs

        /// <summary>
        /// svbfloat16_t svzip1q[_bf16](svbfloat16_t op1, svbfloat16_t op2)
        ///   ZIP1 Zresult.Q, Zop1.Q, Zop2.Q
        /// </summary>
        public static unsafe Vector<bfloat16> InterleaveInt128FromLowHalvesOfTwoInputs(Vector<bfloat16> left, Vector<bfloat16> right) => InterleaveInt128FromLowHalvesOfTwoInputs(left, right);


        ///  InterleaveOddInt128FromTwoInputs : Interleave odd quadwords from two inputs

        /// <summary>
        /// svbfloat16_t svtrn2q[_bf16](svbfloat16_t op1, svbfloat16_t op2)
        ///   TRN2 Zresult.Q, Zop1.Q, Zop2.Q
        /// </summary>
        public static unsafe Vector<bfloat16> InterleaveOddInt128FromTwoInputs(Vector<bfloat16> left, Vector<bfloat16> right) => InterleaveOddInt128FromTwoInputs(left, right);


        ///  LoadVector : Unextended load

        /// <summary>
        /// svbfloat16_t svld1[_bf16](svbool_t pg, const bfloat16_t *base)
        ///   LD1H Zresult.H, Pg/Z, [Xarray, Xindex, LSL #1]
        ///   LD1H Zresult.H, Pg/Z, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe Vector<bfloat16> LoadVector(Vector<bfloat16> mask, bfloat16* address) => LoadVector(mask, address);


        ///  LoadVector128AndReplicateToVector : Load and replicate 128 bits of data

        /// <summary>
        /// svbfloat16_t svld1rq[_bf16](svbool_t pg, const bfloat16_t *base)
        ///   LD1RQH Zresult.H, Pg/Z, [Xarray, Xindex, LSL #1]
        ///   LD1RQH Zresult.H, Pg/Z, [Xarray, #index * 2]
        ///   LD1RQH Zresult.H, Pg/Z, [Xbase, #0]
        /// </summary>
        public static unsafe Vector<bfloat16> LoadVector128AndReplicateToVector(Vector<bfloat16> mask, bfloat16* address) => LoadVector128AndReplicateToVector(mask, address);


        ///  LoadVector256AndReplicateToVector : Load and replicate 256 bits of data

        /// <summary>
        /// svbfloat16_t svld1ro[_bf16](svbool_t pg, const bfloat16_t *base)
        ///   LD1ROH Zresult.H, Pg/Z, [Xarray, Xindex, LSL #1]
        ///   LD1ROH Zresult.H, Pg/Z, [Xarray, #index * 2]
        ///   LD1ROH Zresult.H, Pg/Z, [Xbase, #0]
        /// </summary>
        public static unsafe Vector<bfloat16> LoadVector256AndReplicateToVector(Vector<bfloat16> mask, bfloat16* address) => LoadVector256AndReplicateToVector(mask, address);


        ///  LoadVectorFirstFaulting : Unextended load, first-faulting

        /// <summary>
        /// svbfloat16_t svldff1[_bf16](svbool_t pg, const bfloat16_t *base)
        ///   LDFF1H Zresult.H, Pg/Z, [Xarray, Xindex, LSL #1]
        ///   LDFF1H Zresult.H, Pg/Z, [Xbase, XZR, LSL #1]
        /// </summary>
        public static unsafe Vector<bfloat16> LoadVectorFirstFaulting(Vector<bfloat16> mask, bfloat16* address) => LoadVectorFirstFaulting(mask, address);


        ///  LoadVectorNonFaulting : Unextended load, non-faulting

        /// <summary>
        /// svbfloat16_t svldnf1[_bf16](svbool_t pg, const bfloat16_t *base)
        ///   LDNF1H Zresult.H, Pg/Z, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe Vector<bfloat16> LoadVectorNonFaulting(bfloat16* address) => LoadVectorNonFaulting(address);


        ///  LoadVectorNonTemporal : Unextended load, non-temporal

        /// <summary>
        /// svbfloat16_t svldnt1[_bf16](svbool_t pg, const bfloat16_t *base)
        ///   LDNT1H Zresult.H, Pg/Z, [Xarray, Xindex, LSL #1]
        ///   LDNT1H Zresult.H, Pg/Z, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe Vector<bfloat16> LoadVectorNonTemporal(Vector<bfloat16> mask, bfloat16* address) => LoadVectorNonTemporal(mask, address);


        ///  LoadVectorx2 : Load two-element tuples into two vectors

        /// <summary>
        /// svbfloat16x2_t svld2[_bf16](svbool_t pg, const bfloat16_t *base)
        ///   LD2H {Zresult0.H, Zresult1.H}, Pg/Z, [Xarray, Xindex, LSL #1]
        ///   LD2H {Zresult0.H, Zresult1.H}, Pg/Z, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe (Vector<bfloat16>, Vector<bfloat16>) LoadVectorx2(Vector<bfloat16> mask, bfloat16* address) => LoadVectorx2(mask, address);


        ///  LoadVectorx3 : Load three-element tuples into three vectors

        /// <summary>
        /// svbfloat16x3_t svld3[_bf16](svbool_t pg, const bfloat16_t *base)
        ///   LD3H {Zresult0.H - Zresult2.H}, Pg/Z, [Xarray, Xindex, LSL #1]
        ///   LD3H {Zresult0.H - Zresult2.H}, Pg/Z, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe (Vector<bfloat16>, Vector<bfloat16>, Vector<bfloat16>) LoadVectorx3(Vector<bfloat16> mask, bfloat16* address) => LoadVectorx3(mask, address);


        ///  LoadVectorx4 : Load four-element tuples into four vectors

        /// <summary>
        /// svbfloat16x4_t svld4[_bf16](svbool_t pg, const bfloat16_t *base)
        ///   LD4H {Zresult0.H - Zresult3.H}, Pg/Z, [Xarray, Xindex, LSL #1]
        ///   LD4H {Zresult0.H - Zresult3.H}, Pg/Z, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe (Vector<bfloat16>, Vector<bfloat16>, Vector<bfloat16>, Vector<bfloat16>) LoadVectorx4(Vector<bfloat16> mask, bfloat16* address) => LoadVectorx4(mask, address);


        ///  PopCount : Count nonzero bits

        /// <summary>
        /// svuint16_t svcnt[_bf16]_m(svuint16_t inactive, svbool_t pg, svbfloat16_t op)
        ///   CNT Ztied.H, Pg/M, Zop.H
        ///   MOVPRFX Zresult, Zinactive; CNT Zresult.H, Pg/M, Zop.H
        /// svuint16_t svcnt[_bf16]_x(svbool_t pg, svbfloat16_t op)
        ///   CNT Ztied.H, Pg/M, Ztied.H
        ///   MOVPRFX Zresult, Zop; CNT Zresult.H, Pg/M, Zop.H
        /// svuint16_t svcnt[_bf16]_z(svbool_t pg, svbfloat16_t op)
        ///   MOVPRFX Zresult.H, Pg/Z, Zop.H; CNT Zresult.H, Pg/M, Zop.H
        /// </summary>
        public static unsafe Vector<ushort> PopCount(Vector<bfloat16> value) => PopCount(value);


        ///  ReverseElement : Reverse all elements

        /// <summary>
        /// svbfloat16_t svrev[_bf16](svbfloat16_t op)
        ///   REV Zresult.H, Zop.H
        /// </summary>
        public static unsafe Vector<bfloat16> ReverseElement(Vector<bfloat16> value) => ReverseElement(value);


        ///  Splice : Splice two vectors under predicate control

        /// <summary>
        /// svbfloat16_t svsplice[_bf16](svbool_t pg, svbfloat16_t op1, svbfloat16_t op2)
        ///   SPLICE Ztied1.H, Pg, Ztied1.H, Zop2.H
        ///   MOVPRFX Zresult, Zop1; SPLICE Zresult.H, Pg, Zresult.H, Zop2.H
        /// </summary>
        public static unsafe Vector<bfloat16> Splice(Vector<bfloat16> mask, Vector<bfloat16> left, Vector<bfloat16> right) => Splice(mask, left, right);


        ///  Store : Non-truncating store

        /// <summary>
        /// void svst1[_bf16](svbool_t pg, bfloat16_t *base, svbfloat16_t data)
        ///   ST1H Zdata.H, Pg, [Xarray, Xindex, LSL #1]
        ///   ST1H Zdata.H, Pg, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe void Store(Vector<bfloat16> mask, bfloat16* address, Vector<bfloat16> data) => Store(mask, address, data);

        /// <summary>
        /// void svst2[_bf16](svbool_t pg, bfloat16_t *base, svbfloat16x2_t data)
        ///   ST2H {Zdata0.H, Zdata1.H}, Pg, [Xarray, Xindex, LSL #1]
        ///   ST2H {Zdata0.H, Zdata1.H}, Pg, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe void Store(Vector<bfloat16> mask, bfloat16* address, (Vector<bfloat16> Value1, Vector<bfloat16> Value2) data) => Store(mask, address, Value1,);

        /// <summary>
        /// void svst3[_bf16](svbool_t pg, bfloat16_t *base, svbfloat16x3_t data)
        ///   ST3H {Zdata0.H - Zdata2.H}, Pg, [Xarray, Xindex, LSL #1]
        ///   ST3H {Zdata0.H - Zdata2.H}, Pg, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe void Store(Vector<bfloat16> mask, bfloat16* address, (Vector<bfloat16> Value1, Vector<bfloat16> Value2, Vector<bfloat16> Value3) data) => Store(mask, address, Value1,);

        /// <summary>
        /// void svst4[_bf16](svbool_t pg, bfloat16_t *base, svbfloat16x4_t data)
        ///   ST4H {Zdata0.H - Zdata3.H}, Pg, [Xarray, Xindex, LSL #1]
        ///   ST4H {Zdata0.H - Zdata3.H}, Pg, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe void Store(Vector<bfloat16> mask, bfloat16* address, (Vector<bfloat16> Value1, Vector<bfloat16> Value2, Vector<bfloat16> Value3, Vector<bfloat16> Value4) data) => Store(mask, address, Value1,);


        ///  StoreNonTemporal : Non-truncating store, non-temporal

        /// <summary>
        /// void svstnt1[_bf16](svbool_t pg, bfloat16_t *base, svbfloat16_t data)
        ///   STNT1H Zdata.H, Pg, [Xarray, Xindex, LSL #1]
        ///   STNT1H Zdata.H, Pg, [Xbase, #0, MUL VL]
        /// </summary>
        public static unsafe void StoreNonTemporal(Vector<bfloat16> mask, bfloat16* address, Vector<bfloat16> data) => StoreNonTemporal(mask, address, data);


        ///  TransposeEven : Interleave even elements from two inputs

        /// <summary>
        /// svbfloat16_t svtrn1[_bf16](svbfloat16_t op1, svbfloat16_t op2)
        ///   TRN1 Zresult.H, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<bfloat16> TransposeEven(Vector<bfloat16> left, Vector<bfloat16> right) => TransposeEven(left, right);


        ///  TransposeOdd : Interleave odd elements from two inputs

        /// <summary>
        /// svbfloat16_t svtrn2[_bf16](svbfloat16_t op1, svbfloat16_t op2)
        ///   TRN2 Zresult.H, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<bfloat16> TransposeOdd(Vector<bfloat16> left, Vector<bfloat16> right) => TransposeOdd(left, right);


        ///  UnzipEven : Concatenate even elements from two inputs

        /// <summary>
        /// svbfloat16_t svuzp1[_bf16](svbfloat16_t op1, svbfloat16_t op2)
        ///   UZP1 Zresult.H, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<bfloat16> UnzipEven(Vector<bfloat16> left, Vector<bfloat16> right) => UnzipEven(left, right);


        ///  UnzipOdd : Concatenate odd elements from two inputs

        /// <summary>
        /// svbfloat16_t svuzp2[_bf16](svbfloat16_t op1, svbfloat16_t op2)
        ///   UZP2 Zresult.H, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<bfloat16> UnzipOdd(Vector<bfloat16> left, Vector<bfloat16> right) => UnzipOdd(left, right);


        ///  VectorTableLookup : Table lookup in single-vector table

        /// <summary>
        /// svbfloat16_t svtbl[_bf16](svbfloat16_t data, svuint16_t indices)
        ///   TBL Zresult.H, Zdata.H, Zindices.H
        /// </summary>
        public static unsafe Vector<bfloat16> VectorTableLookup(Vector<bfloat16> data, Vector<ushort> indices) => VectorTableLookup(data, indices);

        /// <summary>
        /// svbfloat16_t svtbl2[_bf16](svbfloat16x2_t data, svuint16_t indices)
        ///   TBL Zresult.H, {Zdata0.H, Zdata1.H}, Zindices.H
        /// </summary>
        public static unsafe Vector<bfloat16> VectorTableLookup((Vector<bfloat16> data1, Vector<bfloat16> data2), Vector<ushort> indices) => VectorTableLookup(data1,, indices);


        ///  VectorTableLookupExtension : Table lookup in single-vector table (merging)

        /// <summary>
        /// svbfloat16_t svtbx[_bf16](svbfloat16_t fallback, svbfloat16_t data, svuint16_t indices)
        ///   TBX Ztied.H, Zdata.H, Zindices.H
        /// </summary>
        public static unsafe Vector<bfloat16> VectorTableLookupExtension(Vector<bfloat16> fallback, Vector<bfloat16> data, Vector<ushort> indices) => VectorTableLookupExtension(fallback, data, indices);


        ///  ZipHigh : Interleave elements from high halves of two inputs

        /// <summary>
        /// svbfloat16_t svzip2[_bf16](svbfloat16_t op1, svbfloat16_t op2)
        ///   ZIP2 Zresult.H, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<bfloat16> ZipHigh(Vector<bfloat16> left, Vector<bfloat16> right) => ZipHigh(left, right);


        ///  ZipLow : Interleave elements from low halves of two inputs

        /// <summary>
        /// svbfloat16_t svzip1[_bf16](svbfloat16_t op1, svbfloat16_t op2)
        ///   ZIP1 Zresult.H, Zop1.H, Zop2.H
        /// </summary>
        public static unsafe Vector<bfloat16> ZipLow(Vector<bfloat16> left, Vector<bfloat16> right) => ZipLow(left, right);

    }
}

