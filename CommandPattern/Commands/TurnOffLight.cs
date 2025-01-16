using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    internal class TurnOffLight : ILightCommand
    {
        Light light;

        public TurnOffLight(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.TurnOffLight();
        }

        public void UnExecute()
        {
            light.TurnOnLight();
        }
    }
}
