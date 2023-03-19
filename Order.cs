using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingApplication
{
    class Order
    {
        public Int32 orderId;
        private decimal cost;
        private String date;
        private Int32 custId;
        private String status;

        public Order()
        {
            this.orderId = 0;
            this.cost = 0;
            this.date = "SYSDATE";
            this.custId = 0;
        }
        public Order(Int32 OrderId, decimal Cost, String Date, Int32 CustId)
        {
            this.orderId = OrderId;
            this.cost = Cost;
            this.date = Date;
            this.custId = CustId;
        }
        public Int32 getOrderId()
        {
            return this.orderId;
        }
        public void setOrderId(Int32 OrderId)
        {
            this.orderId = OrderId;
        }

        public String getDate()
        {
            return this.date;
        }
        public void setDate(String Date)
        {
            this.date = Date;
        }

        public decimal getCost()
        {
            return this.cost;
        }
        public void setCost(decimal Cost)
        {
            this.cost = Cost;
        }

        public Int32 getCustId()
        {
            return this.custId;
        }
        public void setCustId(Int32 CustId)
        {
            this.custId = CustId;
        }

        public String getStatus()
        {
            return this.status;
        }
        public void setStatus(String status)
        {
            this.status = status;
        }
        // OrderId, OrderItem, Cost, Date, CustId, status
        // Placed, Returned, Cancelled, On Hold
        public void addOrder()
        {
            OracleConnection connection = new OracleConnection(DBConnect.oradb);

            // SYSDATE DOES NOT HAVE PUNCTUATION.//
            String sqlQuery = "INSERT INTO Orders Values (" + 
                getNextOrderID() + "," +
                "SYSDATE," +
                this.cost + 
                ",'Placed '," + 
                this.custId + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, connection);
            connection.Open();

            cmd.ExecuteNonQuery();

            connection.Close();
        }
        
        public void deleteOrder()
        {
            OracleConnection connection = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "DELETE FROM Orders WHERE Cust_Id = " + this.custId;

            OracleCommand cmd = new OracleCommand(sqlQuery, connection);
            connection.Open();

            cmd.ExecuteNonQuery();

            connection.Close();
        }
        public static int getNextOrderID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String sqlQuery = "SELECT MAX(Order_ID) FROM Orders";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();

            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }
            conn.Close();
            return nextId;
        }
        public void cancelOrder()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Order SET " +
                "Status = 'Cancelled' " + 
                "WHERE Cust_Id = " + this.custId + ");";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void holdOrder()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Order SET " +
                "Status = 'On hold' " +
                "WHERE Cust_Id = " + this.custId + ");";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void returnOrder()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Order SET " +
                "Status = 'Returned' " +
                "WHERE Cust_Id = " + this.custId + ");";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataSet findOrderById(Int32 orderId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM Orders " +
                "WHERE Order_Id LIKE '%" + orderId + "%;";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Orders");
            conn.Close();
            return ds;
        }
        public String toString()
        {
            return "Order Id: " + getOrderId() +
                "\nCost :" + getCost() + 
                "\nStatus: " + getStatus();
        }
        public String addOrderString()
        {
            return "Order ID: " + getOrderId() + "\nCost: " + getCost() + "\nStatus : Ready to assemble!";
        }
    }
}
