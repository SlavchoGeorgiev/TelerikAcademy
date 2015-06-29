using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GSMlib
{
    public class GSM
    {
        private String model;
        private String manufacturer;
        private Decimal? price;
        private String owner;
        private Display display;
        public Battery battery;
        private List<Call> callHistory = new List<Call>();
        private static GSM iPhone4S = new GSM("IPhone 4S", "Apple", 260.5M, "Pesho", new Battery("CSB", 240, 12), new Display(4, 16000000));
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.display = new Display();
            this.battery = new Battery();
        }
        public GSM(String model, String manufacturer, Decimal? price, String owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.display = display;
            this.battery = battery;
        }

        public String Model 
        { 
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public String Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }
        public Decimal? Price
        {
            get 
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public String Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
        public double? DisplaySize
        {
            get
            {
                return this.display.Size;
            }
            set
            {
                this.display.Size = value;
            }
        }
        public double? DisplayNumberOfColors
        {
            get
            {
                return this.display.NumberOfColors;
            }
            set
            {
                this.display.NumberOfColors = value;
            }
        }
        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(this.callHistory);
            }
        }
        public static GSM IPhone4S 
        {
            get
            {
                return iPhone4S;
            }
        }
        public override string ToString()
        {
            StringBuilder gsmSB = new StringBuilder();
            gsmSB.Append(String.Format("Model: {0} \n", this.Model));
            gsmSB.Append(String.Format("Manufacturer: {0} \n", this.Manufacturer));
            gsmSB.Append(String.Format("Owner: {0} \n", this.Owner ?? "N/A"));
            gsmSB.Append(String.Format("Price: {0} $\n", this.Price ?? 0));
            gsmSB.Append(String.Format("Display size: {0} \n", this.DisplaySize ?? 0));
            gsmSB.Append(String.Format("Display number of colors: {0} \n", this.DisplayNumberOfColors ?? 0));
            gsmSB.Append(String.Format("Battery model: {0} \n", this.battery.Model ?? "N/A"));
            gsmSB.Append(String.Format("Battery type: {0} \n", this.battery.Type.ToString() ?? "N/A"));
            gsmSB.Append(String.Format("Battery hours idle time: {0} \n", this.battery.HoursIdleTime ?? 0));
            gsmSB.Append(String.Format("Battery hours talk time: {0} \n", this.battery.HoursTalkTime ?? 0));
            return gsmSB.ToString();
        }
        public void AddCallToList(Call call)
        {
            this.callHistory.Add(call);
        }
        public void DeleteCallFromList(Call call)
        {
            this.callHistory.Remove(call);
        }
        public void ClearCallHistory()
        {
            this.callHistory = new List<Call>();
        }
        public decimal CallPrice(decimal pricePerMinute)
        {
            return pricePerMinute * (decimal)TotalTalkTime();
        }
        public double TotalTalkTime()
        {
            double totalTalkTime = 0;
            foreach (var call in this.callHistory)
            {
                totalTalkTime += call.Duration;
            }
            return totalTalkTime;
        }

    }
}
