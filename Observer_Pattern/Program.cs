namespace Observer_Pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Create the subject
            ISubject subject = new ConcreteSubject();

            //Create observers (Typecast to allow access to the concrete methods)
            IObserver abstractStringObserver = new StringObserver((ConcreteSubject) subject);
            IObserver abstractIntObserver = new IntObserver((ConcreteSubject)subject);
            
            //Add observers to subject's observer list
            subject.addObserver(abstractStringObserver);
            subject.addObserver(abstractIntObserver);

            //Write the initial values of the observers.
            StringObserver stringObserver = (StringObserver) abstractStringObserver;
            stringObserver.printString();
            IntObserver intObserver = (IntObserver) abstractIntObserver;
            intObserver.printInt();

            //Subject notifyes observers of an update
            subject.notify();

            //Write new observer values taken from the subject
            stringObserver.printString();
            intObserver.printInt();


        }
    }
}