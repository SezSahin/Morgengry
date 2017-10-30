using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public enum Level
    {
        low,
        medium,
        high
    }
    public class Amulet : Merchandise
    {
        public string Design;
        public Level Quality;

        public Amulet(string itemId, Level quality, string design) :
            base(itemId)
        {
            Design = design;
            Quality = quality;
        }
        public Amulet(string itemId, Level quality) :
            this(itemId, quality, "")
        {
        }
        public Amulet(string itemId) :
            this(itemId, Level.medium, "")
        {
        }
        public override string ToString()
        {
            return "ItemId: " + ItemId.ToString() + ", Quality: " + Quality.ToString() + ", Design: " + Design.ToString();
        }
    }
}
