using CommandPattern.Commands;
using System.Collections.Generic;
using System.Windows.Input;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Light light1 = new("Light1");
            List<ILightCommand> light1Commands = new List<ILightCommand>();

            ILightCommand turnOff = new TurnOffLight(light1);
            ILightCommand turnOn = new TurnOnLight(light1);

            while (true)
            {
                turnOn.Execute();
                Console.ReadKey();

                turnOff.Execute();
                Console.ReadKey();
            }
        }
    }
}
