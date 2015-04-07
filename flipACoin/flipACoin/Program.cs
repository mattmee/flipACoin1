using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flipACoin
{
    class Program
    {
        static Random rng = new Random();
        static int headsCounter = 0;
        static int tailsCounter = 0;

        static void Main(string[] args)
        {


            for (int i = 0; i < 1000; i++)
            {
                FlipACoin();
            }
            Console.WriteLine("Heads: " + headsCounter);
            Console.WriteLine("Tails: " + tailsCounter);
            Console.ReadKey();
        }
        public static string FlipACoin()
        {
            if (rng.Next(2) == 0)
            {
                headsCounter++;
                return "heads";//heads
            }
            else
            {
                tailsCounter++;
                return "tails";
            }
        }
    }
}
