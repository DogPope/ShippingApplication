using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace ShippingApplication
{
    class Game
    {
        private Int32 gameId;
        private String title;
        private String developer;
        private String publisher;
        private decimal buyPrice;
        private decimal salePrice;
        private char status;

        public Game()
        {
            this.gameId = 0;
            this.title = "Not known";
            this.developer = "Not known";
            this.publisher = "Not known";
            this.buyPrice = 0;
            this.salePrice = 0;
            this.status = 'U';
        }
        public Game(String title, String developer, String publisher, decimal salePrice, char status)
        {
            this.title = title;
            this.developer = developer;
            this.publisher = publisher;
            this.salePrice = salePrice;
            this.status = status;
        }

        public Int32 getGameId()
        {
            return this.gameId;
        }
        public void setGameId(Int32 GameID)
        {
            this.gameId = GameID;
        }

        public String getTitle()
        {
            return this.title;
        }
        public void setTitle(String Title)
        {
            char.ToUpper(Title[0]);
            this.title = Title;
        }

        public String getDeveloper()
        {
            return this.developer;
        }
        public void setDeveloper(String Developer)
        {
            char.ToUpper(Developer[0]);
            this.developer = Developer;
        }

        public String getPublisher()
        {
            return this.publisher;
        }
        public void setPublisher(String Publisher)
        {
            char.ToUpper(Publisher[0]);
            this.publisher = Publisher;
        }

        public decimal getBuyingPrice()
        {
            return this.buyPrice;
        }
        public void setBuyingPrice(decimal BuyPrice)
        {
            this.buyPrice = BuyPrice;
        }

        public decimal getSalePrice()
        {
            return this.salePrice;
        }

        public char getStatus()
        {
            return this.status;
        }
        public void setStatus(char Status)
        {
            Char.ToUpper(Status);
            this.status = Status;
        }

        public void addGame()
        {
            try
            {
                OracleConnection connection = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "INSERT INTO Games Values (" + getNextGameID() + ",'" +
                    this.title + "','" + this.developer + "','" + this.publisher + "'," +
                    this.salePrice + ",'" + this.status + "')";

                OracleCommand cmd = new OracleCommand(sqlQuery, connection);
                connection.Open();
                cmd.ExecuteNonQuery();

                connection.Close();
            }catch (Exception ex)
            {
                if (ex.Source != null)
                {
                    Console.WriteLine("IOException source: {0}", ex.Source);
                }
                throw;
            }
        }

        public void updateGame()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Game SET " +
                "GameId = " + this.gameId + "," +
                "Title = '" + this.title + "'," +
                "Developer = '" + this.developer + "'," +
                "Publisher = '" + this.publisher + "'," +
                "Cost to Buy = " + this.buyPrice + "," +
                "SalePrice = " + this.salePrice + "," +
                "Status = '" + this.status + "' " +
                "WHERE GameId = " + this.gameId + ";";

            /*
             *  Commenting the above string to get a clearer look at its output.
             UPDATE Game SET GameId = 1,Title = 'titleString',Developer = 'developerString',Publisher = 'publisherString',CosttoBuy = priceDouble,
            salePrice = salePriceDouble,Status = ''WHERE GameId = gameIdInt;
             */

            Console.WriteLine(sqlQuery);

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataSet findGame(String title)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT GameId, Title, Developer, Publisher FROM Games " +
                "WHERE Title LIKE '%" + title + "%' ORDER BY Title";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Games");
            conn.Close();
            return ds;
        }
        public static int getNextGameID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String sqlQuery = "SELECT MAX(GameID) FROM Games";
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
        public String toString()
        {
            return "Title: " + getTitle() + " Developer: " + getDeveloper() + "\nPublisher: " + getPublisher() + 
                " Cost to buy: " + getBuyingPrice() + "\nSale Price: " + getSalePrice() + "Status: " + getStatus();
        }
    }
}
