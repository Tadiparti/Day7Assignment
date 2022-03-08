using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Assignment
{
    public delegate void SimpleDelegate(int a, int b); 
    class MultiDelegates
    {
        public void Add(int a , int b)
        {
            Console.WriteLine("Add Result:{0}", a + b);
        }
        public void Substrate(int a, int b)
        {
            Console.WriteLine("Subtract Result:{0}", a - b);
        }
        public void Division(int a , int b)
        {
            Console.WriteLine("Division Result:{0}",a/ b);
        }
    }
    //Main method
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Delegate Example********");
            MultiDelegates m = new MultiDelegates();
            //instantiate delegate with add method
            SimpleDelegate delg = m.Add;
            delg += m.Substrate;
            delg += m.Division;
            delg(50, 40);
            //delg -= m.Subtract;
            //delg(25,69);
            Console.ReadLine();
        }
    }
}
