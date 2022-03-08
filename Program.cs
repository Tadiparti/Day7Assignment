using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int acceptorder;
            Console.WriteLine("Welcome to zomato site :\ How many IceCreams would u like to order(Total 5 items):");
            acceptorder = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (acceptorder == 5 || acceptorder < 5)
                {
                    Console.WriteLine("Congratulations! you have bought {0} IceCreams", acceptorder);
                    Console.ReadLine();
                }
                else
                {
                    throw(new OutOfStockException("OutofStockExpection Generated: number of items you want to buy are out of stock.Please enter total item number within stock"))
                }
            }
            catch(OutOfStockException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                Console.ReadLine();
            }
        }
    }
}
