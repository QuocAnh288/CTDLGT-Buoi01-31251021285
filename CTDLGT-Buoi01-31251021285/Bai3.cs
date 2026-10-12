using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace CTDLGT_Buoi01_31251021285
{
    internal class Bai3
    {
        static long Bai3VerA(long[] a)
        {
            int n = a.Length;
            long maxsum = a[0];
            for(int i = 0; i < n; i++)
            {
                long sum = 0;
                for(int j =i; j < n; j++)
                {
                    sum += a[j];
                    if(sum > maxsum)
                    {
                        maxsum = sum;
                    }
                }
            }
            return maxsum;
        }
        static long Bai3VerB(long[] a)
        {
            int n = a.Length;
            long high = a[0];
            long max = a[0];
            for (int i = 1; i < n; i++)
            {
                high = Math.Max(a[i], high + a[i]);
                max = Math.Max(max, high);
            }

            return max;
        }
        
        static void Main(string[] augs)
        {
            long a = Bai3VerA([-5,4,6,87,5,3,-10,900,-100]);
            Console.WriteLine(a);
            long b = Bai3VerA([-2, 3, -1, 4]);
            Console.WriteLine(b);
        }
    }
}
