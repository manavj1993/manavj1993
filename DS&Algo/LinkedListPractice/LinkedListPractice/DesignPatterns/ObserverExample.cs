using System;

namespace LinkedListPractice.RoughProblemSolving
{
    public class Subject
    {
        public delegate void EventHandler(string message);
        public event EventHandler Notify;

        public void Change(string message)
        {
            Notify?.Invoke(message);
        }
    }

    public class Observer
    {
        private string name;

        public Observer(string name, Subject subject)
        {
            this.name = name;
            //subject.Notify += Update;
            subject.Notify += Update;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{name} received: {message}");
        }
    }

    public static class ObserverClientClass
    {
        public static void Function()
        {
            Subject sbj = new Subject();

            Observer obs = new Observer("observer", sbj);
            sbj.Change("message");
            //obs.Update("message");  
        }
    }
}
