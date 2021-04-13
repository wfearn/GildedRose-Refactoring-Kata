using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<GildedRoseItem> Items;
        public GildedRose(IList<GildedRoseItem> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                this.Items[i].UpdateItem();
            }
        }
    }
}
