using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    public class Computation
    {
        public float total;

        public Computation()
        {
            
        }

        public float GetTotalPrice(float price1, float price2)
        {
            total = price1 + price2;
            return total;
        }
    }
}
