using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAvg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            SA(arr);
        }
        static void SA(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++){
                sum += arr[i];
            }
            Console.WriteLine("합: "+ sum);
            Console.WriteLine("평균: "+(sum / arr.Length));
        }
    }
}
