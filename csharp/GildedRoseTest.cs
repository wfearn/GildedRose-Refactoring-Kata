using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void GildedRoseTest_NormalItemCorrectUpdateAfterOneDay()
        {
            int originalSellIn = 5;
            int updatedSellIn = 4;

            int originalQuality = 20;
            int updatedQuality = 19;

            IList<GildedRoseItem> Items = new List<GildedRoseItem>();
            Items.Add(ItemFactory.CreateItem("Normal Item", originalSellIn, originalQuality));
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(Items[0].SellIn, updatedSellIn);
            Assert.AreEqual(Items[0].Quality, updatedQuality);
        }

        [Test]
        public void GildedRoseTest_NormalItemCorrectUpdateAfterSellInDatePassed()
        {
            int originalSellIn = 0;
            int updatedSellIn = -1;

            int originalQuality = 20;

            // Quality degrades twice as fast when SellIn date has passed.
            int updatedQuality = 18;

            IList<GildedRoseItem> Items = new List<GildedRoseItem>();
            Items.Add(ItemFactory.CreateItem("Normal Item", originalSellIn, originalQuality));
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(Items[0].SellIn, updatedSellIn);
            Assert.AreEqual(Items[0].Quality, updatedQuality);
        }

        [Test]
        public void GildedRoseTest_NormalItemCorrectUpdateAfterQualityZero()
        {
            int originalSellIn = 0;
            int updatedSellIn = -1;

            int originalQuality = 0;
            int updatedQuality = 0;

            IList<GildedRoseItem> Items = new List<GildedRoseItem>();
            Items.Add(ItemFactory.CreateItem("Normal Item", originalSellIn, originalQuality));
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(Items[0].SellIn, updatedSellIn);
            Assert.AreEqual(Items[0].Quality, updatedQuality);

            originalSellIn = 5;
            updatedSellIn = 4;

            originalQuality = 0;
            updatedQuality = 0;

            Items = new List<GildedRoseItem>();
            Items.Add(ItemFactory.CreateItem("Normal Item", originalSellIn, originalQuality));
            app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(Items[0].SellIn, updatedSellIn);
            Assert.AreEqual(Items[0].Quality, updatedQuality);
        }

        [Test]
        public void GildedRoseTest_ConjuredItemCorrectUpdateAfterOneDay()
        {
            int originalSellIn = 5;
            int updatedSellIn = 4;

            int originalQuality = 20;
            int updatedQuality = 18;

            IList<GildedRoseItem> Items = new List<GildedRoseItem>();
            Items.Add(ItemFactory.CreateItem("Conjured Mana Cake", originalSellIn, originalQuality));
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(Items[0].SellIn, updatedSellIn);
            Assert.AreEqual(Items[0].Quality, updatedQuality);
        }

        [Test]
        public void GildedRoseTest_ConjuredItemCorrectUpdateAfterSellInDatePassed()
        {
            int originalSellIn = 0;
            int updatedSellIn = -1;

            int originalQuality = 20;
            int updatedQuality = 16;

            IList<GildedRoseItem> Items = new List<GildedRoseItem>();
            Items.Add(ItemFactory.CreateItem("Conjured Mana Cake", originalSellIn, originalQuality));
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(Items[0].SellIn, updatedSellIn);
            Assert.AreEqual(Items[0].Quality, updatedQuality);
        }

        [Test]
        public void GildedRoseTest_AgedBrieCorrectUpdateAfterOneDay()
        {
            int originalSellIn = 5;
            int updatedSellIn = 4;

            int originalQuality = 20;
            int updatedQuality = 21;

            IList<GildedRoseItem> Items = new List<GildedRoseItem>();
            Items.Add(ItemFactory.CreateItem("Aged Brie", originalSellIn, originalQuality));
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(Items[0].SellIn, updatedSellIn);
            Assert.AreEqual(Items[0].Quality, updatedQuality);
        }

        [Test]
        public void GildedRoseTest_AgedBrieCorrectUpdateAfterQualityFifty()
        {
            int originalSellIn = 5;
            int updatedSellIn = 4;

            int originalQuality = 50;
            int updatedQuality = 50;

            IList<GildedRoseItem> Items = new List<GildedRoseItem>();
            Items.Add(ItemFactory.CreateItem("Aged Brie", originalSellIn, originalQuality));
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(Items[0].SellIn, updatedSellIn);
            Assert.AreEqual(Items[0].Quality, updatedQuality);
        }

        [Test]
        public void GildedRoseTest_LegendaryItemCorrectUpdateAfterOneDay()
        {
            int originalSellIn = 5;
            int updatedSellIn = 5;

            int originalQuality = 80;
            int updatedQuality = 80;

            IList<GildedRoseItem> Items = new List<GildedRoseItem>();
            Items.Add(ItemFactory.CreateItem("Sulfuras, Hand of Ragnaros", originalSellIn, originalQuality));
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(Items[0].SellIn, updatedSellIn);
            Assert.AreEqual(Items[0].Quality, updatedQuality);
        }

        [Test]
        public void GildedRoseTest_BackstagePassCorrectUpdateAfterOneDay()
        {
            int originalSellIn = 20;
            int updatedSellIn = 19;

            int originalQuality = 10;
            int updatedQuality = 11;

            IList<GildedRoseItem> Items = new List<GildedRoseItem>();
            Items.Add(ItemFactory.CreateItem("Backstage passes to a TAFKAL80ETC concert", originalSellIn, originalQuality));
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(Items[0].SellIn, updatedSellIn);
            Assert.AreEqual(Items[0].Quality, updatedQuality);
        }

        [Test]
        public void GildedRoseTest_BackstagePassCorrectUpdateAfterLessThanElevenDaysToSell()
        {
            int originalSellIn = 10;
            int updatedSellIn = 9;

            int originalQuality = 10;
            int updatedQuality = 12;

            IList<GildedRoseItem> Items = new List<GildedRoseItem>();
            Items.Add(ItemFactory.CreateItem("Backstage passes to a TAFKAL80ETC concert", originalSellIn, originalQuality));
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(Items[0].SellIn, updatedSellIn);
            Assert.AreEqual(Items[0].Quality, updatedQuality);
        }

        [Test]
        public void GildedRoseTest_BackstagePassCorrectUpdateAfterLessThanSixDaysToSell()
        {
            int originalSellIn = 5;
            int updatedSellIn = 4;

            int originalQuality = 10;
            int updatedQuality = 13;

            IList<GildedRoseItem> Items = new List<GildedRoseItem>();
            Items.Add(ItemFactory.CreateItem("Backstage passes to a TAFKAL80ETC concert", originalSellIn, originalQuality));
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(Items[0].SellIn, updatedSellIn);
            Assert.AreEqual(Items[0].Quality, updatedQuality);
        }

        [Test]
        public void GildedRoseTest_BackstagePassCorrectUpdateAfterConcertPassed()
        {
            int originalSellIn = 0;
            int updatedSellIn = -1;

            int originalQuality = 10;
            int updatedQuality = 0;

            IList<GildedRoseItem> Items = new List<GildedRoseItem>();
            Items.Add(ItemFactory.CreateItem("Backstage passes to a TAFKAL80ETC concert", originalSellIn, originalQuality));
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(Items[0].SellIn, updatedSellIn);
            Assert.AreEqual(Items[0].Quality, updatedQuality);
        }
    }
}
