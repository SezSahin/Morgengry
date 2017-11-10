using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public interface IValuable
    {
        string ItemId { get; set; }
        double GetValue();
    }
}
