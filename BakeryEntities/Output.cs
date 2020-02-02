using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryEntities
{
    public class Output
    {
        public string itemcode { get; set; }
        public int quantity { get; set; }
        public double totalprice { get; set; }
        public List<Sales> Sales { get; set; }
    }
}
