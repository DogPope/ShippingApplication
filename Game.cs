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
        private String genre;
        private String description;
        private decimal buyPrice;
        private decimal salePrice;
        private Int32 quantity;
        private String status;
        //GameId,Title,Developer,Publisher,Genre,Description,BuyPrice,SalePrice,Quantity,Status
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
        
        public Game(Int32 gameId, String title, String developer, String publisher, String genre, String description, decimal buyPrice, decimal salePrice, Int32 quantity, String status)
        {
            // This constructor should be used for update queries.
            this.gameId = gameId;
            this.title = title;
            this.developer = developer;
            this.publisher = publisher;
            this.genre = genre;
            this.description = description;
            this.buyPrice = buyPrice;
            this.salePrice = salePrice;
            this.quantity = quantity;
            this.status = status;
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
        public void setQuantity(int Quantity)
        {
            if(quantity >= 0 && quantity < Int32.MaxValue)
            {
                this.quantity = Quantity;
            }
        }

        public decimal getBuyPrice()
        {
            return this.buyPrice;
        }
        public void setBuyPrice(decimal BuyPrice)
        {
            this.buyPrice = BuyPrice;
        }

        public decimal getSalePrice()
        {
            return this.salePrice;
        }
        public void setSalePrice(decimal SalePrice)
        {
            this.salePrice = SalePrice;
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

        public void getGame(Int32 Id)
        {
            //GameId,Title,Developer,Publisher,Genre,Description,BuyPrice,SalePrice,Quantity,Status
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String sqlQuery = "SELECT * FROM Games WHERE Game_ID = " + Id;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setGameId(dr.GetInt32(0));
            setTitle(dr.GetString(1));
            setDeveloper(dr.GetString(2));
            setPublisher(dr.GetString(3));
            setGenre(dr.GetString(4));
            setDescription(dr.GetString(5));
            setBuyPrice(dr.GetDecimal(6));
            setSalePrice(dr.GetDecimal(7));
            setQuantity(dr.GetInt32(8));
            setStatus(dr.GetString(9));

            conn.Close();
        }

        public void addGame()
        {
            try
            {
                OracleConnection connection = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "INSERT INTO Games VALUES (" + getNextGameID() + ",'" +
                    this.title + "','" + this.developer + "','" + this.publisher + "','" +
                    this.genre + "','" + this.description + "'," + this.buyPrice + "," +
                    this.salePrice + "," + this.quantity + ",'" + this.status + "')";

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

            String sqlQuery = "UPDATE Games SET " +
                "Game_Id = " + this.gameId + "," +
                "Title = '" + this.title + "'," +
                "Developer = '" + this.developer + "'," +
                "Publisher = '" + this.publisher + "'," +
                "Genre = '" + this.genre + "'," +
                "Description = '" + this.description + "'," +
                "BuyPrice = " + this.buyPrice + "," +
                "SalePrice = " + this.salePrice + "," +
                "Quantity = " + this.quantity + "," +
                "Status = '" + this.status + "' " +
                "WHERE Game_Id = " + this.gameId;

            Console.WriteLine(sqlQuery);

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataSet findGameById(Int32 gameId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM Games " +
                "WHERE Game_Id = '" + gameId + "' ORDER BY Game_Id";

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
                " Cost to buy: " + getBuyPrice() + 
                "\nSale Price: " + getSalePrice() + 
                "Status: " + getStatus();
        }
    }
}
