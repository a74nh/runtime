using System.Runtime.CompilerServices;

namespace CSharpIfConversionTutorials
{
    public class Program
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void Consume<T>(T op1, T op2) {
            Console.WriteLine($"Consume {op1} {op2}");
            return;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void TestAndOrWithElse(uint op1, uint op2) {
            if ((op1 > 3 && op2 == 10) || op2 <= 4) {
                op1 = 9;
            } else {
                op1 = 12;
            }
            Consume(op1, op2);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void TestOr9WithElse(uint op1, uint op2, uint op3, uint op4, uint op5, uint op6, uint op7, uint op8) {
        if (op1 > 1 || op2 > 1 || op3 > 1 || op4 > 1 || op5 > 1 || op6 > 1 || op7 > 1 || op8 > 1 ) {
                op1 = 9;
            } else {
                op1 = 12;
            }
            Consume(op1, op2);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void TestInc(uint op1, uint op2) {
            if (op1 > 1) {
                op2 = 7;
             } else {
                op2 = 8;
            }
            Consume(op1, op2);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void TestInc2(uint op1, uint op2) {
            if (op1 > 5) {
                op1++;
            }
            Consume(op1, op2);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void TestInv(uint op1, uint op2) {
            if (op1 != 7) {
              op2 = ~op2;
            }
            Consume(op1, op2);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void TestAndOrWithElse2(uint op1, uint op2) {
            if (op1 > 3 && op2 == 10 || op2 <= 4) {
                op1 = 9;
            } else {
                op2 = 12;
            }
            Consume(op1, op2);
        }

        public static void Main(string[] args) {
            uint i = 0;
            TestAndOrWithElse(i, i);
            TestAndOrWithElse2(i, i);
            TestOr9WithElse(i, i, i, i, i, i, i, i);
            TestInc(i, i);
            TestInc2(i, i);
            TestInv(i, i);
            Console.WriteLine("Done");
        }
    }
}
