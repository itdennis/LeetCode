using LeetCode_Practice.Codes;
using System;

namespace LeetCode_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //await Customer.AsyncStreamsDemo();
            //await Lc14.Run(new string[] { "flower", "flow", "flight"});
            //await Lc15.Run("[");
            //await Lc26.Run(new int[] { 1, 1, 2 });
            //await Lc15.Run("[");
            //await Lc27.Run(new int[] { 1,2,3,2,4 }, 2);
            //await Lc28.Run("hello", "ll");
            //Console.WriteLine(await Lc35.Run(new int[] { 1, 3, 5 }, 3));
            //Console.WriteLine(await Lc704.Run(new int[] { -1, 0, 3, 5, 9, 12 }, 2));
            //Console.WriteLine(await Lc69.Run(2147395599));
            //Console.WriteLine(await Lc53.Run(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));

            LeetCode runner = new Lc67();
            runner.Run();


            Console.ReadKey();
        }
    }
}
