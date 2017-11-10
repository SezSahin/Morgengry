using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Course : IValuable
    {
        public string Name;
        public int DurationInMinutes { get; set; }
        public double CourseHourValue { get; set; } = 825.0;
        public string ItemId { get; set; }

        public Course(string name) :
            this(name, 0)
        {
            
        }
        public Course(string name, int duration)
        {
            Name = name;
            DurationInMinutes = duration;
        }

        public double GetValue()
        {
            double price = 0.0;
            int timer = DurationInMinutes / 60;
            int rest = DurationInMinutes - (timer * 60);
            if(rest > 0)
            {
                timer++;
            }
            price = timer * CourseHourValue; //Skal implementeres til at regne CourseHourValue ud
            return price;
        }

        public override string ToString()
        {
            return "Name: " + Name.ToString() + ", " + "Duration in Minutes: " + DurationInMinutes.ToString() + ", " + "Pris pr påbegyndt time: " + CourseHourValue.ToString();
        }
    }
}
