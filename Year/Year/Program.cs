using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("년도를 입력하세요: ");
            string st = Console.ReadLine();
            int year = int.Parse(st);
            if (year%4 == 0)
            {
                if ((year % 400 == 0) || year % 100 != 0) Console.WriteLine("윤년입니다.");
                else Console.WriteLine("평년입니다.");
            }
            else Console.WriteLine("평년입니다.");

        }
    }
}
