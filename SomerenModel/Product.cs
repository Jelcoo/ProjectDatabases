using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Product //TODO make constructurs (for multiple models)
    {
        public const double NORMAL_VAT_RATE = 0.06; //TODO make enum
        public const double ALCOHOL_VAT_RATE = 0.21;

        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public double VATRate { get; set; }
        public double Price { get; set; }

        public bool IsAlcoholic {
            get
            {
                return VATRate == ALCOHOL_VAT_RATE;
            }
        }
    }
}
