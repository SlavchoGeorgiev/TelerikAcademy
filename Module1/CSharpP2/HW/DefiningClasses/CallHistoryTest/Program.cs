using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSMlib;

namespace CallHistoryTest
{
    class Program
    {
        static void Main()
        {
            //Create an instance of the GSM class.
            GSM myPhone = new GSM("One", "One Plus");
            myPhone.Owner = "I";
            myPhone.Price = 1000;
            myPhone.DisplaySize = 5;
            myPhone.DisplayNumberOfColors = 16000000;
            myPhone.battery.Type = BatteryType.LiIon;
            myPhone.battery.Model = "RBC18";
            myPhone.battery.HoursIdleTime = 426.5;
            myPhone.battery.HoursTalkTime = 24.3;
            myPhone.AddCallToList(new Call(DateTime.Now, "0885649596", 5));
            //Add few calls.
            for (int i = 10; i < 60; i = i + 5)
            {
                myPhone.AddCallToList(new Call(DateTime.Now.AddMinutes(i), "08856495" + i, i));
            }
            Console.WriteLine(myPhone.ToString());
            //Display the information about the calls.
            foreach (var call in myPhone.CallHistory)
            {
                Console.WriteLine("{0} - Phone number: {1} - Duration: {2}", call.Time, call.PhoneNumber, call.Duration);
            }
            Console.WriteLine("Total talk time: {0}", myPhone.TotalTalkTime());
            //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            Console.WriteLine("The total price of the calls in the history is : {0}", myPhone.CallPrice(0.37M));
            //Remove the longest call from the history and calculate the total price again.
            myPhone.DeleteCallFromList(FindLongestCall(myPhone.CallHistory));
            foreach (var call in myPhone.CallHistory)
            {
                Console.WriteLine("{0} - Phone number: {1} - Duration: {2}", call.Time, call.PhoneNumber, call.Duration);
            }
            Console.WriteLine("Total talk time: {0}", myPhone.TotalTalkTime());
            Console.WriteLine("The total price of the calls in the history is : {0}", myPhone.CallPrice(0.37M));
            //Finally clear the call history and print it.
            myPhone.ClearCallHistory();
            foreach (var call in myPhone.CallHistory)
            {
                Console.WriteLine("{0} - Phone number: {1} - Duration: {2}", call.Time, call.PhoneNumber, call.Duration);
            }
            Console.WriteLine("Total talk time: {0}", myPhone.TotalTalkTime());
            Console.WriteLine("The total price of the calls in the history is : {0}", myPhone.CallPrice(0.37M));
        }
        static Call FindLongestCall(List<Call> callHistory)
        {
            Call longestCall = new Call(DateTime.Now, "", 0);
            foreach (var call in callHistory)
            {
                if (call.Duration > longestCall.Duration)
                {
                    longestCall = call;
                }
            }
            return longestCall;
        }
    }
}
