using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace ShippingApplication
{
    class ConnectionTest
    {
        OracleConnection con;
        void Connect()
        {
            con = new OracleConnection();
            con.ConnectionString = "User Id=C##Daniel;Password=password;Data Source=oracle/orcl;";
        }
    }
}
