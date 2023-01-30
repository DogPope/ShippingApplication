using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingApplication
{
    class Game
    {
        private static Int32 GameID { get; set; }
        private String Title { get; set; }
        private String Developer { get; set; }
        private String Publisher { get; set; }
        private decimal BuyPrice { get; set; }
        private decimal SalePrice { get; set; }
        private char Status { get; set; }
    }
    /*public Game(Int32 GameID, String Title, String Developer, String Publisher, float BuyPrice, float SalePrice, char Status)
    {
        SetGameID(GameID);
        SetTitle(Title);
        SetDeveloper(Developer);
        SetPublisher(Publisher);
        SetBuyPrice(BuyPrice);
        SetSalePrice(SalePrice);
        SetStatus(Status);
    }
    public SetGameID(Int32 GameID)
    {
        this.GameID = ++GameID;
    }*/
}
