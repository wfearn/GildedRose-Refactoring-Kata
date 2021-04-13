namespace csharp
{
    public class ItemFactory
    {
        public static GildedRoseItem CreateItem(string itemName, int itemSellIn, int itemQuality)
        {
            return new NormalItem
            {
                Quality = itemQuality,
                SellIn = itemSellIn
            };
        }
    }
}
