using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            var  region = decimal.Parse(Console.ReadLine());
            var gust = decimal.Parse(Console.ReadLine());
            var Sum = 0M;

            for (int i = 0; i < region; i++)
            {
                var a = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
                var sum = a[0] / a[1];
                Sum += sum;
            }
            if (gust != 0)
            {
                Sum /= gust;

            }
            Console.WriteLine("{0:F3}",Sum);


        }
    }
}
