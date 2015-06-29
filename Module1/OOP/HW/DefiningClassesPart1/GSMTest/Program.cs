using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSMlib;

namespace GSMTest
{
    class Program
    {
        static void Main()
        {
            GSM[] phones = new GSM[10];
            for (int i = 0; i < phones.Length; i++)
            {
                string model = "Model " + (i + 1);
                string manufacturer = "Manufacture " + (i * 10);
                decimal price = i * 142M;
                string owner = "Pesho" + (i + 1);
                Display display = new Display(0.5 * i + 1, (i + 2) * 1000);
                Battery battery = new Battery("Bat" + i, (i + 1) * 12, (i + 1) * 3);
                battery.Type = (BatteryType)(i % 3);
                phones[i] = new GSM(model, manufacturer, price, owner, battery, display);
            }
            foreach (var gsm in phones)
            {
                Console.WriteLine(gsm.ToString());
                Console.WriteLine();
            }
            Console.WriteLine(GSM.IPhone4S.ToString());
        }
    }
}
