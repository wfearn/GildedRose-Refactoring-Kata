namespace csharp
{
    public abstract class GildedRoseItem
    {
        private int quality;

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
}
