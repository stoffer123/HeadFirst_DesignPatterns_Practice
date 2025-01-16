using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    internal class TurnOnLight : ILightCommand
    {
        private Light light;

        public TurnOnLight(Light light) 
        {
            this.light = light;
        }
        public void Execute()
        {
            light.TurnOnLight();
        }

        public void UnExecute()
        {
            light.TurnOffLight();
        }
    }
}
