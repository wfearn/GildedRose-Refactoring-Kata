namespace csharp
{
    public class ItemFactory
    {
        public static GildedRoseItem CreateItem(string itemName, int itemSellIn, int itemQuality)
        {
            switch (itemName)
            {
                case "Aged Brie":
                    return new AgedBrieItem
                    {
                        Quality = itemQuality,
                        SellIn = itemSellIn
                    };

                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstagePassItem
                    {
                        Quality = itemQuality,
                        SellIn = itemSellIn
                    };
                case "Sulfuras, Hand of Ragnaros":
                    return new LegendaryItem
                    {
                        Quality = itemQuality,
                        SellIn = itemSellIn
                    };

                case "Conjured Mana Cake":
                    return new ConjuredItem
                    {
                        Quality = itemQuality,
                        SellIn = itemSellIn
                    };

                default:
                    return new NormalItem
                    {
                        Quality = itemQuality,
                        SellIn = itemSellIn
                    };

            }
        }
    }
}
