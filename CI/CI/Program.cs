using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI
{
     class A
    {
        public void Parent() {
            Console.WriteLine("Parent Class");
        }
    }
    class B : A
    {
        public void Child()
        {
            Console.WriteLine("Child Class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B ch = new B();
            ch.Parent();
            ch.Child();
        }
    }
}
