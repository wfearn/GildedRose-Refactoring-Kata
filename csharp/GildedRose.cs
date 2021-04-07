using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        Dictionary<string, IUpdateStrategy> UpdateStrategies;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items; 
            this.UpdateStrategies = new Dictionary<string, IUpdateStrategy>();
            this.UpdateStrategies.Add("Aged Brie", new AgedBrieUpdateStrategy());
            this.UpdateStrategies.Add("Sulfuras, Hand of Ragnaros", new LegendaryItemUpdateStrategy());
            this.UpdateStrategies.Add("Backstage passes to a TAFKAL80ETC concert", new BackstagePassUpdateStrategy());
            this.UpdateStrategies.Add("Conjured Mana Cake", new ConjuredItemUpdateStrategy());
            this.UpdateStrategies.Add("Everything Else", new NormalItemUpdateStrategy());
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if(this.UpdateStrategies.ContainsKey(Items[i].Name))
                {
                    this.UpdateStrategies[Items[i].Name].UpdateQuality(Items[i]);
                }
                else
                {
                    this.UpdateStrategies["Everything Else"].UpdateQuality(Items[i]);
                }
            }
        }
    }
}
