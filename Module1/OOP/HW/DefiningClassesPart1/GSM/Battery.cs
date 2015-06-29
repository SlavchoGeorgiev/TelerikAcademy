using System;
namespace GSMlib
{
    public class Battery
    {
        private String model;
        private double? hoursIdleTime;
        private double? hoursTalkTime;
        private BatteryType type;
        public Battery()
        {
            this.Model = null;
            this.HoursIdleTime = null;
            this.HoursTalkTime = null;
        }
        public Battery(String model, double? hoursIdleTime, double? hoursTalkTime)
        {
            this.Model = model;
            this.HoursIdleTime = hoursIdleTime;
            this.HoursTalkTime = hoursTalkTime;
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
        public double? HoursIdleTime
        {
            get
            {
                return this.hoursIdleTime;
            }
            set
            {
                if (value >= 0 || value == null)
                {
                    this.hoursIdleTime = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Hours idle time should be positive number!");
                }
            }
        }
        public double? HoursTalkTime
        {
            get
            {
                return this.hoursTalkTime;
            }
            set
            {
                if (value >= 0 || value == null)
                {
                    this.hoursTalkTime = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Hours talk time should be positive number!");
                }
            }
        }
        public BatteryType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
    }
}
