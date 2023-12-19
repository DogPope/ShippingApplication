using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace ShippingApplication
{
    public class OrderItem
    {
        private Int32 gameId;
        private Int32 orderId;
        private decimal cost;
        public OrderItem()
        {
            this.gameId = 0;
            this.orderId = 0;
            this.cost = 0;
        }
        public OrderItem(Int32 GameId, Int32 OrderId, decimal cost)
        {
            this.gameId = GameId;
            this.orderId = OrderId;
            this.cost = cost;
        }

        public Int32 getGameId()
        {
            return this.gameId;
        }
        public void setGameId(Int32 gameId)
        {
            if (gameId > 0 || gameId < Int32.MaxValue)
            {
                this.gameId = gameId;
            }
            else
                throw new ArgumentException();
        }

        public Int32 getOrderId()
        {
            return this.orderId;
        }
        public void setOrderId(Int32 orderId)
        {
            if (orderId > 0 || orderId < Int32.MaxValue)
            {
                this.orderId = orderId;
            }
            else
                throw new ArgumentException();
        }

        public decimal getCost()
        {
            return this.cost;
        }
        public void setCost(decimal cost)
        {
            if (cost > 0 || cost < decimal.MaxValue)
            {
                this.cost = cost;
            }
            else
                throw new ArgumentException();
        }
        public void addOrderItem()
        {
            // Inserts individual items into an order.
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO Order_Items Values (" +
                this.orderId + "," +
                this.cost + "," +
                this.gameId + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void removeOrderItem(Int32 gameId)
        {
            // Removes an order item from an order.
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "DELETE FROM Order_Items " +
                "WHERE Game_Id = " + gameId;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public static decimal getStock(String title, String year)
        {
            // Returns the sum of sales for a given item over a certain time period.
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String sqlQuery = "SELECT  Sum(Order_Items.Cost) " +
                                "FROM Games " +
                                "INNER JOIN Order_items ON Order_Items.Game_id=Games.Game_Id " +
                                "INNER JOIN Orders ON Order_Items.Order_Id=Orders.Order_Id " +
                                "WHERE Games.Title LIKE '%" + title + "%' " +
                                "AND Orders.Status='Fulfilled' " +
                                "AND Orders.Order_Date LIKE '%" + year + "'";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();

            decimal cost;
            dr.Read();

            // If result set is null
            try
            {
                if (dr.IsDBNull(0))
                    cost = 0;
                else
                {
                    cost = dr.GetDecimal(0);
                }
            }
            catch (InvalidOperationException ex)
            {
                return 0;
            }
            conn.Close();
            return cost;
        }
        public static DataSet viewOrderItems(Int32 OrderId)
        {
            // Returns a dataSet of the items in an order.
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT Games.Title, Games.Saleprice, Order_Items.Game_Id " +
                "FROM Games " +
                "INNER JOIN Order_Items " +
                "ON Order_Items.Game_Id = Games.Game_Id " +
                "WHERE Order_Items.Order_Id = " + OrderId;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Order_Items");
            conn.Close();
            return ds;
        }
        public String toString()
        {
            return "Order ID: " + getOrderId() + "\nCost:" + getCost() + "\nGame Id: " + getGameId();
        }
    }
}
