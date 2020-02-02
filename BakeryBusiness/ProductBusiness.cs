using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryBusiness
{
    class ProductBusiness
    {
        private static void findNumbers(List<int> ar, int sum, List<List<int>> res, List<int> r, int i)
        {
            try
            {
                if (sum < 0)
                {
                    return;
                }

                if (sum == 0)
                {
                    int[] a = new int[r.Count];
                    for (int k = 0; k < r.Count; k++)
                    {
                        a[k] = r[k];
                    }
                    res.Add(a.ToList());
                    return;
                }

                while (i < ar.Count && sum - ar[i] >= 0)
                {
                    r.Add(ar[i]);
                    findNumbers(ar, sum - ar[i], res, r, i);
                    i++;
                    r.RemoveAt(r.Count - 1);
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message.ToString() + "\n\n");
                Console.ResetColor();
            }
        }
        public static List<List<int>> combinationSum(List<int> ar, int sum)
        {
            ar.Sort();
            List<int> r = new List<int>();
            List<List<int>> res = new List<List<int>>();
            findNumbers(ar, sum, res, r, 0);
            return new List<List<int>>(res);
        }
    }
}
