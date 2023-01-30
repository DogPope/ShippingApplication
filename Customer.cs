using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingApplication
{
    class Customer
    {
        private static Int32 CustID { get; set; }
        private String Surname { get; set; }
        private String Forename { get; set; }
        private String Town { get; set; }
        private String County { get; set; }
        private String Country { get; set; }
        private String EIRCode { get; set; }
        private String Password { get; set; }
        private String Phone { get; set; }
        private String EMail { get; set; }
        private static Int32 CardNumber { get; set; }
        private char Status { get; set; }
    }
}
