using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class AgedBrieUpdateStrategy : IUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            if(item.Quality < 50)
            {
                item.Quality++;
            }

            item.SellIn--;
        }
    }
}
