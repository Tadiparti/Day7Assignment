using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Assignment
{
    public delegate void SampleDelegate(int a , int b);
    class PassDelegate
    {
        public void Add(int a , int b)
        {
            Console.WriteLine("Add Result:{0}", a + b);
        }
        public void Multiply(int a , int b)
        {
            Console.WriteLine("Multiply Result:{0}", a * b);
        }
        public void Division(int a , int b)
        {
            Console.WriteLine("Division Result:{0}", a / b);
        }
    }
    //Main method
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Delegate Sample********");
            PassDelegate d = new PassDelegate();
            SampleMethod(d.Add, 12, 60);
            SampleMethod(d.Multiply, 56, 30);
            SampleMethod(d.Division, 70, 26);
            Console.ReadLine();
        }
        static void SampleMethod(SampleDelegate delg,int a ,int b)
        {
            delg(a, b);
        }
    }
}
