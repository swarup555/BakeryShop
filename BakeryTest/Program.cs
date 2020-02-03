using BakeryBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryTest
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
            int testcaseno = 1;
            var testcases = TestData.GetTestData();
            foreach(var testcase in testcases)
            {
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("##########################################################");
                Console.WriteLine($"Test case:- {testcaseno}");
                Console.WriteLine("########################################################## \n");
                Console.ResetColor();
                foreach (var item in testcase)
                {
                    _product.CalculateMinimumShippingSpace(item);
                }
                testcaseno++;
            }
            Console.ReadLine();
        }
    }
}
