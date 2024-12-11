using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    internal class ConcreteSubject : ISubject
    {
        List<IObserver> observers;

        public ConcreteSubject()
            {
                observers = new List<IObserver>();
            }

        public void addObserver(IObserver observer)
        {
            if (observer == null) throw new ArgumentNullException(); //Null check this badboy
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                Console.WriteLine($"Added {observer.ToString} to the observerlist");
                return;
            }

            Console.WriteLine($"Observerlist already contains {observer.ToString}");

        }

        public void notify()
        {
            Console.WriteLine("Notifying observers");
            foreach (IObserver observer in observers)
            {
                observer.update();
            }
        }

        public void removeObserver(IObserver observer)
        {
            if(!observers.Contains(observer))
            {
                Console.WriteLine($"{observer.ToString} does not exist in observerlist");
                return;
            }
            if (observer == null) throw new ArgumentNullException();

            Console.WriteLine($"Removing {observer.ToString} from observer list");
            observers.Remove(observer);
        }

        //For the StringObserver type
        public string getStringInfo()
        {
            return "Some string for the StringObserver observer type.";
        }

        //For the IntObserver class
        public int getIntInfo()
        {
            return 10;
        }
    }
}
