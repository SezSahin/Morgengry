using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class AmuletRepository
    {
        List<Amulet> amulets = new List<Amulet>();

        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);

        }
        public Amulet GetAmulet(string itemId)
        {
            foreach(Amulet a in amulets)
            {
                if(a.ItemId == itemId)
                {
                    return a;
                }
            }
            return null;
        }
        public double GetTotalValue()
        {
            Level a = 0.0;
            foreach(Amulet price in amulets)
            {
                a += Utility.GetValueOfAmulet()
            }
            return a;
        }
    }
}
