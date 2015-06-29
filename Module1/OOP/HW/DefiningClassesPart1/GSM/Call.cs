using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMlib
{
    public class Call
    {
        public DateTime Time { get; set; }
        public string PhoneNumber { get; set; }
        public double Duration { get; set; }
        public Call(DateTime time, string phoneNumber, double duration)
        {
            this.Time = time;
            this.PhoneNumber = phoneNumber;
            this.Duration = duration;
        }
    }
}
