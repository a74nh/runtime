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
    public abstract class SveNone : AdvSimd
    {
        internal SveNone() { }

        public static new bool IsSupported { get => IsSupported; }

        [Intrinsic]
        public new abstract class Arm64 : AdvSimd.Arm64
        {
            internal Arm64() { }

            public static new bool IsSupported { get => IsSupported; }
        }

        // Change one vector in a tuple of four vectors

        /// <summary>
        /// svbfloat16x4_t svset4[_bf16](svbfloat16x4_t tuple, uint64_t imm_index, svbfloat16_t x)
        /// </summary>
        public static unsafe (Vector<bfloat16>, Vector<bfloat16>, Vector<bfloat16>, Vector<bfloat16>) ChangeOneVectorInATupleOfFourVectors((Vector<bfloat16> tuple1, Vector<bfloat16> tuple2, Vector<bfloat16> tuple3, Vector<bfloat16> tuple4), ulong imm_index, Vector<bfloat16> x) => ChangeOneVectorInATupleOfFourVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svuint8x4_t svset4[_u8](svuint8x4_t tuple, uint64_t imm_index, svuint8_t x)
        /// </summary>
        public static unsafe (Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>) ChangeOneVectorInATupleOfFourVectors((Vector<byte> tuple1, Vector<byte> tuple2, Vector<byte> tuple3, Vector<byte> tuple4), ulong imm_index, Vector<byte> x) => ChangeOneVectorInATupleOfFourVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svfloat64x4_t svset4[_f64](svfloat64x4_t tuple, uint64_t imm_index, svfloat64_t x)
        /// </summary>
        public static unsafe (Vector<double>, Vector<double>, Vector<double>, Vector<double>) ChangeOneVectorInATupleOfFourVectors((Vector<double> tuple1, Vector<double> tuple2, Vector<double> tuple3, Vector<double> tuple4), ulong imm_index, Vector<double> x) => ChangeOneVectorInATupleOfFourVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svfloat16x4_t svset4[_f16](svfloat16x4_t tuple, uint64_t imm_index, svfloat16_t x)
        /// </summary>
        public static unsafe (Vector<half>, Vector<half>, Vector<half>, Vector<half>) ChangeOneVectorInATupleOfFourVectors((Vector<half> tuple1, Vector<half> tuple2, Vector<half> tuple3, Vector<half> tuple4), ulong imm_index, Vector<half> x) => ChangeOneVectorInATupleOfFourVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svint16x4_t svset4[_s16](svint16x4_t tuple, uint64_t imm_index, svint16_t x)
        /// </summary>
        public static unsafe (Vector<short>, Vector<short>, Vector<short>, Vector<short>) ChangeOneVectorInATupleOfFourVectors((Vector<short> tuple1, Vector<short> tuple2, Vector<short> tuple3, Vector<short> tuple4), ulong imm_index, Vector<short> x) => ChangeOneVectorInATupleOfFourVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svint32x4_t svset4[_s32](svint32x4_t tuple, uint64_t imm_index, svint32_t x)
        /// </summary>
        public static unsafe (Vector<int>, Vector<int>, Vector<int>, Vector<int>) ChangeOneVectorInATupleOfFourVectors((Vector<int> tuple1, Vector<int> tuple2, Vector<int> tuple3, Vector<int> tuple4), ulong imm_index, Vector<int> x) => ChangeOneVectorInATupleOfFourVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svint64x4_t svset4[_s64](svint64x4_t tuple, uint64_t imm_index, svint64_t x)
        /// </summary>
        public static unsafe (Vector<long>, Vector<long>, Vector<long>, Vector<long>) ChangeOneVectorInATupleOfFourVectors((Vector<long> tuple1, Vector<long> tuple2, Vector<long> tuple3, Vector<long> tuple4), ulong imm_index, Vector<long> x) => ChangeOneVectorInATupleOfFourVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svint8x4_t svset4[_s8](svint8x4_t tuple, uint64_t imm_index, svint8_t x)
        /// </summary>
        public static unsafe (Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>) ChangeOneVectorInATupleOfFourVectors((Vector<sbyte> tuple1, Vector<sbyte> tuple2, Vector<sbyte> tuple3, Vector<sbyte> tuple4), ulong imm_index, Vector<sbyte> x) => ChangeOneVectorInATupleOfFourVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svfloat32x4_t svset4[_f32](svfloat32x4_t tuple, uint64_t imm_index, svfloat32_t x)
        /// </summary>
        public static unsafe (Vector<float>, Vector<float>, Vector<float>, Vector<float>) ChangeOneVectorInATupleOfFourVectors((Vector<float> tuple1, Vector<float> tuple2, Vector<float> tuple3, Vector<float> tuple4), ulong imm_index, Vector<float> x) => ChangeOneVectorInATupleOfFourVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svuint16x4_t svset4[_u16](svuint16x4_t tuple, uint64_t imm_index, svuint16_t x)
        /// </summary>
        public static unsafe (Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>) ChangeOneVectorInATupleOfFourVectors((Vector<ushort> tuple1, Vector<ushort> tuple2, Vector<ushort> tuple3, Vector<ushort> tuple4), ulong imm_index, Vector<ushort> x) => ChangeOneVectorInATupleOfFourVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svuint32x4_t svset4[_u32](svuint32x4_t tuple, uint64_t imm_index, svuint32_t x)
        /// </summary>
        public static unsafe (Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>) ChangeOneVectorInATupleOfFourVectors((Vector<uint> tuple1, Vector<uint> tuple2, Vector<uint> tuple3, Vector<uint> tuple4), ulong imm_index, Vector<uint> x) => ChangeOneVectorInATupleOfFourVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svuint64x4_t svset4[_u64](svuint64x4_t tuple, uint64_t imm_index, svuint64_t x)
        /// </summary>
        public static unsafe (Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>) ChangeOneVectorInATupleOfFourVectors((Vector<ulong> tuple1, Vector<ulong> tuple2, Vector<ulong> tuple3, Vector<ulong> tuple4), ulong imm_index, Vector<ulong> x) => ChangeOneVectorInATupleOfFourVectors(tuple1,, imm_index, x);


        // Change one vector in a tuple of three vectors

        /// <summary>
        /// svbfloat16x3_t svset3[_bf16](svbfloat16x3_t tuple, uint64_t imm_index, svbfloat16_t x)
        /// </summary>
        public static unsafe (Vector<bfloat16>, Vector<bfloat16>, Vector<bfloat16>) ChangeOneVectorInATupleOfThreeVectors((Vector<bfloat16> tuple1, Vector<bfloat16> tuple2, Vector<bfloat16> tuple3), ulong imm_index, Vector<bfloat16> x) => ChangeOneVectorInATupleOfThreeVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svuint8x3_t svset3[_u8](svuint8x3_t tuple, uint64_t imm_index, svuint8_t x)
        /// </summary>
        public static unsafe (Vector<byte>, Vector<byte>, Vector<byte>) ChangeOneVectorInATupleOfThreeVectors((Vector<byte> tuple1, Vector<byte> tuple2, Vector<byte> tuple3), ulong imm_index, Vector<byte> x) => ChangeOneVectorInATupleOfThreeVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svfloat64x3_t svset3[_f64](svfloat64x3_t tuple, uint64_t imm_index, svfloat64_t x)
        /// </summary>
        public static unsafe (Vector<double>, Vector<double>, Vector<double>) ChangeOneVectorInATupleOfThreeVectors((Vector<double> tuple1, Vector<double> tuple2, Vector<double> tuple3), ulong imm_index, Vector<double> x) => ChangeOneVectorInATupleOfThreeVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svfloat16x3_t svset3[_f16](svfloat16x3_t tuple, uint64_t imm_index, svfloat16_t x)
        /// </summary>
        public static unsafe (Vector<half>, Vector<half>, Vector<half>) ChangeOneVectorInATupleOfThreeVectors((Vector<half> tuple1, Vector<half> tuple2, Vector<half> tuple3), ulong imm_index, Vector<half> x) => ChangeOneVectorInATupleOfThreeVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svint16x3_t svset3[_s16](svint16x3_t tuple, uint64_t imm_index, svint16_t x)
        /// </summary>
        public static unsafe (Vector<short>, Vector<short>, Vector<short>) ChangeOneVectorInATupleOfThreeVectors((Vector<short> tuple1, Vector<short> tuple2, Vector<short> tuple3), ulong imm_index, Vector<short> x) => ChangeOneVectorInATupleOfThreeVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svint32x3_t svset3[_s32](svint32x3_t tuple, uint64_t imm_index, svint32_t x)
        /// </summary>
        public static unsafe (Vector<int>, Vector<int>, Vector<int>) ChangeOneVectorInATupleOfThreeVectors((Vector<int> tuple1, Vector<int> tuple2, Vector<int> tuple3), ulong imm_index, Vector<int> x) => ChangeOneVectorInATupleOfThreeVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svint64x3_t svset3[_s64](svint64x3_t tuple, uint64_t imm_index, svint64_t x)
        /// </summary>
        public static unsafe (Vector<long>, Vector<long>, Vector<long>) ChangeOneVectorInATupleOfThreeVectors((Vector<long> tuple1, Vector<long> tuple2, Vector<long> tuple3), ulong imm_index, Vector<long> x) => ChangeOneVectorInATupleOfThreeVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svint8x3_t svset3[_s8](svint8x3_t tuple, uint64_t imm_index, svint8_t x)
        /// </summary>
        public static unsafe (Vector<sbyte>, Vector<sbyte>, Vector<sbyte>) ChangeOneVectorInATupleOfThreeVectors((Vector<sbyte> tuple1, Vector<sbyte> tuple2, Vector<sbyte> tuple3), ulong imm_index, Vector<sbyte> x) => ChangeOneVectorInATupleOfThreeVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svfloat32x3_t svset3[_f32](svfloat32x3_t tuple, uint64_t imm_index, svfloat32_t x)
        /// </summary>
        public static unsafe (Vector<float>, Vector<float>, Vector<float>) ChangeOneVectorInATupleOfThreeVectors((Vector<float> tuple1, Vector<float> tuple2, Vector<float> tuple3), ulong imm_index, Vector<float> x) => ChangeOneVectorInATupleOfThreeVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svuint16x3_t svset3[_u16](svuint16x3_t tuple, uint64_t imm_index, svuint16_t x)
        /// </summary>
        public static unsafe (Vector<ushort>, Vector<ushort>, Vector<ushort>) ChangeOneVectorInATupleOfThreeVectors((Vector<ushort> tuple1, Vector<ushort> tuple2, Vector<ushort> tuple3), ulong imm_index, Vector<ushort> x) => ChangeOneVectorInATupleOfThreeVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svuint32x3_t svset3[_u32](svuint32x3_t tuple, uint64_t imm_index, svuint32_t x)
        /// </summary>
        public static unsafe (Vector<uint>, Vector<uint>, Vector<uint>) ChangeOneVectorInATupleOfThreeVectors((Vector<uint> tuple1, Vector<uint> tuple2, Vector<uint> tuple3), ulong imm_index, Vector<uint> x) => ChangeOneVectorInATupleOfThreeVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svuint64x3_t svset3[_u64](svuint64x3_t tuple, uint64_t imm_index, svuint64_t x)
        /// </summary>
        public static unsafe (Vector<ulong>, Vector<ulong>, Vector<ulong>) ChangeOneVectorInATupleOfThreeVectors((Vector<ulong> tuple1, Vector<ulong> tuple2, Vector<ulong> tuple3), ulong imm_index, Vector<ulong> x) => ChangeOneVectorInATupleOfThreeVectors(tuple1,, imm_index, x);


        // Change one vector in a tuple of two vectors

        /// <summary>
        /// svbfloat16x2_t svset2[_bf16](svbfloat16x2_t tuple, uint64_t imm_index, svbfloat16_t x)
        /// </summary>
        public static unsafe (Vector<bfloat16>, Vector<bfloat16>) ChangeOneVectorInATupleOfTwoVectors((Vector<bfloat16> tuple1, Vector<bfloat16> tuple2), ulong imm_index, Vector<bfloat16> x) => ChangeOneVectorInATupleOfTwoVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svuint8x2_t svset2[_u8](svuint8x2_t tuple, uint64_t imm_index, svuint8_t x)
        /// </summary>
        public static unsafe (Vector<byte>, Vector<byte>) ChangeOneVectorInATupleOfTwoVectors((Vector<byte> tuple1, Vector<byte> tuple2), ulong imm_index, Vector<byte> x) => ChangeOneVectorInATupleOfTwoVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svfloat64x2_t svset2[_f64](svfloat64x2_t tuple, uint64_t imm_index, svfloat64_t x)
        /// </summary>
        public static unsafe (Vector<double>, Vector<double>) ChangeOneVectorInATupleOfTwoVectors((Vector<double> tuple1, Vector<double> tuple2), ulong imm_index, Vector<double> x) => ChangeOneVectorInATupleOfTwoVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svfloat16x2_t svset2[_f16](svfloat16x2_t tuple, uint64_t imm_index, svfloat16_t x)
        /// </summary>
        public static unsafe (Vector<half>, Vector<half>) ChangeOneVectorInATupleOfTwoVectors((Vector<half> tuple1, Vector<half> tuple2), ulong imm_index, Vector<half> x) => ChangeOneVectorInATupleOfTwoVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svint16x2_t svset2[_s16](svint16x2_t tuple, uint64_t imm_index, svint16_t x)
        /// </summary>
        public static unsafe (Vector<short>, Vector<short>) ChangeOneVectorInATupleOfTwoVectors((Vector<short> tuple1, Vector<short> tuple2), ulong imm_index, Vector<short> x) => ChangeOneVectorInATupleOfTwoVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svint32x2_t svset2[_s32](svint32x2_t tuple, uint64_t imm_index, svint32_t x)
        /// </summary>
        public static unsafe (Vector<int>, Vector<int>) ChangeOneVectorInATupleOfTwoVectors((Vector<int> tuple1, Vector<int> tuple2), ulong imm_index, Vector<int> x) => ChangeOneVectorInATupleOfTwoVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svint64x2_t svset2[_s64](svint64x2_t tuple, uint64_t imm_index, svint64_t x)
        /// </summary>
        public static unsafe (Vector<long>, Vector<long>) ChangeOneVectorInATupleOfTwoVectors((Vector<long> tuple1, Vector<long> tuple2), ulong imm_index, Vector<long> x) => ChangeOneVectorInATupleOfTwoVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svint8x2_t svset2[_s8](svint8x2_t tuple, uint64_t imm_index, svint8_t x)
        /// </summary>
        public static unsafe (Vector<sbyte>, Vector<sbyte>) ChangeOneVectorInATupleOfTwoVectors((Vector<sbyte> tuple1, Vector<sbyte> tuple2), ulong imm_index, Vector<sbyte> x) => ChangeOneVectorInATupleOfTwoVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svfloat32x2_t svset2[_f32](svfloat32x2_t tuple, uint64_t imm_index, svfloat32_t x)
        /// </summary>
        public static unsafe (Vector<float>, Vector<float>) ChangeOneVectorInATupleOfTwoVectors((Vector<float> tuple1, Vector<float> tuple2), ulong imm_index, Vector<float> x) => ChangeOneVectorInATupleOfTwoVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svuint16x2_t svset2[_u16](svuint16x2_t tuple, uint64_t imm_index, svuint16_t x)
        /// </summary>
        public static unsafe (Vector<ushort>, Vector<ushort>) ChangeOneVectorInATupleOfTwoVectors((Vector<ushort> tuple1, Vector<ushort> tuple2), ulong imm_index, Vector<ushort> x) => ChangeOneVectorInATupleOfTwoVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svuint32x2_t svset2[_u32](svuint32x2_t tuple, uint64_t imm_index, svuint32_t x)
        /// </summary>
        public static unsafe (Vector<uint>, Vector<uint>) ChangeOneVectorInATupleOfTwoVectors((Vector<uint> tuple1, Vector<uint> tuple2), ulong imm_index, Vector<uint> x) => ChangeOneVectorInATupleOfTwoVectors(tuple1,, imm_index, x);

        /// <summary>
        /// svuint64x2_t svset2[_u64](svuint64x2_t tuple, uint64_t imm_index, svuint64_t x)
        /// </summary>
        public static unsafe (Vector<ulong>, Vector<ulong>) ChangeOneVectorInATupleOfTwoVectors((Vector<ulong> tuple1, Vector<ulong> tuple2), ulong imm_index, Vector<ulong> x) => ChangeOneVectorInATupleOfTwoVectors(tuple1,, imm_index, x);


        // Create a tuple of four vectors

        /// <summary>
        /// svbfloat16x4_t svcreate4[_bf16](svbfloat16_t x0, svbfloat16_t x1, svbfloat16_t x2, svbfloat16_t x3)
        /// </summary>
        public static unsafe (Vector<bfloat16>, Vector<bfloat16>, Vector<bfloat16>, Vector<bfloat16>) CreateATupleOfFourVectors(Vector<bfloat16> x0, Vector<bfloat16> x1, Vector<bfloat16> x2, Vector<bfloat16> x3) => CreateATupleOfFourVectors(x0, x1, x2, x3);

        /// <summary>
        /// svuint8x4_t svcreate4[_u8](svuint8_t x0, svuint8_t x1, svuint8_t x2, svuint8_t x3)
        /// </summary>
        public static unsafe (Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>) CreateATupleOfFourVectors(Vector<byte> x0, Vector<byte> x1, Vector<byte> x2, Vector<byte> x3) => CreateATupleOfFourVectors(x0, x1, x2, x3);

        /// <summary>
        /// svfloat64x4_t svcreate4[_f64](svfloat64_t x0, svfloat64_t x1, svfloat64_t x2, svfloat64_t x3)
        /// </summary>
        public static unsafe (Vector<double>, Vector<double>, Vector<double>, Vector<double>) CreateATupleOfFourVectors(Vector<double> x0, Vector<double> x1, Vector<double> x2, Vector<double> x3) => CreateATupleOfFourVectors(x0, x1, x2, x3);

        /// <summary>
        /// svfloat16x4_t svcreate4[_f16](svfloat16_t x0, svfloat16_t x1, svfloat16_t x2, svfloat16_t x3)
        /// </summary>
        public static unsafe (Vector<half>, Vector<half>, Vector<half>, Vector<half>) CreateATupleOfFourVectors(Vector<half> x0, Vector<half> x1, Vector<half> x2, Vector<half> x3) => CreateATupleOfFourVectors(x0, x1, x2, x3);

        /// <summary>
        /// svint16x4_t svcreate4[_s16](svint16_t x0, svint16_t x1, svint16_t x2, svint16_t x3)
        /// </summary>
        public static unsafe (Vector<short>, Vector<short>, Vector<short>, Vector<short>) CreateATupleOfFourVectors(Vector<short> x0, Vector<short> x1, Vector<short> x2, Vector<short> x3) => CreateATupleOfFourVectors(x0, x1, x2, x3);

        /// <summary>
        /// svint32x4_t svcreate4[_s32](svint32_t x0, svint32_t x1, svint32_t x2, svint32_t x3)
        /// </summary>
        public static unsafe (Vector<int>, Vector<int>, Vector<int>, Vector<int>) CreateATupleOfFourVectors(Vector<int> x0, Vector<int> x1, Vector<int> x2, Vector<int> x3) => CreateATupleOfFourVectors(x0, x1, x2, x3);

        /// <summary>
        /// svint64x4_t svcreate4[_s64](svint64_t x0, svint64_t x1, svint64_t x2, svint64_t x3)
        /// </summary>
        public static unsafe (Vector<long>, Vector<long>, Vector<long>, Vector<long>) CreateATupleOfFourVectors(Vector<long> x0, Vector<long> x1, Vector<long> x2, Vector<long> x3) => CreateATupleOfFourVectors(x0, x1, x2, x3);

        /// <summary>
        /// svint8x4_t svcreate4[_s8](svint8_t x0, svint8_t x1, svint8_t x2, svint8_t x3)
        /// </summary>
        public static unsafe (Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>) CreateATupleOfFourVectors(Vector<sbyte> x0, Vector<sbyte> x1, Vector<sbyte> x2, Vector<sbyte> x3) => CreateATupleOfFourVectors(x0, x1, x2, x3);

        /// <summary>
        /// svfloat32x4_t svcreate4[_f32](svfloat32_t x0, svfloat32_t x1, svfloat32_t x2, svfloat32_t x3)
        /// </summary>
        public static unsafe (Vector<float>, Vector<float>, Vector<float>, Vector<float>) CreateATupleOfFourVectors(Vector<float> x0, Vector<float> x1, Vector<float> x2, Vector<float> x3) => CreateATupleOfFourVectors(x0, x1, x2, x3);

        /// <summary>
        /// svuint16x4_t svcreate4[_u16](svuint16_t x0, svuint16_t x1, svuint16_t x2, svuint16_t x3)
        /// </summary>
        public static unsafe (Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>) CreateATupleOfFourVectors(Vector<ushort> x0, Vector<ushort> x1, Vector<ushort> x2, Vector<ushort> x3) => CreateATupleOfFourVectors(x0, x1, x2, x3);

        /// <summary>
        /// svuint32x4_t svcreate4[_u32](svuint32_t x0, svuint32_t x1, svuint32_t x2, svuint32_t x3)
        /// </summary>
        public static unsafe (Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>) CreateATupleOfFourVectors(Vector<uint> x0, Vector<uint> x1, Vector<uint> x2, Vector<uint> x3) => CreateATupleOfFourVectors(x0, x1, x2, x3);

        /// <summary>
        /// svuint64x4_t svcreate4[_u64](svuint64_t x0, svuint64_t x1, svuint64_t x2, svuint64_t x3)
        /// </summary>
        public static unsafe (Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>) CreateATupleOfFourVectors(Vector<ulong> x0, Vector<ulong> x1, Vector<ulong> x2, Vector<ulong> x3) => CreateATupleOfFourVectors(x0, x1, x2, x3);


        // Create a tuple of three vectors

        /// <summary>
        /// svbfloat16x3_t svcreate3[_bf16](svbfloat16_t x0, svbfloat16_t x1, svbfloat16_t x2)
        /// </summary>
        public static unsafe (Vector<bfloat16>, Vector<bfloat16>, Vector<bfloat16>) CreateATupleOfThreeVectors(Vector<bfloat16> x0, Vector<bfloat16> x1, Vector<bfloat16> x2) => CreateATupleOfThreeVectors(x0, x1, x2);

        /// <summary>
        /// svuint8x3_t svcreate3[_u8](svuint8_t x0, svuint8_t x1, svuint8_t x2)
        /// </summary>
        public static unsafe (Vector<byte>, Vector<byte>, Vector<byte>) CreateATupleOfThreeVectors(Vector<byte> x0, Vector<byte> x1, Vector<byte> x2) => CreateATupleOfThreeVectors(x0, x1, x2);

        /// <summary>
        /// svfloat64x3_t svcreate3[_f64](svfloat64_t x0, svfloat64_t x1, svfloat64_t x2)
        /// </summary>
        public static unsafe (Vector<double>, Vector<double>, Vector<double>) CreateATupleOfThreeVectors(Vector<double> x0, Vector<double> x1, Vector<double> x2) => CreateATupleOfThreeVectors(x0, x1, x2);

        /// <summary>
        /// svfloat16x3_t svcreate3[_f16](svfloat16_t x0, svfloat16_t x1, svfloat16_t x2)
        /// </summary>
        public static unsafe (Vector<half>, Vector<half>, Vector<half>) CreateATupleOfThreeVectors(Vector<half> x0, Vector<half> x1, Vector<half> x2) => CreateATupleOfThreeVectors(x0, x1, x2);

        /// <summary>
        /// svint16x3_t svcreate3[_s16](svint16_t x0, svint16_t x1, svint16_t x2)
        /// </summary>
        public static unsafe (Vector<short>, Vector<short>, Vector<short>) CreateATupleOfThreeVectors(Vector<short> x0, Vector<short> x1, Vector<short> x2) => CreateATupleOfThreeVectors(x0, x1, x2);

        /// <summary>
        /// svint32x3_t svcreate3[_s32](svint32_t x0, svint32_t x1, svint32_t x2)
        /// </summary>
        public static unsafe (Vector<int>, Vector<int>, Vector<int>) CreateATupleOfThreeVectors(Vector<int> x0, Vector<int> x1, Vector<int> x2) => CreateATupleOfThreeVectors(x0, x1, x2);

        /// <summary>
        /// svint64x3_t svcreate3[_s64](svint64_t x0, svint64_t x1, svint64_t x2)
        /// </summary>
        public static unsafe (Vector<long>, Vector<long>, Vector<long>) CreateATupleOfThreeVectors(Vector<long> x0, Vector<long> x1, Vector<long> x2) => CreateATupleOfThreeVectors(x0, x1, x2);

        /// <summary>
        /// svint8x3_t svcreate3[_s8](svint8_t x0, svint8_t x1, svint8_t x2)
        /// </summary>
        public static unsafe (Vector<sbyte>, Vector<sbyte>, Vector<sbyte>) CreateATupleOfThreeVectors(Vector<sbyte> x0, Vector<sbyte> x1, Vector<sbyte> x2) => CreateATupleOfThreeVectors(x0, x1, x2);

        /// <summary>
        /// svfloat32x3_t svcreate3[_f32](svfloat32_t x0, svfloat32_t x1, svfloat32_t x2)
        /// </summary>
        public static unsafe (Vector<float>, Vector<float>, Vector<float>) CreateATupleOfThreeVectors(Vector<float> x0, Vector<float> x1, Vector<float> x2) => CreateATupleOfThreeVectors(x0, x1, x2);

        /// <summary>
        /// svuint16x3_t svcreate3[_u16](svuint16_t x0, svuint16_t x1, svuint16_t x2)
        /// </summary>
        public static unsafe (Vector<ushort>, Vector<ushort>, Vector<ushort>) CreateATupleOfThreeVectors(Vector<ushort> x0, Vector<ushort> x1, Vector<ushort> x2) => CreateATupleOfThreeVectors(x0, x1, x2);

        /// <summary>
        /// svuint32x3_t svcreate3[_u32](svuint32_t x0, svuint32_t x1, svuint32_t x2)
        /// </summary>
        public static unsafe (Vector<uint>, Vector<uint>, Vector<uint>) CreateATupleOfThreeVectors(Vector<uint> x0, Vector<uint> x1, Vector<uint> x2) => CreateATupleOfThreeVectors(x0, x1, x2);

        /// <summary>
        /// svuint64x3_t svcreate3[_u64](svuint64_t x0, svuint64_t x1, svuint64_t x2)
        /// </summary>
        public static unsafe (Vector<ulong>, Vector<ulong>, Vector<ulong>) CreateATupleOfThreeVectors(Vector<ulong> x0, Vector<ulong> x1, Vector<ulong> x2) => CreateATupleOfThreeVectors(x0, x1, x2);


        // Create a tuple of two vectors

        /// <summary>
        /// svbfloat16x2_t svcreate2[_bf16](svbfloat16_t x0, svbfloat16_t x1)
        /// </summary>
        public static unsafe (Vector<bfloat16>, Vector<bfloat16>) CreateATupleOfTwoVectors(Vector<bfloat16> x0, Vector<bfloat16> x1) => CreateATupleOfTwoVectors(x0, x1);

        /// <summary>
        /// svuint8x2_t svcreate2[_u8](svuint8_t x0, svuint8_t x1)
        /// </summary>
        public static unsafe (Vector<byte>, Vector<byte>) CreateATupleOfTwoVectors(Vector<byte> x0, Vector<byte> x1) => CreateATupleOfTwoVectors(x0, x1);

        /// <summary>
        /// svfloat64x2_t svcreate2[_f64](svfloat64_t x0, svfloat64_t x1)
        /// </summary>
        public static unsafe (Vector<double>, Vector<double>) CreateATupleOfTwoVectors(Vector<double> x0, Vector<double> x1) => CreateATupleOfTwoVectors(x0, x1);

        /// <summary>
        /// svfloat16x2_t svcreate2[_f16](svfloat16_t x0, svfloat16_t x1)
        /// </summary>
        public static unsafe (Vector<half>, Vector<half>) CreateATupleOfTwoVectors(Vector<half> x0, Vector<half> x1) => CreateATupleOfTwoVectors(x0, x1);

        /// <summary>
        /// svint16x2_t svcreate2[_s16](svint16_t x0, svint16_t x1)
        /// </summary>
        public static unsafe (Vector<short>, Vector<short>) CreateATupleOfTwoVectors(Vector<short> x0, Vector<short> x1) => CreateATupleOfTwoVectors(x0, x1);

        /// <summary>
        /// svint32x2_t svcreate2[_s32](svint32_t x0, svint32_t x1)
        /// </summary>
        public static unsafe (Vector<int>, Vector<int>) CreateATupleOfTwoVectors(Vector<int> x0, Vector<int> x1) => CreateATupleOfTwoVectors(x0, x1);

        /// <summary>
        /// svint64x2_t svcreate2[_s64](svint64_t x0, svint64_t x1)
        /// </summary>
        public static unsafe (Vector<long>, Vector<long>) CreateATupleOfTwoVectors(Vector<long> x0, Vector<long> x1) => CreateATupleOfTwoVectors(x0, x1);

        /// <summary>
        /// svint8x2_t svcreate2[_s8](svint8_t x0, svint8_t x1)
        /// </summary>
        public static unsafe (Vector<sbyte>, Vector<sbyte>) CreateATupleOfTwoVectors(Vector<sbyte> x0, Vector<sbyte> x1) => CreateATupleOfTwoVectors(x0, x1);

        /// <summary>
        /// svfloat32x2_t svcreate2[_f32](svfloat32_t x0, svfloat32_t x1)
        /// </summary>
        public static unsafe (Vector<float>, Vector<float>) CreateATupleOfTwoVectors(Vector<float> x0, Vector<float> x1) => CreateATupleOfTwoVectors(x0, x1);

        /// <summary>
        /// svuint16x2_t svcreate2[_u16](svuint16_t x0, svuint16_t x1)
        /// </summary>
        public static unsafe (Vector<ushort>, Vector<ushort>) CreateATupleOfTwoVectors(Vector<ushort> x0, Vector<ushort> x1) => CreateATupleOfTwoVectors(x0, x1);

        /// <summary>
        /// svuint32x2_t svcreate2[_u32](svuint32_t x0, svuint32_t x1)
        /// </summary>
        public static unsafe (Vector<uint>, Vector<uint>) CreateATupleOfTwoVectors(Vector<uint> x0, Vector<uint> x1) => CreateATupleOfTwoVectors(x0, x1);

        /// <summary>
        /// svuint64x2_t svcreate2[_u64](svuint64_t x0, svuint64_t x1)
        /// </summary>
        public static unsafe (Vector<ulong>, Vector<ulong>) CreateATupleOfTwoVectors(Vector<ulong> x0, Vector<ulong> x1) => CreateATupleOfTwoVectors(x0, x1);


        // Create an uninitialized tuple of four vectors

        /// <summary>
        /// svbfloat16x4_t svundef4_bf16()
        /// </summary>
        public static unsafe (Vector<bfloat16>, Vector<bfloat16>, Vector<bfloat16>, Vector<bfloat16>) CreateAnUninitializedTupleOfFourVectors() => CreateAnUninitializedTupleOfFourVectors();

        /// <summary>
        /// svuint8x4_t svundef4_u8()
        /// </summary>
        public static unsafe (Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>) CreateAnUninitializedTupleOfFourVectors() => CreateAnUninitializedTupleOfFourVectors();

        /// <summary>
        /// svfloat64x4_t svundef4_f64()
        /// </summary>
        public static unsafe (Vector<double>, Vector<double>, Vector<double>, Vector<double>) CreateAnUninitializedTupleOfFourVectors() => CreateAnUninitializedTupleOfFourVectors();

        /// <summary>
        /// svfloat16x4_t svundef4_f16()
        /// </summary>
        public static unsafe (Vector<half>, Vector<half>, Vector<half>, Vector<half>) CreateAnUninitializedTupleOfFourVectors() => CreateAnUninitializedTupleOfFourVectors();

        /// <summary>
        /// svint16x4_t svundef4_s16()
        /// </summary>
        public static unsafe (Vector<short>, Vector<short>, Vector<short>, Vector<short>) CreateAnUninitializedTupleOfFourVectors() => CreateAnUninitializedTupleOfFourVectors();

        /// <summary>
        /// svint32x4_t svundef4_s32()
        /// </summary>
        public static unsafe (Vector<int>, Vector<int>, Vector<int>, Vector<int>) CreateAnUninitializedTupleOfFourVectors() => CreateAnUninitializedTupleOfFourVectors();

        /// <summary>
        /// svint64x4_t svundef4_s64()
        /// </summary>
        public static unsafe (Vector<long>, Vector<long>, Vector<long>, Vector<long>) CreateAnUninitializedTupleOfFourVectors() => CreateAnUninitializedTupleOfFourVectors();

        /// <summary>
        /// svint8x4_t svundef4_s8()
        /// </summary>
        public static unsafe (Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>) CreateAnUninitializedTupleOfFourVectors() => CreateAnUninitializedTupleOfFourVectors();

        /// <summary>
        /// svfloat32x4_t svundef4_f32()
        /// </summary>
        public static unsafe (Vector<float>, Vector<float>, Vector<float>, Vector<float>) CreateAnUninitializedTupleOfFourVectors() => CreateAnUninitializedTupleOfFourVectors();

        /// <summary>
        /// svuint16x4_t svundef4_u16()
        /// </summary>
        public static unsafe (Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>) CreateAnUninitializedTupleOfFourVectors() => CreateAnUninitializedTupleOfFourVectors();

        /// <summary>
        /// svuint32x4_t svundef4_u32()
        /// </summary>
        public static unsafe (Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>) CreateAnUninitializedTupleOfFourVectors() => CreateAnUninitializedTupleOfFourVectors();

        /// <summary>
        /// svuint64x4_t svundef4_u64()
        /// </summary>
        public static unsafe (Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>) CreateAnUninitializedTupleOfFourVectors() => CreateAnUninitializedTupleOfFourVectors();


        // Create an uninitialized tuple of three vectors

        /// <summary>
        /// svbfloat16x3_t svundef3_bf16()
        /// </summary>
        public static unsafe (Vector<bfloat16>, Vector<bfloat16>, Vector<bfloat16>) CreateAnUninitializedTupleOfThreeVectors() => CreateAnUninitializedTupleOfThreeVectors();

        /// <summary>
        /// svuint8x3_t svundef3_u8()
        /// </summary>
        public static unsafe (Vector<byte>, Vector<byte>, Vector<byte>) CreateAnUninitializedTupleOfThreeVectors() => CreateAnUninitializedTupleOfThreeVectors();

        /// <summary>
        /// svfloat64x3_t svundef3_f64()
        /// </summary>
        public static unsafe (Vector<double>, Vector<double>, Vector<double>) CreateAnUninitializedTupleOfThreeVectors() => CreateAnUninitializedTupleOfThreeVectors();

        /// <summary>
        /// svfloat16x3_t svundef3_f16()
        /// </summary>
        public static unsafe (Vector<half>, Vector<half>, Vector<half>) CreateAnUninitializedTupleOfThreeVectors() => CreateAnUninitializedTupleOfThreeVectors();

        /// <summary>
        /// svint16x3_t svundef3_s16()
        /// </summary>
        public static unsafe (Vector<short>, Vector<short>, Vector<short>) CreateAnUninitializedTupleOfThreeVectors() => CreateAnUninitializedTupleOfThreeVectors();

        /// <summary>
        /// svint32x3_t svundef3_s32()
        /// </summary>
        public static unsafe (Vector<int>, Vector<int>, Vector<int>) CreateAnUninitializedTupleOfThreeVectors() => CreateAnUninitializedTupleOfThreeVectors();

        /// <summary>
        /// svint64x3_t svundef3_s64()
        /// </summary>
        public static unsafe (Vector<long>, Vector<long>, Vector<long>) CreateAnUninitializedTupleOfThreeVectors() => CreateAnUninitializedTupleOfThreeVectors();

        /// <summary>
        /// svint8x3_t svundef3_s8()
        /// </summary>
        public static unsafe (Vector<sbyte>, Vector<sbyte>, Vector<sbyte>) CreateAnUninitializedTupleOfThreeVectors() => CreateAnUninitializedTupleOfThreeVectors();

        /// <summary>
        /// svfloat32x3_t svundef3_f32()
        /// </summary>
        public static unsafe (Vector<float>, Vector<float>, Vector<float>) CreateAnUninitializedTupleOfThreeVectors() => CreateAnUninitializedTupleOfThreeVectors();

        /// <summary>
        /// svuint16x3_t svundef3_u16()
        /// </summary>
        public static unsafe (Vector<ushort>, Vector<ushort>, Vector<ushort>) CreateAnUninitializedTupleOfThreeVectors() => CreateAnUninitializedTupleOfThreeVectors();

        /// <summary>
        /// svuint32x3_t svundef3_u32()
        /// </summary>
        public static unsafe (Vector<uint>, Vector<uint>, Vector<uint>) CreateAnUninitializedTupleOfThreeVectors() => CreateAnUninitializedTupleOfThreeVectors();

        /// <summary>
        /// svuint64x3_t svundef3_u64()
        /// </summary>
        public static unsafe (Vector<ulong>, Vector<ulong>, Vector<ulong>) CreateAnUninitializedTupleOfThreeVectors() => CreateAnUninitializedTupleOfThreeVectors();


        // Create an uninitialized tuple of two vectors

        /// <summary>
        /// svbfloat16x2_t svundef2_bf16()
        /// </summary>
        public static unsafe (Vector<bfloat16>, Vector<bfloat16>) CreateAnUninitializedTupleOfTwoVectors() => CreateAnUninitializedTupleOfTwoVectors();

        /// <summary>
        /// svuint8x2_t svundef2_u8()
        /// </summary>
        public static unsafe (Vector<byte>, Vector<byte>) CreateAnUninitializedTupleOfTwoVectors() => CreateAnUninitializedTupleOfTwoVectors();

        /// <summary>
        /// svfloat64x2_t svundef2_f64()
        /// </summary>
        public static unsafe (Vector<double>, Vector<double>) CreateAnUninitializedTupleOfTwoVectors() => CreateAnUninitializedTupleOfTwoVectors();

        /// <summary>
        /// svfloat16x2_t svundef2_f16()
        /// </summary>
        public static unsafe (Vector<half>, Vector<half>) CreateAnUninitializedTupleOfTwoVectors() => CreateAnUninitializedTupleOfTwoVectors();

        /// <summary>
        /// svint16x2_t svundef2_s16()
        /// </summary>
        public static unsafe (Vector<short>, Vector<short>) CreateAnUninitializedTupleOfTwoVectors() => CreateAnUninitializedTupleOfTwoVectors();

        /// <summary>
        /// svint32x2_t svundef2_s32()
        /// </summary>
        public static unsafe (Vector<int>, Vector<int>) CreateAnUninitializedTupleOfTwoVectors() => CreateAnUninitializedTupleOfTwoVectors();

        /// <summary>
        /// svint64x2_t svundef2_s64()
        /// </summary>
        public static unsafe (Vector<long>, Vector<long>) CreateAnUninitializedTupleOfTwoVectors() => CreateAnUninitializedTupleOfTwoVectors();

        /// <summary>
        /// svint8x2_t svundef2_s8()
        /// </summary>
        public static unsafe (Vector<sbyte>, Vector<sbyte>) CreateAnUninitializedTupleOfTwoVectors() => CreateAnUninitializedTupleOfTwoVectors();

        /// <summary>
        /// svfloat32x2_t svundef2_f32()
        /// </summary>
        public static unsafe (Vector<float>, Vector<float>) CreateAnUninitializedTupleOfTwoVectors() => CreateAnUninitializedTupleOfTwoVectors();

        /// <summary>
        /// svuint16x2_t svundef2_u16()
        /// </summary>
        public static unsafe (Vector<ushort>, Vector<ushort>) CreateAnUninitializedTupleOfTwoVectors() => CreateAnUninitializedTupleOfTwoVectors();

        /// <summary>
        /// svuint32x2_t svundef2_u32()
        /// </summary>
        public static unsafe (Vector<uint>, Vector<uint>) CreateAnUninitializedTupleOfTwoVectors() => CreateAnUninitializedTupleOfTwoVectors();

        /// <summary>
        /// svuint64x2_t svundef2_u64()
        /// </summary>
        public static unsafe (Vector<ulong>, Vector<ulong>) CreateAnUninitializedTupleOfTwoVectors() => CreateAnUninitializedTupleOfTwoVectors();


        // Create an uninitialized vector

        /// <summary>
        /// svbfloat16_t svundef_bf16()
        /// </summary>
        public static unsafe Vector<bfloat16> CreateAnUninitializedVector() => CreateAnUninitializedVector();

        /// <summary>
        /// svuint8_t svundef_u8()
        /// </summary>
        public static unsafe Vector<byte> CreateAnUninitializedVector() => CreateAnUninitializedVector();

        /// <summary>
        /// svfloat64_t svundef_f64()
        /// </summary>
        public static unsafe Vector<double> CreateAnUninitializedVector() => CreateAnUninitializedVector();

        /// <summary>
        /// svfloat16_t svundef_f16()
        /// </summary>
        public static unsafe Vector<half> CreateAnUninitializedVector() => CreateAnUninitializedVector();

        /// <summary>
        /// svint16_t svundef_s16()
        /// </summary>
        public static unsafe Vector<short> CreateAnUninitializedVector() => CreateAnUninitializedVector();

        /// <summary>
        /// svint32_t svundef_s32()
        /// </summary>
        public static unsafe Vector<int> CreateAnUninitializedVector() => CreateAnUninitializedVector();

        /// <summary>
        /// svint64_t svundef_s64()
        /// </summary>
        public static unsafe Vector<long> CreateAnUninitializedVector() => CreateAnUninitializedVector();

        /// <summary>
        /// svint8_t svundef_s8()
        /// </summary>
        public static unsafe Vector<sbyte> CreateAnUninitializedVector() => CreateAnUninitializedVector();

        /// <summary>
        /// svfloat32_t svundef_f32()
        /// </summary>
        public static unsafe Vector<float> CreateAnUninitializedVector() => CreateAnUninitializedVector();

        /// <summary>
        /// svuint16_t svundef_u16()
        /// </summary>
        public static unsafe Vector<ushort> CreateAnUninitializedVector() => CreateAnUninitializedVector();

        /// <summary>
        /// svuint32_t svundef_u32()
        /// </summary>
        public static unsafe Vector<uint> CreateAnUninitializedVector() => CreateAnUninitializedVector();

        /// <summary>
        /// svuint64_t svundef_u64()
        /// </summary>
        public static unsafe Vector<ulong> CreateAnUninitializedVector() => CreateAnUninitializedVector();


        // Broadcast a quadword of scalars

        /// <summary>
        /// svbfloat16_t svdupq[_n]_bf16(bfloat16_t x0, bfloat16_t x1, bfloat16_t x2, bfloat16_t x3, bfloat16_t x4, bfloat16_t x5, bfloat16_t x6, bfloat16_t x7)
        /// </summary>
        public static unsafe Vector<bfloat16> DuplicateSelectedScalarToVector(bfloat16 x0, [ConstantExpected] byte index, bfloat16 x2, bfloat16 x3, bfloat16 x4, bfloat16 x5, bfloat16 x6, bfloat16 x7) => DuplicateSelectedScalarToVector(x0, index, x2, x3, x4, x5, x6, x7);

        /// <summary>
        /// svuint8_t svdupq[_n]_u8(uint8_t x0, uint8_t x1, uint8_t x2, uint8_t x3, uint8_t x4, uint8_t x5, uint8_t x6, uint8_t x7, uint8_t x8, uint8_t x9, uint8_t x10, uint8_t x11, uint8_t x12, uint8_t x13, uint8_t x14, uint8_t x15)
        /// </summary>
        public static unsafe Vector<byte> DuplicateSelectedScalarToVector(byte x0, [ConstantExpected] byte index, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, byte x8, byte x9, byte x10, byte x11, byte x12, byte x13, byte x14, byte x15) => DuplicateSelectedScalarToVector(x0, index, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15);

        /// <summary>
        /// svbool_t svdupq[_n]_b8(bool x0, bool x1, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7, bool x8, bool x9, bool x10, bool x11, bool x12, bool x13, bool x14, bool x15)
        /// </summary>
        public static unsafe Vector<byte> DuplicateSelectedScalarToVector(bool x0, [ConstantExpected] byte index, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7, bool x8, bool x9, bool x10, bool x11, bool x12, bool x13, bool x14, bool x15) => DuplicateSelectedScalarToVector(x0, index, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15);

        /// <summary>
        /// svfloat64_t svdupq[_n]_f64(float64_t x0, float64_t x1)
        /// </summary>
        public static unsafe Vector<double> DuplicateSelectedScalarToVector(double x0, [ConstantExpected] byte index) => DuplicateSelectedScalarToVector(x0, index);

        /// <summary>
        /// svfloat16_t svdupq[_n]_f16(float16_t x0, float16_t x1, float16_t x2, float16_t x3, float16_t x4, float16_t x5, float16_t x6, float16_t x7)
        /// </summary>
        public static unsafe Vector<half> DuplicateSelectedScalarToVector(half x0, [ConstantExpected] byte index, half x2, half x3, half x4, half x5, half x6, half x7) => DuplicateSelectedScalarToVector(x0, index, x2, x3, x4, x5, x6, x7);

        /// <summary>
        /// svint16_t svdupq[_n]_s16(int16_t x0, int16_t x1, int16_t x2, int16_t x3, int16_t x4, int16_t x5, int16_t x6, int16_t x7)
        /// </summary>
        public static unsafe Vector<short> DuplicateSelectedScalarToVector(short x0, [ConstantExpected] byte index, short x2, short x3, short x4, short x5, short x6, short x7) => DuplicateSelectedScalarToVector(x0, index, x2, x3, x4, x5, x6, x7);

        /// <summary>
        /// svint32_t svdupq[_n]_s32(int32_t x0, int32_t x1, int32_t x2, int32_t x3)
        /// </summary>
        public static unsafe Vector<int> DuplicateSelectedScalarToVector(int x0, [ConstantExpected] byte index, int x2, int x3) => DuplicateSelectedScalarToVector(x0, index, x2, x3);

        /// <summary>
        /// svint64_t svdupq[_n]_s64(int64_t x0, int64_t x1)
        /// </summary>
        public static unsafe Vector<long> DuplicateSelectedScalarToVector(long x0, [ConstantExpected] byte index) => DuplicateSelectedScalarToVector(x0, index);

        /// <summary>
        /// svint8_t svdupq[_n]_s8(int8_t x0, int8_t x1, int8_t x2, int8_t x3, int8_t x4, int8_t x5, int8_t x6, int8_t x7, int8_t x8, int8_t x9, int8_t x10, int8_t x11, int8_t x12, int8_t x13, int8_t x14, int8_t x15)
        /// </summary>
        public static unsafe Vector<sbyte> DuplicateSelectedScalarToVector(sbyte x0, [ConstantExpected] byte index, sbyte x2, sbyte x3, sbyte x4, sbyte x5, sbyte x6, sbyte x7, sbyte x8, sbyte x9, sbyte x10, sbyte x11, sbyte x12, sbyte x13, sbyte x14, sbyte x15) => DuplicateSelectedScalarToVector(x0, index, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15);

        /// <summary>
        /// svfloat32_t svdupq[_n]_f32(float32_t x0, float32_t x1, float32_t x2, float32_t x3)
        /// </summary>
        public static unsafe Vector<float> DuplicateSelectedScalarToVector(float x0, [ConstantExpected] byte index, float x2, float x3) => DuplicateSelectedScalarToVector(x0, index, x2, x3);

        /// <summary>
        /// svuint16_t svdupq[_n]_u16(uint16_t x0, uint16_t x1, uint16_t x2, uint16_t x3, uint16_t x4, uint16_t x5, uint16_t x6, uint16_t x7)
        /// </summary>
        public static unsafe Vector<ushort> DuplicateSelectedScalarToVector(ushort x0, [ConstantExpected] byte index, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7) => DuplicateSelectedScalarToVector(x0, index, x2, x3, x4, x5, x6, x7);

        /// <summary>
        /// svbool_t svdupq[_n]_b16(bool x0, bool x1, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7)
        /// </summary>
        public static unsafe Vector<ushort> DuplicateSelectedScalarToVector(bool x0, [ConstantExpected] byte index, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7) => DuplicateSelectedScalarToVector(x0, index, x2, x3, x4, x5, x6, x7);

        /// <summary>
        /// svuint32_t svdupq[_n]_u32(uint32_t x0, uint32_t x1, uint32_t x2, uint32_t x3)
        /// </summary>
        public static unsafe Vector<uint> DuplicateSelectedScalarToVector(uint x0, [ConstantExpected] byte index, uint x2, uint x3) => DuplicateSelectedScalarToVector(x0, index, x2, x3);

        /// <summary>
        /// svbool_t svdupq[_n]_b32(bool x0, bool x1, bool x2, bool x3)
        /// </summary>
        public static unsafe Vector<uint> DuplicateSelectedScalarToVector(bool x0, [ConstantExpected] byte index, bool x2, bool x3) => DuplicateSelectedScalarToVector(x0, index, x2, x3);

        /// <summary>
        /// svuint64_t svdupq[_n]_u64(uint64_t x0, uint64_t x1)
        /// </summary>
        public static unsafe Vector<ulong> DuplicateSelectedScalarToVector(ulong x0, [ConstantExpected] byte index) => DuplicateSelectedScalarToVector(x0, index);

        /// <summary>
        /// svbool_t svdupq[_n]_b64(bool x0, bool x1)
        /// </summary>
        public static unsafe Vector<ulong> DuplicateSelectedScalarToVector(bool x0, [ConstantExpected] byte index) => DuplicateSelectedScalarToVector(x0, index);


        // Extract one vector from a tuple of four vectors

        /// <summary>
        /// svbfloat16_t svget4[_bf16](svbfloat16x4_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<bfloat16> ExtractOneVectorFromATupleOfFourVectors((Vector<bfloat16> tuple1, Vector<bfloat16> tuple2, Vector<bfloat16> tuple3, Vector<bfloat16> tuple4), ulong imm_index) => ExtractOneVectorFromATupleOfFourVectors(tuple1,, imm_index);

        /// <summary>
        /// svuint8_t svget4[_u8](svuint8x4_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<byte> ExtractOneVectorFromATupleOfFourVectors((Vector<byte> tuple1, Vector<byte> tuple2, Vector<byte> tuple3, Vector<byte> tuple4), ulong imm_index) => ExtractOneVectorFromATupleOfFourVectors(tuple1,, imm_index);

        /// <summary>
        /// svfloat64_t svget4[_f64](svfloat64x4_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<double> ExtractOneVectorFromATupleOfFourVectors((Vector<double> tuple1, Vector<double> tuple2, Vector<double> tuple3, Vector<double> tuple4), ulong imm_index) => ExtractOneVectorFromATupleOfFourVectors(tuple1,, imm_index);

        /// <summary>
        /// svfloat16_t svget4[_f16](svfloat16x4_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<half> ExtractOneVectorFromATupleOfFourVectors((Vector<half> tuple1, Vector<half> tuple2, Vector<half> tuple3, Vector<half> tuple4), ulong imm_index) => ExtractOneVectorFromATupleOfFourVectors(tuple1,, imm_index);

        /// <summary>
        /// svint16_t svget4[_s16](svint16x4_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<short> ExtractOneVectorFromATupleOfFourVectors((Vector<short> tuple1, Vector<short> tuple2, Vector<short> tuple3, Vector<short> tuple4), ulong imm_index) => ExtractOneVectorFromATupleOfFourVectors(tuple1,, imm_index);

        /// <summary>
        /// svint32_t svget4[_s32](svint32x4_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<int> ExtractOneVectorFromATupleOfFourVectors((Vector<int> tuple1, Vector<int> tuple2, Vector<int> tuple3, Vector<int> tuple4), ulong imm_index) => ExtractOneVectorFromATupleOfFourVectors(tuple1,, imm_index);

        /// <summary>
        /// svint64_t svget4[_s64](svint64x4_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<long> ExtractOneVectorFromATupleOfFourVectors((Vector<long> tuple1, Vector<long> tuple2, Vector<long> tuple3, Vector<long> tuple4), ulong imm_index) => ExtractOneVectorFromATupleOfFourVectors(tuple1,, imm_index);

        /// <summary>
        /// svint8_t svget4[_s8](svint8x4_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<sbyte> ExtractOneVectorFromATupleOfFourVectors((Vector<sbyte> tuple1, Vector<sbyte> tuple2, Vector<sbyte> tuple3, Vector<sbyte> tuple4), ulong imm_index) => ExtractOneVectorFromATupleOfFourVectors(tuple1,, imm_index);

        /// <summary>
        /// svfloat32_t svget4[_f32](svfloat32x4_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<float> ExtractOneVectorFromATupleOfFourVectors((Vector<float> tuple1, Vector<float> tuple2, Vector<float> tuple3, Vector<float> tuple4), ulong imm_index) => ExtractOneVectorFromATupleOfFourVectors(tuple1,, imm_index);

        /// <summary>
        /// svuint16_t svget4[_u16](svuint16x4_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<ushort> ExtractOneVectorFromATupleOfFourVectors((Vector<ushort> tuple1, Vector<ushort> tuple2, Vector<ushort> tuple3, Vector<ushort> tuple4), ulong imm_index) => ExtractOneVectorFromATupleOfFourVectors(tuple1,, imm_index);

        /// <summary>
        /// svuint32_t svget4[_u32](svuint32x4_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<uint> ExtractOneVectorFromATupleOfFourVectors((Vector<uint> tuple1, Vector<uint> tuple2, Vector<uint> tuple3, Vector<uint> tuple4), ulong imm_index) => ExtractOneVectorFromATupleOfFourVectors(tuple1,, imm_index);

        /// <summary>
        /// svuint64_t svget4[_u64](svuint64x4_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<ulong> ExtractOneVectorFromATupleOfFourVectors((Vector<ulong> tuple1, Vector<ulong> tuple2, Vector<ulong> tuple3, Vector<ulong> tuple4), ulong imm_index) => ExtractOneVectorFromATupleOfFourVectors(tuple1,, imm_index);


        // Extract one vector from a tuple of three vectors

        /// <summary>
        /// svbfloat16_t svget3[_bf16](svbfloat16x3_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<bfloat16> ExtractOneVectorFromATupleOfThreeVectors((Vector<bfloat16> tuple1, Vector<bfloat16> tuple2, Vector<bfloat16> tuple3), ulong imm_index) => ExtractOneVectorFromATupleOfThreeVectors(tuple1,, imm_index);

        /// <summary>
        /// svuint8_t svget3[_u8](svuint8x3_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<byte> ExtractOneVectorFromATupleOfThreeVectors((Vector<byte> tuple1, Vector<byte> tuple2, Vector<byte> tuple3), ulong imm_index) => ExtractOneVectorFromATupleOfThreeVectors(tuple1,, imm_index);

        /// <summary>
        /// svfloat64_t svget3[_f64](svfloat64x3_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<double> ExtractOneVectorFromATupleOfThreeVectors((Vector<double> tuple1, Vector<double> tuple2, Vector<double> tuple3), ulong imm_index) => ExtractOneVectorFromATupleOfThreeVectors(tuple1,, imm_index);

        /// <summary>
        /// svfloat16_t svget3[_f16](svfloat16x3_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<half> ExtractOneVectorFromATupleOfThreeVectors((Vector<half> tuple1, Vector<half> tuple2, Vector<half> tuple3), ulong imm_index) => ExtractOneVectorFromATupleOfThreeVectors(tuple1,, imm_index);

        /// <summary>
        /// svint16_t svget3[_s16](svint16x3_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<short> ExtractOneVectorFromATupleOfThreeVectors((Vector<short> tuple1, Vector<short> tuple2, Vector<short> tuple3), ulong imm_index) => ExtractOneVectorFromATupleOfThreeVectors(tuple1,, imm_index);

        /// <summary>
        /// svint32_t svget3[_s32](svint32x3_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<int> ExtractOneVectorFromATupleOfThreeVectors((Vector<int> tuple1, Vector<int> tuple2, Vector<int> tuple3), ulong imm_index) => ExtractOneVectorFromATupleOfThreeVectors(tuple1,, imm_index);

        /// <summary>
        /// svint64_t svget3[_s64](svint64x3_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<long> ExtractOneVectorFromATupleOfThreeVectors((Vector<long> tuple1, Vector<long> tuple2, Vector<long> tuple3), ulong imm_index) => ExtractOneVectorFromATupleOfThreeVectors(tuple1,, imm_index);

        /// <summary>
        /// svint8_t svget3[_s8](svint8x3_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<sbyte> ExtractOneVectorFromATupleOfThreeVectors((Vector<sbyte> tuple1, Vector<sbyte> tuple2, Vector<sbyte> tuple3), ulong imm_index) => ExtractOneVectorFromATupleOfThreeVectors(tuple1,, imm_index);

        /// <summary>
        /// svfloat32_t svget3[_f32](svfloat32x3_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<float> ExtractOneVectorFromATupleOfThreeVectors((Vector<float> tuple1, Vector<float> tuple2, Vector<float> tuple3), ulong imm_index) => ExtractOneVectorFromATupleOfThreeVectors(tuple1,, imm_index);

        /// <summary>
        /// svuint16_t svget3[_u16](svuint16x3_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<ushort> ExtractOneVectorFromATupleOfThreeVectors((Vector<ushort> tuple1, Vector<ushort> tuple2, Vector<ushort> tuple3), ulong imm_index) => ExtractOneVectorFromATupleOfThreeVectors(tuple1,, imm_index);

        /// <summary>
        /// svuint32_t svget3[_u32](svuint32x3_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<uint> ExtractOneVectorFromATupleOfThreeVectors((Vector<uint> tuple1, Vector<uint> tuple2, Vector<uint> tuple3), ulong imm_index) => ExtractOneVectorFromATupleOfThreeVectors(tuple1,, imm_index);

        /// <summary>
        /// svuint64_t svget3[_u64](svuint64x3_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<ulong> ExtractOneVectorFromATupleOfThreeVectors((Vector<ulong> tuple1, Vector<ulong> tuple2, Vector<ulong> tuple3), ulong imm_index) => ExtractOneVectorFromATupleOfThreeVectors(tuple1,, imm_index);


        // Extract one vector from a tuple of two vectors

        /// <summary>
        /// svbfloat16_t svget2[_bf16](svbfloat16x2_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<bfloat16> ExtractOneVectorFromATupleOfTwoVectors((Vector<bfloat16> tuple1, Vector<bfloat16> tuple2), ulong imm_index) => ExtractOneVectorFromATupleOfTwoVectors(tuple1,, imm_index);

        /// <summary>
        /// svuint8_t svget2[_u8](svuint8x2_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<byte> ExtractOneVectorFromATupleOfTwoVectors((Vector<byte> tuple1, Vector<byte> tuple2), ulong imm_index) => ExtractOneVectorFromATupleOfTwoVectors(tuple1,, imm_index);

        /// <summary>
        /// svfloat64_t svget2[_f64](svfloat64x2_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<double> ExtractOneVectorFromATupleOfTwoVectors((Vector<double> tuple1, Vector<double> tuple2), ulong imm_index) => ExtractOneVectorFromATupleOfTwoVectors(tuple1,, imm_index);

        /// <summary>
        /// svfloat16_t svget2[_f16](svfloat16x2_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<half> ExtractOneVectorFromATupleOfTwoVectors((Vector<half> tuple1, Vector<half> tuple2), ulong imm_index) => ExtractOneVectorFromATupleOfTwoVectors(tuple1,, imm_index);

        /// <summary>
        /// svint16_t svget2[_s16](svint16x2_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<short> ExtractOneVectorFromATupleOfTwoVectors((Vector<short> tuple1, Vector<short> tuple2), ulong imm_index) => ExtractOneVectorFromATupleOfTwoVectors(tuple1,, imm_index);

        /// <summary>
        /// svint32_t svget2[_s32](svint32x2_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<int> ExtractOneVectorFromATupleOfTwoVectors((Vector<int> tuple1, Vector<int> tuple2), ulong imm_index) => ExtractOneVectorFromATupleOfTwoVectors(tuple1,, imm_index);

        /// <summary>
        /// svint64_t svget2[_s64](svint64x2_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<long> ExtractOneVectorFromATupleOfTwoVectors((Vector<long> tuple1, Vector<long> tuple2), ulong imm_index) => ExtractOneVectorFromATupleOfTwoVectors(tuple1,, imm_index);

        /// <summary>
        /// svint8_t svget2[_s8](svint8x2_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<sbyte> ExtractOneVectorFromATupleOfTwoVectors((Vector<sbyte> tuple1, Vector<sbyte> tuple2), ulong imm_index) => ExtractOneVectorFromATupleOfTwoVectors(tuple1,, imm_index);

        /// <summary>
        /// svfloat32_t svget2[_f32](svfloat32x2_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<float> ExtractOneVectorFromATupleOfTwoVectors((Vector<float> tuple1, Vector<float> tuple2), ulong imm_index) => ExtractOneVectorFromATupleOfTwoVectors(tuple1,, imm_index);

        /// <summary>
        /// svuint16_t svget2[_u16](svuint16x2_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<ushort> ExtractOneVectorFromATupleOfTwoVectors((Vector<ushort> tuple1, Vector<ushort> tuple2), ulong imm_index) => ExtractOneVectorFromATupleOfTwoVectors(tuple1,, imm_index);

        /// <summary>
        /// svuint32_t svget2[_u32](svuint32x2_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<uint> ExtractOneVectorFromATupleOfTwoVectors((Vector<uint> tuple1, Vector<uint> tuple2), ulong imm_index) => ExtractOneVectorFromATupleOfTwoVectors(tuple1,, imm_index);

        /// <summary>
        /// svuint64_t svget2[_u64](svuint64x2_t tuple, uint64_t imm_index)
        /// </summary>
        public static unsafe Vector<ulong> ExtractOneVectorFromATupleOfTwoVectors((Vector<ulong> tuple1, Vector<ulong> tuple2), ulong imm_index) => ExtractOneVectorFromATupleOfTwoVectors(tuple1,, imm_index);


        // Reinterpret vector contents

        /// <summary>
        /// svbfloat16_t svreinterpret_bf16[_bf16](svbfloat16_t op)
        /// </summary>
        public static unsafe Vector<bfloat16> ReinterpretVectorContents(Vector<bfloat16> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svbfloat16_t svreinterpret_bf16[_u8](svuint8_t op)
        /// </summary>
        public static unsafe Vector<bfloat16> ReinterpretVectorContents(Vector<byte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svbfloat16_t svreinterpret_bf16[_f64](svfloat64_t op)
        /// </summary>
        public static unsafe Vector<bfloat16> ReinterpretVectorContents(Vector<double> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svbfloat16_t svreinterpret_bf16[_f16](svfloat16_t op)
        /// </summary>
        public static unsafe Vector<bfloat16> ReinterpretVectorContents(Vector<half> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svbfloat16_t svreinterpret_bf16[_s16](svint16_t op)
        /// </summary>
        public static unsafe Vector<bfloat16> ReinterpretVectorContents(Vector<short> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svbfloat16_t svreinterpret_bf16[_s32](svint32_t op)
        /// </summary>
        public static unsafe Vector<bfloat16> ReinterpretVectorContents(Vector<int> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svbfloat16_t svreinterpret_bf16[_s64](svint64_t op)
        /// </summary>
        public static unsafe Vector<bfloat16> ReinterpretVectorContents(Vector<long> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svbfloat16_t svreinterpret_bf16[_s8](svint8_t op)
        /// </summary>
        public static unsafe Vector<bfloat16> ReinterpretVectorContents(Vector<sbyte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svbfloat16_t svreinterpret_bf16[_f32](svfloat32_t op)
        /// </summary>
        public static unsafe Vector<bfloat16> ReinterpretVectorContents(Vector<float> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svbfloat16_t svreinterpret_bf16[_u16](svuint16_t op)
        /// </summary>
        public static unsafe Vector<bfloat16> ReinterpretVectorContents(Vector<ushort> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svbfloat16_t svreinterpret_bf16[_u32](svuint32_t op)
        /// </summary>
        public static unsafe Vector<bfloat16> ReinterpretVectorContents(Vector<uint> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svbfloat16_t svreinterpret_bf16[_u64](svuint64_t op)
        /// </summary>
        public static unsafe Vector<bfloat16> ReinterpretVectorContents(Vector<ulong> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint8_t svreinterpret_u8[_bf16](svbfloat16_t op)
        /// </summary>
        public static unsafe Vector<byte> ReinterpretVectorContents(Vector<bfloat16> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint8_t svreinterpret_u8[_f64](svfloat64_t op)
        /// </summary>
        public static unsafe Vector<byte> ReinterpretVectorContents(Vector<double> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint8_t svreinterpret_u8[_f16](svfloat16_t op)
        /// </summary>
        public static unsafe Vector<byte> ReinterpretVectorContents(Vector<half> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint8_t svreinterpret_u8[_s16](svint16_t op)
        /// </summary>
        public static unsafe Vector<byte> ReinterpretVectorContents(Vector<short> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint8_t svreinterpret_u8[_s32](svint32_t op)
        /// </summary>
        public static unsafe Vector<byte> ReinterpretVectorContents(Vector<int> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint8_t svreinterpret_u8[_s64](svint64_t op)
        /// </summary>
        public static unsafe Vector<byte> ReinterpretVectorContents(Vector<long> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint8_t svreinterpret_u8[_s8](svint8_t op)
        /// </summary>
        public static unsafe Vector<byte> ReinterpretVectorContents(Vector<sbyte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint8_t svreinterpret_u8[_f32](svfloat32_t op)
        /// </summary>
        public static unsafe Vector<byte> ReinterpretVectorContents(Vector<float> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint8_t svreinterpret_u8[_u8](svuint8_t op)
        /// </summary>
        public static unsafe Vector<byte> ReinterpretVectorContents(Vector<byte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint8_t svreinterpret_u8[_u16](svuint16_t op)
        /// </summary>
        public static unsafe Vector<byte> ReinterpretVectorContents(Vector<ushort> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint8_t svreinterpret_u8[_u32](svuint32_t op)
        /// </summary>
        public static unsafe Vector<byte> ReinterpretVectorContents(Vector<uint> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint8_t svreinterpret_u8[_u64](svuint64_t op)
        /// </summary>
        public static unsafe Vector<byte> ReinterpretVectorContents(Vector<ulong> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat64_t svreinterpret_f64[_bf16](svbfloat16_t op)
        /// </summary>
        public static unsafe Vector<double> ReinterpretVectorContents(Vector<bfloat16> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat64_t svreinterpret_f64[_u8](svuint8_t op)
        /// </summary>
        public static unsafe Vector<double> ReinterpretVectorContents(Vector<byte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat64_t svreinterpret_f64[_f16](svfloat16_t op)
        /// </summary>
        public static unsafe Vector<double> ReinterpretVectorContents(Vector<half> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat64_t svreinterpret_f64[_s16](svint16_t op)
        /// </summary>
        public static unsafe Vector<double> ReinterpretVectorContents(Vector<short> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat64_t svreinterpret_f64[_s32](svint32_t op)
        /// </summary>
        public static unsafe Vector<double> ReinterpretVectorContents(Vector<int> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat64_t svreinterpret_f64[_f32](svfloat32_t op)
        /// </summary>
        public static unsafe Vector<double> ReinterpretVectorContents(Vector<float> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat64_t svreinterpret_f64[_f64](svfloat64_t op)
        /// </summary>
        public static unsafe Vector<double> ReinterpretVectorContents(Vector<double> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat64_t svreinterpret_f64[_s64](svint64_t op)
        /// </summary>
        public static unsafe Vector<double> ReinterpretVectorContents(Vector<long> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat64_t svreinterpret_f64[_s8](svint8_t op)
        /// </summary>
        public static unsafe Vector<double> ReinterpretVectorContents(Vector<sbyte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat64_t svreinterpret_f64[_u16](svuint16_t op)
        /// </summary>
        public static unsafe Vector<double> ReinterpretVectorContents(Vector<ushort> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat64_t svreinterpret_f64[_u32](svuint32_t op)
        /// </summary>
        public static unsafe Vector<double> ReinterpretVectorContents(Vector<uint> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat64_t svreinterpret_f64[_u64](svuint64_t op)
        /// </summary>
        public static unsafe Vector<double> ReinterpretVectorContents(Vector<ulong> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat16_t svreinterpret_f16[_bf16](svbfloat16_t op)
        /// </summary>
        public static unsafe Vector<half> ReinterpretVectorContents(Vector<bfloat16> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat16_t svreinterpret_f16[_f16](svfloat16_t op)
        /// </summary>
        public static unsafe Vector<half> ReinterpretVectorContents(Vector<half> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat16_t svreinterpret_f16[_u8](svuint8_t op)
        /// </summary>
        public static unsafe Vector<half> ReinterpretVectorContents(Vector<byte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat16_t svreinterpret_f16[_f64](svfloat64_t op)
        /// </summary>
        public static unsafe Vector<half> ReinterpretVectorContents(Vector<double> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat16_t svreinterpret_f16[_s16](svint16_t op)
        /// </summary>
        public static unsafe Vector<half> ReinterpretVectorContents(Vector<short> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat16_t svreinterpret_f16[_s32](svint32_t op)
        /// </summary>
        public static unsafe Vector<half> ReinterpretVectorContents(Vector<int> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat16_t svreinterpret_f16[_s64](svint64_t op)
        /// </summary>
        public static unsafe Vector<half> ReinterpretVectorContents(Vector<long> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat16_t svreinterpret_f16[_s8](svint8_t op)
        /// </summary>
        public static unsafe Vector<half> ReinterpretVectorContents(Vector<sbyte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat16_t svreinterpret_f16[_f32](svfloat32_t op)
        /// </summary>
        public static unsafe Vector<half> ReinterpretVectorContents(Vector<float> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat16_t svreinterpret_f16[_u16](svuint16_t op)
        /// </summary>
        public static unsafe Vector<half> ReinterpretVectorContents(Vector<ushort> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat16_t svreinterpret_f16[_u32](svuint32_t op)
        /// </summary>
        public static unsafe Vector<half> ReinterpretVectorContents(Vector<uint> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat16_t svreinterpret_f16[_u64](svuint64_t op)
        /// </summary>
        public static unsafe Vector<half> ReinterpretVectorContents(Vector<ulong> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint16_t svreinterpret_s16[_bf16](svbfloat16_t op)
        /// </summary>
        public static unsafe Vector<short> ReinterpretVectorContents(Vector<bfloat16> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint16_t svreinterpret_s16[_u8](svuint8_t op)
        /// </summary>
        public static unsafe Vector<short> ReinterpretVectorContents(Vector<byte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint16_t svreinterpret_s16[_f64](svfloat64_t op)
        /// </summary>
        public static unsafe Vector<short> ReinterpretVectorContents(Vector<double> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint16_t svreinterpret_s16[_f16](svfloat16_t op)
        /// </summary>
        public static unsafe Vector<short> ReinterpretVectorContents(Vector<half> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint16_t svreinterpret_s16[_s32](svint32_t op)
        /// </summary>
        public static unsafe Vector<short> ReinterpretVectorContents(Vector<int> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint16_t svreinterpret_s16[_s64](svint64_t op)
        /// </summary>
        public static unsafe Vector<short> ReinterpretVectorContents(Vector<long> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint16_t svreinterpret_s16[_s8](svint8_t op)
        /// </summary>
        public static unsafe Vector<short> ReinterpretVectorContents(Vector<sbyte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint16_t svreinterpret_s16[_f32](svfloat32_t op)
        /// </summary>
        public static unsafe Vector<short> ReinterpretVectorContents(Vector<float> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint16_t svreinterpret_s16[_s16](svint16_t op)
        /// </summary>
        public static unsafe Vector<short> ReinterpretVectorContents(Vector<short> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint16_t svreinterpret_s16[_u16](svuint16_t op)
        /// </summary>
        public static unsafe Vector<short> ReinterpretVectorContents(Vector<ushort> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint16_t svreinterpret_s16[_u32](svuint32_t op)
        /// </summary>
        public static unsafe Vector<short> ReinterpretVectorContents(Vector<uint> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint16_t svreinterpret_s16[_u64](svuint64_t op)
        /// </summary>
        public static unsafe Vector<short> ReinterpretVectorContents(Vector<ulong> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint32_t svreinterpret_s32[_bf16](svbfloat16_t op)
        /// </summary>
        public static unsafe Vector<int> ReinterpretVectorContents(Vector<bfloat16> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint32_t svreinterpret_s32[_u8](svuint8_t op)
        /// </summary>
        public static unsafe Vector<int> ReinterpretVectorContents(Vector<byte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint32_t svreinterpret_s32[_f64](svfloat64_t op)
        /// </summary>
        public static unsafe Vector<int> ReinterpretVectorContents(Vector<double> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint32_t svreinterpret_s32[_f16](svfloat16_t op)
        /// </summary>
        public static unsafe Vector<int> ReinterpretVectorContents(Vector<half> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint32_t svreinterpret_s32[_s16](svint16_t op)
        /// </summary>
        public static unsafe Vector<int> ReinterpretVectorContents(Vector<short> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint32_t svreinterpret_s32[_s64](svint64_t op)
        /// </summary>
        public static unsafe Vector<int> ReinterpretVectorContents(Vector<long> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint32_t svreinterpret_s32[_s8](svint8_t op)
        /// </summary>
        public static unsafe Vector<int> ReinterpretVectorContents(Vector<sbyte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint32_t svreinterpret_s32[_f32](svfloat32_t op)
        /// </summary>
        public static unsafe Vector<int> ReinterpretVectorContents(Vector<float> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint32_t svreinterpret_s32[_s32](svint32_t op)
        /// </summary>
        public static unsafe Vector<int> ReinterpretVectorContents(Vector<int> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint32_t svreinterpret_s32[_u16](svuint16_t op)
        /// </summary>
        public static unsafe Vector<int> ReinterpretVectorContents(Vector<ushort> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint32_t svreinterpret_s32[_u32](svuint32_t op)
        /// </summary>
        public static unsafe Vector<int> ReinterpretVectorContents(Vector<uint> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint32_t svreinterpret_s32[_u64](svuint64_t op)
        /// </summary>
        public static unsafe Vector<int> ReinterpretVectorContents(Vector<ulong> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint64_t svreinterpret_s64[_bf16](svbfloat16_t op)
        /// </summary>
        public static unsafe Vector<long> ReinterpretVectorContents(Vector<bfloat16> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint64_t svreinterpret_s64[_u8](svuint8_t op)
        /// </summary>
        public static unsafe Vector<long> ReinterpretVectorContents(Vector<byte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint64_t svreinterpret_s64[_f64](svfloat64_t op)
        /// </summary>
        public static unsafe Vector<long> ReinterpretVectorContents(Vector<double> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint64_t svreinterpret_s64[_f16](svfloat16_t op)
        /// </summary>
        public static unsafe Vector<long> ReinterpretVectorContents(Vector<half> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint64_t svreinterpret_s64[_s16](svint16_t op)
        /// </summary>
        public static unsafe Vector<long> ReinterpretVectorContents(Vector<short> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint64_t svreinterpret_s64[_s32](svint32_t op)
        /// </summary>
        public static unsafe Vector<long> ReinterpretVectorContents(Vector<int> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint64_t svreinterpret_s64[_s8](svint8_t op)
        /// </summary>
        public static unsafe Vector<long> ReinterpretVectorContents(Vector<sbyte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint64_t svreinterpret_s64[_f32](svfloat32_t op)
        /// </summary>
        public static unsafe Vector<long> ReinterpretVectorContents(Vector<float> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint64_t svreinterpret_s64[_s64](svint64_t op)
        /// </summary>
        public static unsafe Vector<long> ReinterpretVectorContents(Vector<long> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint64_t svreinterpret_s64[_u16](svuint16_t op)
        /// </summary>
        public static unsafe Vector<long> ReinterpretVectorContents(Vector<ushort> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint64_t svreinterpret_s64[_u32](svuint32_t op)
        /// </summary>
        public static unsafe Vector<long> ReinterpretVectorContents(Vector<uint> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint64_t svreinterpret_s64[_u64](svuint64_t op)
        /// </summary>
        public static unsafe Vector<long> ReinterpretVectorContents(Vector<ulong> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint8_t svreinterpret_s8[_bf16](svbfloat16_t op)
        /// </summary>
        public static unsafe Vector<sbyte> ReinterpretVectorContents(Vector<bfloat16> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint8_t svreinterpret_s8[_u8](svuint8_t op)
        /// </summary>
        public static unsafe Vector<sbyte> ReinterpretVectorContents(Vector<byte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint8_t svreinterpret_s8[_f64](svfloat64_t op)
        /// </summary>
        public static unsafe Vector<sbyte> ReinterpretVectorContents(Vector<double> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint8_t svreinterpret_s8[_f16](svfloat16_t op)
        /// </summary>
        public static unsafe Vector<sbyte> ReinterpretVectorContents(Vector<half> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint8_t svreinterpret_s8[_s16](svint16_t op)
        /// </summary>
        public static unsafe Vector<sbyte> ReinterpretVectorContents(Vector<short> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint8_t svreinterpret_s8[_s32](svint32_t op)
        /// </summary>
        public static unsafe Vector<sbyte> ReinterpretVectorContents(Vector<int> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint8_t svreinterpret_s8[_s64](svint64_t op)
        /// </summary>
        public static unsafe Vector<sbyte> ReinterpretVectorContents(Vector<long> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint8_t svreinterpret_s8[_f32](svfloat32_t op)
        /// </summary>
        public static unsafe Vector<sbyte> ReinterpretVectorContents(Vector<float> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint8_t svreinterpret_s8[_s8](svint8_t op)
        /// </summary>
        public static unsafe Vector<sbyte> ReinterpretVectorContents(Vector<sbyte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint8_t svreinterpret_s8[_u16](svuint16_t op)
        /// </summary>
        public static unsafe Vector<sbyte> ReinterpretVectorContents(Vector<ushort> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint8_t svreinterpret_s8[_u32](svuint32_t op)
        /// </summary>
        public static unsafe Vector<sbyte> ReinterpretVectorContents(Vector<uint> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svint8_t svreinterpret_s8[_u64](svuint64_t op)
        /// </summary>
        public static unsafe Vector<sbyte> ReinterpretVectorContents(Vector<ulong> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat32_t svreinterpret_f32[_bf16](svbfloat16_t op)
        /// </summary>
        public static unsafe Vector<float> ReinterpretVectorContents(Vector<bfloat16> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat32_t svreinterpret_f32[_f16](svfloat16_t op)
        /// </summary>
        public static unsafe Vector<float> ReinterpretVectorContents(Vector<half> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat32_t svreinterpret_f32[_f32](svfloat32_t op)
        /// </summary>
        public static unsafe Vector<float> ReinterpretVectorContents(Vector<float> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat32_t svreinterpret_f32[_u8](svuint8_t op)
        /// </summary>
        public static unsafe Vector<float> ReinterpretVectorContents(Vector<byte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat32_t svreinterpret_f32[_f64](svfloat64_t op)
        /// </summary>
        public static unsafe Vector<float> ReinterpretVectorContents(Vector<double> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat32_t svreinterpret_f32[_s16](svint16_t op)
        /// </summary>
        public static unsafe Vector<float> ReinterpretVectorContents(Vector<short> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat32_t svreinterpret_f32[_s32](svint32_t op)
        /// </summary>
        public static unsafe Vector<float> ReinterpretVectorContents(Vector<int> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat32_t svreinterpret_f32[_s64](svint64_t op)
        /// </summary>
        public static unsafe Vector<float> ReinterpretVectorContents(Vector<long> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat32_t svreinterpret_f32[_s8](svint8_t op)
        /// </summary>
        public static unsafe Vector<float> ReinterpretVectorContents(Vector<sbyte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat32_t svreinterpret_f32[_u16](svuint16_t op)
        /// </summary>
        public static unsafe Vector<float> ReinterpretVectorContents(Vector<ushort> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat32_t svreinterpret_f32[_u32](svuint32_t op)
        /// </summary>
        public static unsafe Vector<float> ReinterpretVectorContents(Vector<uint> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svfloat32_t svreinterpret_f32[_u64](svuint64_t op)
        /// </summary>
        public static unsafe Vector<float> ReinterpretVectorContents(Vector<ulong> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint16_t svreinterpret_u16[_bf16](svbfloat16_t op)
        /// </summary>
        public static unsafe Vector<ushort> ReinterpretVectorContents(Vector<bfloat16> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint16_t svreinterpret_u16[_u8](svuint8_t op)
        /// </summary>
        public static unsafe Vector<ushort> ReinterpretVectorContents(Vector<byte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint16_t svreinterpret_u16[_f64](svfloat64_t op)
        /// </summary>
        public static unsafe Vector<ushort> ReinterpretVectorContents(Vector<double> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint16_t svreinterpret_u16[_f16](svfloat16_t op)
        /// </summary>
        public static unsafe Vector<ushort> ReinterpretVectorContents(Vector<half> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint16_t svreinterpret_u16[_s16](svint16_t op)
        /// </summary>
        public static unsafe Vector<ushort> ReinterpretVectorContents(Vector<short> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint16_t svreinterpret_u16[_s32](svint32_t op)
        /// </summary>
        public static unsafe Vector<ushort> ReinterpretVectorContents(Vector<int> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint16_t svreinterpret_u16[_s64](svint64_t op)
        /// </summary>
        public static unsafe Vector<ushort> ReinterpretVectorContents(Vector<long> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint16_t svreinterpret_u16[_s8](svint8_t op)
        /// </summary>
        public static unsafe Vector<ushort> ReinterpretVectorContents(Vector<sbyte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint16_t svreinterpret_u16[_f32](svfloat32_t op)
        /// </summary>
        public static unsafe Vector<ushort> ReinterpretVectorContents(Vector<float> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint16_t svreinterpret_u16[_u16](svuint16_t op)
        /// </summary>
        public static unsafe Vector<ushort> ReinterpretVectorContents(Vector<ushort> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint16_t svreinterpret_u16[_u32](svuint32_t op)
        /// </summary>
        public static unsafe Vector<ushort> ReinterpretVectorContents(Vector<uint> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint16_t svreinterpret_u16[_u64](svuint64_t op)
        /// </summary>
        public static unsafe Vector<ushort> ReinterpretVectorContents(Vector<ulong> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint32_t svreinterpret_u32[_bf16](svbfloat16_t op)
        /// </summary>
        public static unsafe Vector<uint> ReinterpretVectorContents(Vector<bfloat16> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint32_t svreinterpret_u32[_u8](svuint8_t op)
        /// </summary>
        public static unsafe Vector<uint> ReinterpretVectorContents(Vector<byte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint32_t svreinterpret_u32[_f64](svfloat64_t op)
        /// </summary>
        public static unsafe Vector<uint> ReinterpretVectorContents(Vector<double> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint32_t svreinterpret_u32[_f16](svfloat16_t op)
        /// </summary>
        public static unsafe Vector<uint> ReinterpretVectorContents(Vector<half> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint32_t svreinterpret_u32[_s16](svint16_t op)
        /// </summary>
        public static unsafe Vector<uint> ReinterpretVectorContents(Vector<short> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint32_t svreinterpret_u32[_s32](svint32_t op)
        /// </summary>
        public static unsafe Vector<uint> ReinterpretVectorContents(Vector<int> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint32_t svreinterpret_u32[_s64](svint64_t op)
        /// </summary>
        public static unsafe Vector<uint> ReinterpretVectorContents(Vector<long> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint32_t svreinterpret_u32[_s8](svint8_t op)
        /// </summary>
        public static unsafe Vector<uint> ReinterpretVectorContents(Vector<sbyte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint32_t svreinterpret_u32[_f32](svfloat32_t op)
        /// </summary>
        public static unsafe Vector<uint> ReinterpretVectorContents(Vector<float> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint32_t svreinterpret_u32[_u16](svuint16_t op)
        /// </summary>
        public static unsafe Vector<uint> ReinterpretVectorContents(Vector<ushort> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint32_t svreinterpret_u32[_u32](svuint32_t op)
        /// </summary>
        public static unsafe Vector<uint> ReinterpretVectorContents(Vector<uint> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint32_t svreinterpret_u32[_u64](svuint64_t op)
        /// </summary>
        public static unsafe Vector<uint> ReinterpretVectorContents(Vector<ulong> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint64_t svreinterpret_u64[_bf16](svbfloat16_t op)
        /// </summary>
        public static unsafe Vector<ulong> ReinterpretVectorContents(Vector<bfloat16> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint64_t svreinterpret_u64[_u8](svuint8_t op)
        /// </summary>
        public static unsafe Vector<ulong> ReinterpretVectorContents(Vector<byte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint64_t svreinterpret_u64[_f64](svfloat64_t op)
        /// </summary>
        public static unsafe Vector<ulong> ReinterpretVectorContents(Vector<double> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint64_t svreinterpret_u64[_f16](svfloat16_t op)
        /// </summary>
        public static unsafe Vector<ulong> ReinterpretVectorContents(Vector<half> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint64_t svreinterpret_u64[_s16](svint16_t op)
        /// </summary>
        public static unsafe Vector<ulong> ReinterpretVectorContents(Vector<short> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint64_t svreinterpret_u64[_s32](svint32_t op)
        /// </summary>
        public static unsafe Vector<ulong> ReinterpretVectorContents(Vector<int> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint64_t svreinterpret_u64[_s64](svint64_t op)
        /// </summary>
        public static unsafe Vector<ulong> ReinterpretVectorContents(Vector<long> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint64_t svreinterpret_u64[_s8](svint8_t op)
        /// </summary>
        public static unsafe Vector<ulong> ReinterpretVectorContents(Vector<sbyte> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint64_t svreinterpret_u64[_f32](svfloat32_t op)
        /// </summary>
        public static unsafe Vector<ulong> ReinterpretVectorContents(Vector<float> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint64_t svreinterpret_u64[_u16](svuint16_t op)
        /// </summary>
        public static unsafe Vector<ulong> ReinterpretVectorContents(Vector<ushort> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint64_t svreinterpret_u64[_u32](svuint32_t op)
        /// </summary>
        public static unsafe Vector<ulong> ReinterpretVectorContents(Vector<uint> value) => ReinterpretVectorContents(value);

        /// <summary>
        /// svuint64_t svreinterpret_u64[_u64](svuint64_t op)
        /// </summary>
        public static unsafe Vector<ulong> ReinterpretVectorContents(Vector<ulong> value) => ReinterpretVectorContents(value);

    }
}

