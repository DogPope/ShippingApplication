using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingApplication
{
    class Orders
    {
        private Int32 OrderID { get; set; }
        private DateTime OrderDate { get; set; } // DateTime returns the format YYYY / MM / DD / HH / Min
        private decimal Cost { get; set; }
        private char Status { get; set; }
        private Game GameID { get; set; }
    }
}
