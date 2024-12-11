using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    internal class StringObserver : IObserver
    {
        private ConcreteSubject subject;
        private string stringObserved;

        public StringObserver(ConcreteSubject subject)
        {
            this.subject = subject; //The subject to observe
            stringObserved = String.Empty; //Initial value
        }

        public void update()
        {
            stringObserved = subject.getStringInfo();
        }

        public void printString()
        {
            Console.WriteLine($"[StringObserver] {stringObserved}");
        }
    }
}
