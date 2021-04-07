using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class ConjuredItemUpdateStrategy : IUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality > 0)
            {
                if (item.SellIn > 0)
                {
                    // Better implemented in an abstract superclass
                    item.Quality = item.Quality - 2 < 0 ? 0 : item.Quality - 2;
                }
                else
                {
                    item.Quality = item.Quality - 4 < 0 ? 0 : item.Quality - 4;
                }
            }

            item.SellIn--;
        }
    }
}
