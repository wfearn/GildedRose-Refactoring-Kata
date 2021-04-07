using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class BackstagePassUpdateStrategy : IUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            if (item.SellIn > 0)
            {
                item.Quality++;

                if (item.SellIn < 11)
                {
                    item.Quality++;
                }

                if (item.SellIn < 6)
                {
                    item.Quality++;
                }

                if (item.Quality > 50)
                {
                    item.Quality = 50;
                }
            }
            else
            {
                item.Quality = 0;
            }

            item.SellIn--;
        }
    }
}
