using BakeryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryBusiness
{
    public interface IProduct
    {
        void CalculateMinimumShippingSpace(Inputs input);
    }
}
