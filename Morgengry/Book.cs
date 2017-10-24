using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Book : Merchandise
    {
        string ItemId;
        string Title;
        double Price;

        public Book(string itemId, string title, double price)
        {
            Title = title;
            Price = price;
        }
        public Book(string itemId, string title) :
            this(itemId, title, 0)
        {
        }
        public Book(string itemId) :
            this(itemId, "", 0)
        {
        }

        public override string ToString()
        {
            return "ItemId: " + ItemId.ToString() + ", Title: " + Title.ToString() + ", Price: " + Price.ToString();
        }
    }
}
