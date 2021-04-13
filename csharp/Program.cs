using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<GildedRoseItem> Items = new List<GildedRoseItem>();
            Items.Add(ItemFactory.CreateItem("+5 Dexterity Vest", 10, 20));
            Items.Add(ItemFactory.CreateItem("Aged Brie", 2, 0));
            Items.Add(ItemFactory.CreateItem("Elixir of the Mongoose", 5, 7));
            Items.Add(ItemFactory.CreateItem("Sulfuras, Hand of Ragnaros", 0, 80));
            Items.Add(ItemFactory.CreateItem("Sulfuras, Hand of Ragnaros", -1, 80));
            Items.Add(ItemFactory.CreateItem("Backstage passes to a TAFKAL80ETC concert", 15, 20));
            Items.Add(ItemFactory.CreateItem("Backstage passes to a TAFKAL80ETC concert", 10, 49));
            Items.Add(ItemFactory.CreateItem("Backstage passes to a TAFKAL80ETC concert", 5, 49));
            Items.Add(ItemFactory.CreateItem("Conjured Mana Cake", 3, 6));

            var app = new GildedRose(Items);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j]);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
