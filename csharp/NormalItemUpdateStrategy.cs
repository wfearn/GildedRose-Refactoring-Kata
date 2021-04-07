using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class NormalItemUpdateStrategy : IUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;

            if (item.Quality > 0)
            {
                item.Quality--;

                if (item.SellIn < 0)
                {
                    item.Quality--;
                }
            }
        }
    }
}
