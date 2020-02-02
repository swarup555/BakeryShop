using BakeryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryDataAccess
{
    public class ProductData
    {
        public static List<ItemStocck> GetItemStocks()
        {
            List<ItemStocck> itemstocklistobj = new List<ItemStocck>();
            ItemStocck itemstockobj = new ItemStocck();
            itemstockobj.itemcode = "VS5";
            itemstockobj.packs = 3;
            itemstockobj.price = 6.99;
            itemstocklistobj.Add(itemstockobj);
            itemstockobj = new ItemStocck();
            itemstockobj.itemcode = "VS5";
            itemstockobj.packs = 5;
            itemstockobj.price = 8.99;
            itemstocklistobj.Add(itemstockobj);
            itemstockobj = new ItemStocck();
            itemstockobj.itemcode = "MB11";
            itemstockobj.packs = 2;
            itemstockobj.price = 9.95;
            itemstocklistobj.Add(itemstockobj);
            itemstockobj = new ItemStocck();
            itemstockobj.itemcode = "MB11";
            itemstockobj.packs = 5;
            itemstockobj.price = 16.95;
            itemstocklistobj.Add(itemstockobj);
            itemstockobj = new ItemStocck();
            itemstockobj.itemcode = "MB11";
            itemstockobj.packs = 8;
            itemstockobj.price = 24.95;
            itemstocklistobj.Add(itemstockobj);
            itemstockobj = new ItemStocck();
            itemstockobj.itemcode = "CF";
            itemstockobj.packs = 3;
            itemstockobj.price = 5.95;
            itemstocklistobj.Add(itemstockobj);
            itemstockobj = new ItemStocck();
            itemstockobj.itemcode = "CF";
            itemstockobj.packs = 5;
            itemstockobj.price = 9.95;
            itemstocklistobj.Add(itemstockobj);
            itemstockobj = new ItemStocck();
            itemstockobj.itemcode = "CF";
            itemstockobj.packs = 9;
            itemstockobj.price = 16.99;
            itemstocklistobj.Add(itemstockobj);
            return itemstocklistobj;
        }
    }
}
