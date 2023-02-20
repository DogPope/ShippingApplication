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
        private String description;
        private String genre;
        private Int32 quantity;
        private decimal buyPrice;
        private decimal salePrice;
        private String status;
        private int v1;
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;
        private int v2;
        private decimal v3;
        private string text6;

        public Game()
        {
            this.gameId = 0;
            this.title = "No title available.";
            this.developer = "No developer available.";
            this.publisher = "No publisher available.";
            this.description = "No description available.";
            this.genre = "No genre available.";
            this.quantity = 0;
            this.buyPrice = 0;
            this.salePrice = 0;
            this.status = "Unregistered.";
        }
        /*public Game(Int32 gameId, String title, String developer, String publisher, String description, String genre, Int32 quantity, decimal buyPrice, decimal salePrice, String status)
        {
            // This constructor to be used for the creation of a new game object.
            /* In this case, putting in a status is neccesary, because the item may or may not be available on creation, where a customer will always be registered on
            *  creation of a customer object.*/
            /*this.gameId = gameId;
            this.title = title;
            this.developer = developer;
            this.publisher = publisher;
            this.description = description;
            this.genre = genre;
            this.quantity = quantity;
            this.buyPrice = buyPrice;
            this.salePrice = salePrice;
            this.status = status;
        }*/

        public Game(Int32 gameId, String title, String developer, String publisher, String description, String genre, Int32 quantity, decimal buyPrice, decimal salePrice, String status)
        {
            // This constructor should be used for update queries.
            this.gameId = gameId;
            this.title = title;
            this.developer = developer;
            this.publisher = publisher;
            this.description = description;
            this.genre = genre;
            this.quantity = quantity;
            this.buyPrice = buyPrice;
            this.salePrice = salePrice;
            this.status = status;
        }

        public Game(int v1, string text1, string text2, string text3, string text4, string text5, int v2, decimal v3, string text6)
        {
            this.v1 = v1;
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.text5 = text5;
            this.v2 = v2;
            this.v3 = v3;
            this.text6 = text6;
        }

        public Int32 getGameId()
        {
            return this.gameId;
        }
        public void setGameId(Int32 GameID)
        {
            if(gameId > 0 && gameId < Int32.MaxValue)
                this.gameId = GameID;
            else
                this.gameId = 0;
        }

        public String getTitle()
        {
            return this.title;
        }
        public void setTitle(String Title)
        {
            if(title != "")
            {
                char.ToUpper(Title[0]);
                this.title = Title;
            }
        }

        public String getDeveloper()
        {
            return this.developer;
        }
        public void setDeveloper(String Developer)
        {
            if (developer != "")
            {
                char.ToUpper(Developer[0]);
                this.developer = Developer;
            }
            else
                developer = "No developer available!";
        }

        public String getPublisher()
        {
            return this.publisher;
        }
        public void setPublisher(String Publisher)
        {
            if (publisher != "")
            {
                char.ToUpper(publisher[0]);
                this.publisher = Publisher;
            }
            else
                publisher = "No publisher available!";
        }

        public String getGenre()
        {
            return this.genre;
        }
        public void setGenre(String Genre)
        {
            if (genre.Length > 0)
            {
                char.ToUpper(genre[0]);
                this.genre = Genre;
            }
            else
                genre = "No genre available.";
        }

        public String getDescription()
        {
            return this.description;
        }
        public void setDescription(String Description)
        {
            if (description.Length > 0)
            {
                char.ToUpper(description[0]);
                this.description = Description;
            }
            else
                description = "Description not available.";
        }

        public Int32 getQuantity()
        {
            return this.quantity;
        }
        public void setQuantity(Int32 Quantity)
        {
            if(quantity >= 0 && quantity < Int32.MaxValue)
            {
                this.quantity = Quantity;
            }
        }

        public decimal getBuyingPrice()
        {
            return this.buyPrice;
        }
        public void setBuyingPrice(decimal BuyPrice)
        {
            if (buyPrice < 0 && buyPrice > decimal.MaxValue)
                this.buyPrice = BuyPrice;
            else
                buyPrice = 0;
        }

        public decimal getSalePrice()
        {
            return this.salePrice;
        }
        public void setSalePrice(decimal SalePrice)
        {
            if (salePrice < 0 && salePrice > decimal.MaxValue)
                this.salePrice = SalePrice;
            else
                salePrice = 0;
        }

        public String getStatus()
        {
            return this.status;
        }
        public void setStatus(String Status)
        {
            if (status != "")
            {
                char.ToUpper(status[0]);
                this.status = Status;
            }
            else
                status = "Unregistered game!";
        }

        public void addGame()
        {
            try
            {
                OracleConnection connection = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "INSERT INTO Games VALUES (" + getNextGameID() + ",'" +
                    this.title + "','" + this.developer + "','" + this.publisher + "','" +
                    this.description + "','" + this.genre + "'," + this.quantity + "," +
                    this.buyPrice + "," + this.salePrice + ",'" + this.status + "')";

                /*    INSERT INTO Games VALUES (id,'title','DEV','PUB','DESC','GENRE',12,12,12,'R')         */

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
                "Game_Id = " + this.gameId + "," +
                "Title = '" + this.title + "'," +
                "Developer = '" + this.developer + "'," +
                "Publisher = '" + this.publisher + "'," +
                "Description = '" + this.description + "'," +
                "Genre = '" + this.genre + "'," +
                "Quantity = '" + this.quantity + "'," +
                "BuyPrice = " + this.buyPrice + "," +
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

            String sqlQuery = "SELECT Game_Id, Status, Title, Publisher FROM Games " +
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
            String sqlQuery = "SELECT MAX(Game_ID) FROM Games";
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
            return "Game ID: " + getGameId() +
                "Title: " + getTitle() + 
                "\nDeveloper: " + getDeveloper() + 
                " Publisher: " + getPublisher() + 
                "\nDescription: "+ getDescription() + 
                " Genre: " + getGenre() +
                "\nQuantity: " + getQuantity() + 
                " Cost to buy: " + getBuyingPrice() + 
                "\nSale Price: " + getSalePrice() + 
                "Status: " + getStatus();
        }
    }
}
