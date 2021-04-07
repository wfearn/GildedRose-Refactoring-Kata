using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class LegendaryItemUpdateStrategy : IUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            // function is empty because legendary items do not
            // degrade in quality and do not have to be sold.
        }
    }
}
