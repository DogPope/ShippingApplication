﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace ShippingApplication
{
    public class Game
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
            this.status = "Deregistered";
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
        public Game(Int32 gameId, String title, String developer, String publisher, String genre, String description, decimal buyPrice, decimal salePrice, Int32 quantity)
        {
            // This constructor used for INSERT Queries
            this.gameId = gameId;
            this.title = title;
            this.developer = developer;
            this.publisher = publisher;
            this.genre = genre;
            this.description = description;
            this.buyPrice = buyPrice;
            this.salePrice = salePrice;
            this.quantity = quantity;
        }

        public Int32 getGameId()
        {
            return this.gameId;
        }
        public void setGameId(Int32 GameID)
        {
            if (GameID > 0 && GameID < Int32.MaxValue)
            {
                this.gameId = GameID;
            }
            else
                throw new ArgumentException();
        }

        public String getTitle()
        {
            return this.title;
        }
        public void setTitle(String Title)
        {
            if(Title.Equals("") || Title.Length > 20)
            {
                throw new ArgumentException();
            }
            this.title = Title;
        }

        public String getDeveloper()
        {
            return this.developer;
        }
        public void setDeveloper(String Developer)
        {
            if (Developer.Equals("") || Developer.Length > 20)
            {
                throw new ArgumentException();
            }
            this.developer = Developer;
        }

        public String getPublisher()
        {
            return this.publisher;
        }
        public void setPublisher(String Publisher)
        {
            if (Publisher.Equals("") || Publisher.Length > 20)
            {
                throw new ArgumentException();
            }
            this.publisher = Publisher;
        }

        public String getGenre()
        {
            return this.genre;
        }
        public void setGenre(String Genre)
        {
            if (Genre.Equals("") || Genre.Length > 20)
            {
                throw new ArgumentException();
            }
            this.genre = Genre;
        }

        public String getDescription()
        {
            return this.description;
        }
        public void setDescription(String Description)
        {
            if (Description.Equals("") || Description.Length > 50)
            {
                throw new ArgumentException();
            }
            this.description = Description;
        }

        public Int32 getQuantity()
        {
            return this.quantity;
        }
        public void setQuantity(Int32 Quantity)
        {
            if (Quantity > 0 && Quantity < Int32.MaxValue)
            {
                this.quantity = Quantity;
            }
            else
                throw new ArgumentException();
        }

        public decimal getBuyPrice()
        {
            return this.buyPrice;
        }
        public void setBuyPrice(decimal BuyPrice)
        {
            if (BuyPrice > 0 && BuyPrice < 1000)
            {
                this.buyPrice = BuyPrice;
            }
            else
                throw new ArgumentException();
        }

        public decimal getSalePrice()
        {
            return this.salePrice;
        }
        public void setSalePrice(decimal SalePrice)
        {
            if (SalePrice > 0 && SalePrice < 1000)
            {
                this.salePrice = SalePrice;
            }
            else
                throw new ArgumentException();
        }

        public String getStatus()
        {
            return this.status;
        }
        public void setStatus(String Status)
        {
            this.status = Status;
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
            OracleConnection connection = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO Games VALUES (" + getNextGameID() + ",'" +
                this.title + "','" + this.developer + "','" + this.publisher + "','" +
                this.genre + "','" + this.description + "'," + this.buyPrice + "," +
                this.salePrice + "," + this.quantity + ",'Registered')";

            /*    INSERT INTO Games VALUES (id,'title','DEV','PUB','DESC','GENRE',12,12,12,'R')         */

            OracleCommand cmd = new OracleCommand(sqlQuery, connection);
            connection.Open();
            cmd.ExecuteNonQuery();

            connection.Close();
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

        public void deregisterGame()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Games SET " +
                "Status = 'Deregistered' " +
                "WHERE Game_Id = " + this.gameId;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataSet findGameByTitle(String title)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT Game_Id, Title, Developer, Publisher, Genre," +
                "Description, salePrice FROM Games WHERE Title LIKE '%" + title + "%' AND Status='Registered'";

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

        public void reduceQuantity()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Games SET Quantity = Quantity - 1 WHERE Game_ID = " + this.gameId;

            Console.WriteLine(sqlQuery);

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public String orderString()
        {
            return "Game ID: " + getGameId().ToString("00000") + " Title: " + getTitle() + " Price: " + getSalePrice().ToString("#000.00");
        }

        public String toString()
        {
            return "Game ID: " + getGameId() +
                "\nTitle: " + getTitle() + 
                "\nDeveloper: " + getDeveloper() + 
                "\nPublisher: " + getPublisher() + 
                "\nDescription: "+ getDescription() + 
                "\nGenre: " + getGenre() +
                "\nQuantity: " + getQuantity() + 
                "\nCost to buy: " + getBuyPrice() + 
                "\nSale Price: " + getSalePrice() + 
                "\nStatus: " + getStatus();
        }
    }
}
