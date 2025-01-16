using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Light
    {
        private string _name;

        public Light(string name) 
        {
            this._name = name;
        }

        public void TurnOnLight()
        {
            Console.WriteLine($"{_name} is turned ON");
        }

        public void TurnOffLight()
        {
            Console.WriteLine($"{_name} is turned OFF");
        }
    }
}
