using System.Collections.Generic;

namespace Observer{
    public interface IObservable{
        List<IObserver> observers {get;}

        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);

        void Notify();
    }
}