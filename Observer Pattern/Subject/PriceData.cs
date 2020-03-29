using System.Collections.Generic;

namespace Observer_Pattern
{
    public class PriceData : Subject
    {
        private List<Observer> observers;
        private float price;
        private float volume;

        public PriceData()
        {
            observers = new List<Observer>();
        }

        public void notifyObservers()
        {
            foreach (Observer o in observers)
            {
                o.Update(price, volume);
            }
        }

        public void registerObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(Observer observer)
        {
            int index = observers.IndexOf(observer);
            observers.RemoveAt(index);
        }

        public void DataChanged()
        {
            notifyObservers();
        }

        public void SetData(float price, float volume)
        {
            this.price = price;
            this.volume = volume;
            DataChanged();
        }
    }
}