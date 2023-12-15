using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Correcao
{
    public class MaximoMdc
    {
        static int FindMdc(int x, int y)
        {
            //BigInteger.GreatestCommonDivisor(x, y);

            if (y == 0)
                return x;

            return FindMdc(y, x % y);
        }

        public static List<int> gdcArrays(List<int> list)
        {
            //[3, 6, 7 , 9]
            int n = list.Count;
            int gdc = 1;

            for(int i = 0; i< n - 1; i++)
            {
                var thisGdc = FindMdc(list[i], list[i + 1]);
                gdc = Math.Max(gdc, thisGdc);
            }

            int length = 0;
            int curr = 0;

            for(int i = 0; i < n; i++)
            {
                if (list[i] % gdc == 0)
                {
                    curr++;
                    length = Math.Max(length, curr);
                }
                else
                {
                    curr = 0;
                }
            }

            return new List<int> { gdc, length };
        }
    }
}
