using BakeryDataAccess;
using BakeryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryBusiness
{
    public class ProductImplementation : IProduct
    {
        public void CalculateMinimumShippingSpace(Inputs input)
        {
            try
            {
                List<Output> outputobj = new List<Output>();
                string itemcode = input.itemcode;
                int noofitems = input.quantity;
                var itemstock = ProductData.GetItemStocks();
                List<Sales> salesobj = new List<Sales>();
                double totalprice = 0;
                var availablepacks = itemstock.Where(x => x.itemcode == itemcode).Select(x => x.packs).ToList();
                if (availablepacks.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Input");
                    Console.ResetColor();
                    Console.WriteLine(itemcode + ":\t" + noofitems.ToString());
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Output");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Product does not exists in stock");
                    Console.ResetColor();
                }
                List<List<int>> res = ProductBusiness.CombinationSum(availablepacks, noofitems);
                if (res.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Input");
                    Console.ResetColor();
                    Console.WriteLine(itemcode + ":\t" + noofitems.ToString());
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Output");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Items with { noofitems} packs can not be added for the item code:- {itemcode}");
                    Console.ResetColor();
                }
                else
                {
                    List<BestMatch> bestmatchObj = new List<BestMatch>();
                    var resFilt = res.ToList().Min(x => x.Count);
                    res = res.Where(x => x.Count == resFilt).ToList();
                    int resindex = 0;
                    if (res.Count > 1)
                    {
                        string str;
                        int index = 0;
                        foreach (var listItm in res)
                        {
                            str = "";
                            BestMatch objbest = new BestMatch();
                            foreach (var item in listItm.OrderByDescending(x => x))
                            {
                                str += item.ToString();
                            }
                            objbest.index = index;
                            objbest.Value = Convert.ToInt64(str);
                            bestmatchObj.Add(objbest);
                            index++;
                        }
                        resindex = bestmatchObj.OrderByDescending(item => item.Value).First().index;
                    }
                    Output objout = new Output();
                    objout.Sales = new List<Sales>();
                    foreach (var item in res[resindex])
                    {
                        Sales objs = new Sales();
                        objs.itemcode = itemcode;
                        objs.price = itemstock.Where(x => x.packs == item && x.itemcode == itemcode).Select(x => x.price).FirstOrDefault();
                        objs.quantity = item;
                        objout.Sales.Add(objs);
                        totalprice += itemstock.Where(x => x.packs == item && x.itemcode == itemcode).Select(x => x.price).FirstOrDefault();
                    }

                    objout.itemcode = itemcode;
                    objout.quantity = noofitems;
                    objout.totalprice = totalprice;
                    outputobj.Add(objout);
                }
                foreach (var result in outputobj)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Input");
                    Console.ResetColor();
                    Console.WriteLine(result.itemcode + " " + result.quantity.ToString());
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Output");
                    Console.WriteLine("Item Code ############# Packs ######################### Price");
                    Console.ResetColor();
                    var sales= result.Sales.Where(a=>a.itemcode==itemcode).GroupBy(a => a.quantity)
                              .Select(g => new { g.Key, TotalSales = g.Sum(pv => pv.price),price=g.Select(x=>x.price).First(), Count = g.Count() });
                    foreach (var item in sales)
                    {
                        Console.WriteLine(itemcode + "\t\t\t" + item.Count.ToString() + " X "+ item.Key.ToString()+"($"+ item.price+ ")"+"\t\t\t" +"$"+item.TotalSales.ToString());
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Total amount \t\t\t\t\t\t" +"$"+result.totalprice.ToString());
                    Console.ResetColor();
                }
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
