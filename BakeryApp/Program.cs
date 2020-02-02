using BakeryBusiness;
using BakeryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp
{
    class Program
    {
        private static IProduct _product;
        static Program()
        {
           _product = new ProductImplementation();
        }
        static void Main(string[] args)
        {
            try
            {
                List<Inputs> inputobj = new List<Inputs>();
                do
                {
                    try
                    {
                        Inputs obinp = new Inputs();
                        Console.WriteLine("Enter number of items:-");
                        int noofitems = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter item code:-");
                        string itemcode = Console.ReadLine();
                        obinp.itemcode = itemcode;
                        obinp.quantity = noofitems;
                        inputobj.Add(obinp);
                    }
                    catch(Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message.ToString() + "\n\n");
                        Console.ResetColor();
                    }
                    Console.WriteLine("Do you want to add more item (Y/N)? ");
                }
                while (Console.ReadLine() != "N");
                foreach (var item in inputobj)
                {
                    _product.CalculateMinimumShippingSpace(item);
                }
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message.ToString() + "\n\n");
                Console.ResetColor();
            }
        }
    }
}
