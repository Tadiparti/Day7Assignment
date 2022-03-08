using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Assignment
{
    class Singledelegate
    {

        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        public void sum(int a, int b)  //method "sum"
        {
            Console.WriteLine("(70+50)={0}", a + b);
        }
        public void substract(int a, int b) // method "substract"
        {
            Console.WriteLine("(80-30)={0}", a-b);
        }
        //Main method
        public static void Main(String [] args)
        {
            // creating object "delg" of class "Singledelegate"
            Singledelegate delg = new Singledelegate();
            // creating object of delegate , name as "del_delg1" for method "sum"
            // and "del_delg2" for method "substract"
            //pass the parameter as the two methods by class object "delg"
            //instantiating the delegates
           
            addnum del_delg1 = new addnum(delg.sum);
            subnum del_delg2 = new subnum(delg.substract);
           
            //pass the values to methods by delegate object
           
            del_delg1(70, 50);
            del_delg2(80, 30);
            // these can e written as using 
            //"invoke" method
            // del_delg1.invoke(70,50)
            //del_delg2.invoke(80,30)
        }
    }
}
