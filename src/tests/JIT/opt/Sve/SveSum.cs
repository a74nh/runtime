using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;
using Xunit;

namespace CodeGenTests
{
    public static class SveSum
    {
		public static unsafe int sum_scalar(ref int* src, int length)
		{
			int ret = 0;
			for (int i=0; i<length; i++)
			{
			  ret += src[i];
			}
			return ret;
		}

		public static unsafe int sum_vector128(ref int* srcBytes, int length)
		{
			Vector128<int> total = Vector128.Create((int)0);
			int* src = srcBytes;
			int vector_length = 16/sizeof(int);

			for (int i = 0; i+vector_length <= length; i+=vector_length)
			{
			  Vector128<int> vec = Vector128.LoadUnsafe(ref *src);
			  total = Vector128.Add(vec, total);
			  src += vector_length;
			}

			return Vector128.Sum(total) + sum_scalar(ref src, length%vector_length);
		}

		public static unsafe int sum_advsimd(ref int* srcBytes, int length)
		{
			Vector128<int> total = Vector128.Create((int)0);
			int* src = srcBytes;
			int vector_length = 16/sizeof(int);

			for (int i = 0; i+vector_length <= length; i+=vector_length)
			{
			  Vector128<int> vec = AdvSimd.LoadVector128(src);
			  total = AdvSimd.Add(vec, total);
			  src += vector_length;
			}

			return AdvSimd.Arm64.AddAcross(total).ToScalar() + sum_scalar(ref src, length%vector_length);
		}

		public static unsafe int sum_sve(ref int* srcBytes, int length)
		{
			Vector<int> total = new Vector<int>(0);
			int* src = srcBytes;
			int elems = (int)Sve.Count32BitElements();

			for (int i = 0; i < length + elems; i += elems)
			{
			  Vector<int> pred = (Vector<int>)Sve.CreateWhileLessThanMask32Bit(i, length);

			  Vector<int> vec = Sve.LoadVector(pred, src);

			  total = Sve.ConditionalSelect(pred, Sve.Add(total, vec), total);

			  src += i;
			}

			return (int)Sve.AddAcross(total).ToScalar();
		}

		// // For performance reasons, it may be better to use an unpredicated loop, followed by a tail.
		// public static unsafe int sum_sve_unpredicated_loop(ref int* srcBytes, int length)
		// {
		// 	Vector<int> total = new Vector<int>(0);
		// 	int* src = srcBytes;
		// 	int elems = (int)Sve.Count32BitElements();

		// 	int i = 0;
		// 	for (i = 0; i < length; i += elems)
		// 	{
		// 	  Vector<int> vec = Sve.LoadVector(pred, src);
		// 	  total = Sve.ConditionalSelect(pred, Sve.Add(total, vec), total);
		// 	}

		// 	// Predicated tail.
		// 	Vector pred = Sve.WhileLessThan(i, length);
		// 	Vector<int> vec = Sve.LoadUnsafe(pred, ref *src, i);
		// 	total = Sve.MergeAdd(pred, vec, total);

		// 	return Sve.AddAcross(total).ToScalar();
		// }

        [Fact]
        public static unsafe int TestEntryPoint()
        {
	        int length = 1002;
	        Span<int> source = new int[length];

	        for (int i = 0; i < source.Length; i++)
	        {
	            source[i] = (int)i;
	        }

	        fixed (int* srcBytes = &MemoryMarshal.GetReference(source))
	        {
	          int* src = srcBytes;

	          int x = sum_scalar(ref src, length);
	          Console.WriteLine($"sum_scalar {x}");

	          x = sum_vector128(ref src, length);
	          Console.WriteLine($"sum_vector128 {x}");

	          x = sum_advsimd(ref src, length);
	          Console.WriteLine($"sum_vector128 {x}");

			  x = sum_sve(ref src, length);
	          Console.WriteLine($"sum_sve {x}");
	          if (x==0)
	            return 0;
	        }

	      	return 100;
      	}
    }
}
