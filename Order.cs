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
        private OrderItem[] orderItem;
        private decimal cost;
        private String date;
        private Int32 custId;
        private char status;

        public Order()
        {
            this.orderId = 0;
            this.cost = 0;
            this.orderItem = null;
            this.date = "SYSDATE";
            this.custId = 0;
        }
        public Int32 getOrderId()
        {
            return this.orderId;
        }
        public void setOrderId(Int32 OrderId)
        {
            this.orderId = OrderId;
        }

        public OrderItem[] getOrderItem()
        {
            return this.orderItem;
        }
        public void setOrderItem(OrderItem[] OrderItem)
        {
            this.orderItem = OrderItem;
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

        public char getStatus()
        {
            return this.status;
        }
        public void setStatus(char status)
        {
            this.status = status;
        }
        // OrderId, OrderItem, Cost, Date, CustId, status
        public void addOrder()
        {
            try
            {
                OracleConnection connection = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "INSERT INTO Orders Values (" + getNextOrderID() + ",'" +
                    this.orderItem + "'," + this.cost + "," + this.custId + ");";

                OracleCommand cmd = new OracleCommand(sqlQuery, connection);
                Console.WriteLine("Success?");
                connection.Open();

                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                if (ex.Source != null)
                {
                    Console.WriteLine("IOException source: {0}", ex.Source);
                }
                throw;
            }
        }
        public static int getNextOrderID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String sqlQuery = "SELECT MAX(OrderID) FROM Orders";
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
        public void cancelOrReturnOrder()
        {
            // Status 'C' for Cancelled, status 'B' for sent Back.
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Order SET " +
                "Status = " + this.status + 
                "WHERE CustId = " + this.custId + ");";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataSet findOrder(Int32 orderId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT Order_Id, Order_Date, Cost, Status FROM Orders " +
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
            return "Order Id: " + getOrderId() + ", Order Date: " + getDate() + "\nCost :" +
                getCost() + ", Status: " + getStatus();
        }
    }
}
