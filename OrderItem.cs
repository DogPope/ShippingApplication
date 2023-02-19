using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingApplication
{
    class OrderItem
    {
        private Game game;
        private Order order;
        public OrderItem()
        {
            this.game = null;
            this.order = null;
        }
        public OrderItem(Game game, Order order)
        {
            this.game = game;
            this.order = order;
        }

        public Order getOrder()
        {
            return this.order;
        }
        public void setOrder(Order order)
        {
            this.order = order;
        }

        public Game getGame()
        {
            return this.game;
        }
        public void setGame(Game game)
        {
            this.game = game;
        }

        public String toString()
        {
            return "Order ID: " + getOrder() + "\nGame Id: " + getGame();
        }
    }
}
