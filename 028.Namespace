using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    public class Car
    {
        public void Go() => Console.WriteLine("A Namespace");
    }
}
namespace B
{
    public class Car
    {
        public void Go() => Console.WriteLine("B Namespace");
    }
}
namespace DotNet_Core_028_Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A.Car acar = new A.Car();
            B.Car bcar = new B.Car();

            acar.Go();
            bcar.Go();
        }
    }
}
