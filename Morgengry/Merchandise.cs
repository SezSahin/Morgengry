using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public abstract class Merchandise : IValuable
    {
        public string ItemId { get; set; }
        public Merchandise(string itemId)
        {
            ItemId = itemId;
        }

        public abstract double GetValue();

        public override string ToString()
        {
            return "ItemId: " + ItemId.ToString();
        }
    }
}
