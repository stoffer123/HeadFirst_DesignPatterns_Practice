using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    internal class IntObserver : IObserver
    {
        private ConcreteSubject subject;
        private int intObserved;

        public IntObserver(ConcreteSubject subject)
        {
            this.subject = subject; //The subject to observe
            intObserved = 0; //Initial value
        }

        public void update()
        {
            intObserved = subject.getIntInfo();
        }

        public void printInt()
        {
            Console.WriteLine($"[IntObserver] {intObserved}");
        }
    }
}
