using System;
using System.Collections.Generic;
using System.Text;

namespace TheCashier
{
    class Item
    {
        private int id;
        public string tittle { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public double subtotal { get; set; }
        private string type;

        public Item(int id, string tittle, int quantity, double price, double subtotal, string type)
        {
            this.id = id;
            this.tittle = tittle;
            this.quantity = quantity;
            this.price = price;
            this.subtotal = subtotal;
            this.type = type;
        }

        public string getTitle()
        {
            return tittle;
        }
        public int getQuantity()
        {
            return quantity;
        }
        public double getPrice()
        {
            return price;
        }
        public string getType()
        {
            return type;
        }
        public double getSubTotal()
        {
            subtotal = price * quantity;
            return subtotal;
        }
    }
}
