using BakeryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryTest
{
    public class TestData
    {
        public static List<List<Inputs>> GetTestData()
        {
            List<List<Inputs>> objtestcaselist = new List<List<Inputs>>();
            List<Inputs> objtestdata = new List<Inputs>();
            //-------------test case: 1 ------------------
            Inputs testcase1 = new Inputs();
            testcase1.itemcode = "VS5";
            testcase1.quantity = 10;
            objtestdata.Add(testcase1);
            testcase1 = new Inputs();
            testcase1.itemcode = "MB11";
            testcase1.quantity = 14;
            objtestdata.Add(testcase1);
            testcase1 = new Inputs();
            testcase1.itemcode = "CF";
            testcase1.quantity = 13;
            objtestdata.Add(testcase1);
            objtestcaselist.Add(objtestdata);
            //-------------test case: 2 ------------------
            objtestdata = new List<Inputs>();
            Inputs testcase2 = new Inputs();
            testcase2.itemcode = "VS5";
            testcase2.quantity = 13;
            objtestdata.Add(testcase2);
            testcase2 = new Inputs();
            testcase2.itemcode = "MB11";
            testcase2.quantity = 24;
            objtestdata.Add(testcase2);
            testcase2 = new Inputs();
            testcase2.itemcode = "CF";
            testcase2.quantity = 30;
            objtestdata.Add(testcase2);
            objtestcaselist.Add(objtestdata);
            //-------------test case: 3 ------------------
            objtestdata = new List<Inputs>();
            Inputs testcase3 = new Inputs();
            testcase3.itemcode = "VS5";
            testcase3.quantity = 4;
            objtestdata.Add(testcase3);
            testcase3 = new Inputs();
            testcase3.itemcode = "MB11";
            testcase3.quantity = 47;
            objtestdata.Add(testcase3);
            testcase3 = new Inputs();
            testcase3.itemcode = "CF";
            testcase3.quantity = 19;
            objtestdata.Add(testcase3);
            objtestcaselist.Add(objtestdata);
            //-------------test case: 4 ------------------
            objtestdata = new List<Inputs>();
            Inputs testcase4 = new Inputs();
            testcase4.itemcode = "VS5";
            testcase4.quantity = 14;
            objtestdata.Add(testcase4);
            testcase4 = new Inputs();
            testcase4.itemcode = "MB11";
            testcase4.quantity = 47;
            objtestdata.Add(testcase4);
            testcase4 = new Inputs();
            testcase4.itemcode = "CF";
            testcase4.quantity = 19;
            objtestdata.Add(testcase4);
            objtestcaselist.Add(objtestdata);
            //-------------test case: 5 ------------------
            objtestdata = new List<Inputs>();
            Inputs testcase5 = new Inputs();
            testcase5.itemcode = "VS5";
            testcase5.quantity = 54;
            objtestdata.Add(testcase5);
            testcase5 = new Inputs();
            testcase5.itemcode = "MB11";
            testcase5.quantity = 87;
            objtestdata.Add(testcase5);
            testcase5 = new Inputs();
            testcase5.itemcode = "CF";
            testcase5.quantity = 59;
            objtestdata.Add(testcase5);
            objtestcaselist.Add(objtestdata);
           
            //-------------test case: 6 ------------------
            objtestdata = new List<Inputs>();
            Inputs testcase6 = new Inputs();
            testcase6.itemcode = "VS5";
            testcase6.quantity = 45;
            objtestdata.Add(testcase6);
            testcase6 = new Inputs();
            testcase6.itemcode = "MB11";
            testcase6.quantity = 38;
            objtestdata.Add(testcase6);
            testcase6 = new Inputs();
            testcase6.itemcode = "CF";
            testcase6.quantity = 7;
            objtestdata.Add(testcase6);
            objtestcaselist.Add(objtestdata);
            //-------------test case: 7 ------------------
            objtestdata = new List<Inputs>();
            Inputs testcase7 = new Inputs();
            testcase7.itemcode = "VS5";
            testcase7.quantity = 154;
            objtestdata.Add(testcase7);
            testcase7 = new Inputs();
            testcase7.itemcode = "MB11";
            testcase7.quantity = 3;
            objtestdata.Add(testcase7);
            testcase7 = new Inputs();
            testcase7.itemcode = "CF";
            testcase7.quantity = 50;
            objtestdata.Add(testcase7);
            objtestcaselist.Add(objtestdata);
            return objtestcaselist;

        }
    }
    
}
