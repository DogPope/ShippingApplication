using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingApplication
{
    public class Order
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
        public Order(Int32 OrderId, decimal Cost, String Date, String status, Int32 CustId)
        {
            this.orderId = OrderId;
            this.cost = Cost;
            this.date = Date;
            this.status = status;
            this.custId = CustId;
        }
        public Int32 getOrderId()
        {
            return this.orderId;
        }
        public void setOrderId(Int32 OrderId)
        {
            if(OrderId > 0 || OrderId < Int32.MaxValue)
            {
                this.orderId = OrderId;
            }
            else
                throw new ArgumentException();
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
            if (Cost > 0 || Cost < decimal.MaxValue)
            {
                this.cost = Cost;
            }
            else
                throw new ArgumentException();
        }

        public Int32 getCustId()
        {
            return this.custId;
        }
        public void setCustId(Int32 CustId)
        {
            if (CustId > 0 || CustId < Int32.MaxValue)
            {
                this.custId = CustId;
            }
            else
                throw new ArgumentException();
        }

        public String getStatus()
        {
            return this.status;
        }
        public void setStatus(String status)
        {
            if (status.Equals("Returned") || status.Equals("Cancelled") || status.Equals("Placed") || status.Equals("In Transit") || status.Equals("Fulfilled"))
            {
                this.status = status;
            }
            else
                throw new ArgumentException();
            
        }

        public void getOrder(Int32 OrderId)
        {
            // Gets all the values associated with an order by its ID
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM Orders WHERE Order_Id =" + OrderId;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setOrderId(dr.GetInt32(0));
            setDate(dr.GetString(1));
            setCost(dr.GetInt32(2));
            setStatus(dr.GetString(3));
            setCustId(dr.GetInt32(4));

            conn.Close();
        }
        public static double getAgeOfOrder(Int32 OrderId)
        {
            // Subtracts the Order Date from the system date and returns the age of the order as a double.
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String sqlQuery = "SELECT CAST(SYSDATE - Order_Date AS INT) AS Age from Orders WHERE Order_Id=" + OrderId;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();

            double difference;
            dr.Read();

            if (dr.IsDBNull(0))
                difference = 1;
            else
            {
                difference = dr.GetInt32(0) + 1;
            }
            conn.Close();
            return difference;
        }
        public void addOrder()
        {
            // Inserts an order into the Orders table.
            OracleConnection connection = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO Orders Values (" + 
                getNextOrderID() + "," +
                "SYSDATE," +
                this.cost + 
                ",'Placed'," + 
                this.custId + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, connection);
            connection.Open();

            cmd.ExecuteNonQuery();

            connection.Close();
        }
        public static int getNextOrderID()
        {
            // Returns the next available Order ID as an Integer.
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
        public static void transportOrder(Int32 orderId)
        {
            // Marks an order as having been assembled and currently in transit.
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Orders SET " +
                "Status = 'In Transit' " +
                "WHERE Order_Id = " + orderId;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void cancelOrder(Int32 orderId)
        {
            // Updates an orders status to Cancelled.
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Orders SET " +
                "Status = 'Cancelled' " + 
                "WHERE Order_Id = " + orderId;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataSet viewOrdersByCustId(Int32 CustId)
        {
            // Returns eligible orders using Customer ID Field.
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT DISTINCT Order_Id, Order_Date, Cost, Status FROM Orders " +
                "WHERE Status != 'Cancelled' AND Status != 'Returned' AND Cust_Id=" + CustId +" " +
                "ORDER BY Order_Date DESC";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Orders");
            conn.Close();
            return ds;
        }
        public static void returnOrder(Int32 orderId)
        {
            // Sets an orders status to returned.
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Orders SET " +
                "Status = 'Returned' " +
                "WHERE Order_Id = " + orderId;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void finishOrder(Int32 OrderId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Orders SET " +
                "Status = 'Fulfilled' " +
                "WHERE Order_Id = " + OrderId;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataSet findOrdersToPrint()
        {
            // Return Order details for staff to print to a receipt.
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM Orders WHERE Status='In Transit' ORDER BY Order_Date";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Orders");
            conn.Close();
            return ds;
        }
        public static DataSet generateReceipt(Int32 CustId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            // Customers.email was added later. Remove if unable to get working.
            String sqlQuery = "SELECT Orders.Order_ID, Customers.forename, Customers.surname, Customers.email, Orders.Order_Date, Orders.Cost, Orders.Cust_Id " +
                                "FROM Orders " +
                                "INNER JOIN Customers ON Orders.Cust_ID = Customers.Cust_ID " +
                                "WHERE Orders.Cust_Id = " + CustId + " AND Orders.Status = 'In Transit'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Orders");
            conn.Close();
            return ds;
        }
        public static decimal getRevenue(String months, String year)
        {
            // Returns the next available Order ID as an Integer.
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String sqlQuery = "SELECT SUM(Cost) FROM Orders " +
                "WHERE Order_Date LIKE '%" + months + "-" + year + "%' " +
                "AND Status='Fulfilled'";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();

            decimal cost;
            dr.Read();

            // If no orders returned.
            try
            {
                if (dr.IsDBNull(0))
                    cost = 0;
                else
                {
                    cost = dr.GetDecimal(0);
                }
            }catch(InvalidOperationException ex)
            {
                return 0;
            }
            conn.Close();
            return cost;
        }
        public static DataSet showShippingOrders()
        {
            // Generates a list of orders that need to be assembled by warehouse.
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT Order_Id, Order_Date, Cust_Id " +
                "FROM Orders WHERE Status='Placed' " +
                "ORDER BY Order_Date";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Orders");
            conn.Close();
            return ds;
        }

        public string toString()
        {
            return "Order ID: " + getOrderId() + "\nDate: " + getDate() + "\nCost: " + getCost() + "\nCustomer ID: " + getCustId() + "\nStatus: " + getStatus();
        }
    }
}
