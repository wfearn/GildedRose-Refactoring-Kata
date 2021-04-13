namespace csharp
{
    public abstract class GildedRoseItem
    {
        protected int quality;

        public virtual int Quality
        {
            get { return quality; }
            set
            {
                if (value > 50)
                {
                    quality = 50;
                }
                else if (value < 0)
                {
                    quality = 0;
                }
                else
                {
                    quality = value;
                }
            }
        }

        public int SellIn { get; set; }

        public virtual void DecrementQuality()
        {
            Quality--;
        }

        public virtual void IncrementQuality()
        {
            Quality++;
        }

        public virtual void DecrementSellIn()
        {
            SellIn--;
        }

        public virtual void UpdateItem()
        {
            this.UpdateSellIn();
            this.UpdateQuality();
        }
        public abstract void UpdateQuality();
        public abstract void UpdateSellIn();
    }

    public class LegendaryItem : GildedRoseItem
    {
        public override int Quality
        {
            get { return this.quality; }
            set { this.quality = value; }
        }

        public override void UpdateQuality()
        {
        }

        public override void UpdateSellIn()
        {
        }
    }

    public class NormalItem : GildedRoseItem
    {
        public override void UpdateQuality()
        {
            this.DecrementQuality();

            if (this.SellIn < 0)
            {
                this.DecrementQuality();
            }
        }

        public override void UpdateSellIn()
        {
            this.DecrementSellIn();
        }
    }

    public class AgedBrieItem : GildedRoseItem
    {
        public override void UpdateQuality()
        {
            this.IncrementQuality();
        }

        public override void UpdateSellIn()
        {
            this.DecrementSellIn();
        }
    }

    public class BackstagePassItem : GildedRoseItem
    {
        public override void UpdateQuality()
        {
            if (this.SellIn < 0)
            {
                this.Quality = 0;
                return;
            }

            this.IncrementQuality();

            if (this.SellIn < 11)
            {
                this.IncrementQuality();
            }

            if (this.SellIn < 6)
            {
                this.IncrementQuality();
            }
        }

        public override void UpdateSellIn()
        {
            this.DecrementSellIn();
        }
    }

    public class ConjuredItem : GildedRoseItem
    {

        public override void DecrementQuality()
        {
            this.Quality -= 2;
        }

        public override void UpdateQuality()
        {
            this.DecrementQuality();

            if (this.SellIn < 0)
            {
                this.DecrementQuality();
            }
        }

        public override void UpdateSellIn()
        {
            this.DecrementSellIn();
        }
    }
}
