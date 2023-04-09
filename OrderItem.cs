using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingApplication
{
    class OrderItem
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
            if(gameId > 0 || gameId < Int32.MaxValue)
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
        public void removeOrderItem()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "DELETE FROM Order_Items " +
                "WHERE Order_Id = " + this.orderId;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public bool isEmpty(List<OrderItem> games)
        {
            if (games[0] == null)
                return true;
            else
                return false;
        }
        public String toString()
        {
            return "Order ID: " + getOrderId() + "\nCost:" + getCost() + "\nGame Id: " + getGameId();
        }
    }
}
