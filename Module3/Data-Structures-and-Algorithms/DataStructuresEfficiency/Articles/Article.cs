namespace Articles
{
    using System;

    public class Article : IComparable<Article>
    {
        public Article(string vendor, decimal price, long barcode)
        {
            this.Vendor = vendor;
            this.Price = price;
            this.Barcode = barcode;
        }

        public long Barcode { get; set; }

        public string Vendor { get; set; }

        public decimal Price { get; set; }
        
        public int CompareTo(Article other)
        {
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return string.Format("{0,-15}| Price: {1,-15:F2}| BarCode: {2}", this.Vendor.PadRight(20), this.Price, this.Barcode);
        }
    }
}
