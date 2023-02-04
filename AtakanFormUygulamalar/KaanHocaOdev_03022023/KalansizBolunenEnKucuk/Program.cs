using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalansizBolunenEnKucuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen başlangıç sayısı giriniz.");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen bitiş sayısı giriniz.");
            int stop = int.Parse(Console.ReadLine());

            getSmallestNumber(start,stop);
        }

        private static int getSmallestNumber(int start, int stop)
        {
            int reelMulti = 1;
            int min = 0;
            for (int i = start; i <= stop; i++)
            {
                reelMulti *= i;
            }

            for (int j = start; j <=stop; j++)
            {
                for (int k=stop; k <=reelMulti; k++)
                {
                    if (k%j==0)
                    {
                        min = k / j;
                    }

                }
            }
            return 0;
        }

    }
}
