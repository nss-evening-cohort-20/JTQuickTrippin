using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTQuickTrippin
{
    public class Store
    {
        public int StoreId { get; set; }
        public double GasYearly { get; set; }
        public double GasQuarterly { get; set; }
        public double RetailYearly { get; set; }
        public double RetailQuarterly { get; set; }


        public Store(int StoreId, double GasYearly, double GasQuarterly, double RetailYearly, double RetailQuarterly)
        {
            this.StoreId = StoreId;
            this.GasYearly = GasYearly;
            this.GasQuarterly= GasQuarterly;
            this.RetailQuarterly = RetailQuarterly;
            this.RetailYearly= RetailYearly;
        }
    }
}
