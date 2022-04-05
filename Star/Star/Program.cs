using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=6; i++)
            {
                for(int j=i; j<6; j++)
                {
                    Console.Write(" ");
                }
                for(int j=1; j<=2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
