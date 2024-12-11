using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    internal interface ISubject
    {
        void notify();
        void addObserver(IObserver observer);
        void removeObserver(IObserver observer);

    }
}
