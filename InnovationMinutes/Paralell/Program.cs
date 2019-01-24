using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Paralell
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BigInteger

            BigInteger BigInt1 = new BigInteger(ulong.MaxValue);
            BigInteger BigInt2 = new BigInteger(ulong.MaxValue);
            Console.WriteLine(BigInteger.Add(BigInt1, BigInt2).ToString());

            BigInteger aBigBigger;
            BigInteger aBigSmaller;
            BigInteger.TryParse("999999999999999999999999999999999999999999999999999999999999999999999999999999999999", out aBigBigger);
            BigInteger.TryParse("999999999999999999999999999999999999999999999999999999999999999999999999999999999998", out aBigSmaller);

            if (BigInteger.Compare(aBigBigger, aBigSmaller) > 0 )
                Console.WriteLine(aBigBigger);

            #endregion BigInteger

            #region Truple

            for (Int16 i = 0; i <= 25; i++)
            {
                for (Int16 j = 1; j <= 5; j++)
                {
                    var tuple = DivAndRemainder(i, j);
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\n", i, j, tuple.Item1, tuple.Item2);
                }
            }

            #endregion

            #region python

            IronPythonCall.CallScript();

            #endregion

            Console.ReadKey();
        }

        public static Tuple<Int32, Int32> DivAndRemainder(Int32 i, Int32 j)
        {
            return Tuple.Create(i / j, i % j);
        } 
    }
}
