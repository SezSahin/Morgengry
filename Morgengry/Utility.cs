using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Utility
    {
        public string itemId;
        public string title;
        public double price;

        public static double GetValueOfBook(Book book)
        {
            return book.Price;
        }
        public static double GetValueOfAmulet(Amulet amulet)
        {
            double result = 0.0;
            if(amulet.Quality == Level.low)
            {
                result = 12.5;
            }
            if(amulet.Quality == Level.medium)
            {
                result = 20.0;
            }
            if(amulet.Quality == Level.high)
            {
                result = 27.5;
            }
            return result;

            //low -> 12.5, medium -> 20.0 og high -> 27.5
        }
        public static double GetValueOfCourse(Course course)
        {
            return course.DurationInMinutes / 60 * 875.00;

            //Værdien fastsættes som 875.00 pr påbegyndt time 
        }
        public override string ToString()
        {
            return "";
        }
    }
}
