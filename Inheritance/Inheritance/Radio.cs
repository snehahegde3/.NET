using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Radio : ElectricalDevice
    {

        public Radio(bool isOn, string brand):base(isOn, brand){}


        public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listnin");
            }
            else
            {
                Console.WriteLine("Radio is switched off. Please switch it on first");
            }
        }
    }
}
