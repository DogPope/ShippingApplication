using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace ShippingApplication
{
    class Orders
    {
        private Int32 orderId;
        private decimal cost;
        private char status;
        List<Game> games;
    
        public Orders()
        {
            this.orderId = 0;
            //this.orderDate = (2022, 01, 01, 01, 01, 01);
            this.cost = 0;
            this.status = 'A';
        }

        public Orders(int orderId, decimal cost, char status, List<Game> games)
        {
            this.orderId = orderId;
            this.cost = cost;
            this.status = status;
            this.games = games;
        }

        public int getOrderId()
        {
            return this.orderId;
        }

        public void setOrderId(Int32 OrderID)
        {
            if (OrderID > 0 && OrderID < Int32.MaxValue)
                orderId = OrderID;
            else
                orderId = 0;
        }

        public decimal getCost()
        {
            return this.cost;
        }

        public void setCost(decimal Cost)
        {
            if (Cost > 0 && Cost < decimal.MaxValue)
                cost = Cost;
            else
                cost = 0;
        }

        public char getStatus()
        {
            return this.status;
        }

        public void setStatus(char Status)
        {
            if (Status >= 'A' && Status <= 'Z')
                status = Status;
            else
                status = 'U';
        }

        public List<Game> getGames()
        {
            return this.games;
        }

        public void setGames(List<Game> Games)
        {
            games = Games;
        }

        public void addOrder()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO Products Values (" +
                this.orderId + ",'" +
                this.cost + "','" +
                this.status + "','" +
                this.games + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public String toString()
        {
            //private Int32 orderId;
        //private decimal cost;
       // private char status;
        //List<Game> games;
            return "Order ID: " + getOrderId() + " Cost" + getCost() + "\nStatus" + getStatus();
        }

    }
}
