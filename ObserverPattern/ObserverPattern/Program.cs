using System;
using System.Collections;
using System.Threading;

namespace ObserverPattern
{   
    /// <summary>
    /// Main class.
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsWidget currentConditionsWidget = new CurrentConditionsWidget(weatherData);
            AVGConditionsWidget AVGWidget = new AVGConditionsWidget(weatherData);

            weatherData.setMesurements(1, 1, 1);
            Thread.Sleep(5000);
            weatherData.setMesurements(0, 0, 1);
            Thread.Sleep(5000);
            weatherData.setMesurements(45, 1, 4);

        }
    }

    #region Interfaces
    /// <summary>
    /// Интерфейс субъекта
    /// </summary>
    public interface Subject {

         void registerObserver(Observer o);
         void removeObserver(Observer o);
        /// <summary>
        /// Рассылка слушателям
        /// </summary>
         void notifyObservers();

    }

    /// <summary>
    /// Observer.
    /// </summary>
    public interface Observer {
        void update (float temperature, float humidity, float pressure);
    }


    public interface DisplayElement {
         void display();
    }

    #endregion
  
    #region Subject
    public class WeatherData : Subject {


        private ArrayList observers = new ArrayList();
        private float temperature;
        private float humidity;
        private float pressure;


        #region Subject implementation

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(i);
            }
        }

        public void notifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                Observer observer = (Observer)observers[i];
                observer.update(temperature, humidity, pressure);
            }
        }

        #endregion

        public void mesurementsChanged() {
            notifyObservers();
        }

        public void setMesurements(float temperature, float humidity, float pressure) {

            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            mesurementsChanged();

        }


    }
    #endregion

    #region Widgets
    /// <summary>
    /// Current conditions widget.
    /// </summary>
    public class CurrentConditionsWidget : Observer, DisplayElement {

        private float temperature;
        private float humidity;
        private float pressure;
        private Subject weatherData;

        public CurrentConditionsWidget (Subject weatherData) {

            this.weatherData = weatherData;
            weatherData.registerObserver(this);

        }

        #region DisplayElement implementation

        public void display()
        {   
            Console.Clear();
            Console.WriteLine("Temperature: " + temperature);
            Console.WriteLine("Humidity: " + humidity);
            Console.WriteLine("Pressure: " + pressure);
        }

        #endregion

        #region Observer implementation

        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            display();
        }

        #endregion



    }

    /// <summary>
    /// AVG conditions widget.
    /// </summary>
    public class AVGConditionsWidget : Observer, DisplayElement {

        private float AVGtemperature;
        private float AVGhumidity;
        private float AVGpressure;
        private int NumberOfMesurments;
        private Subject weatherData;

        public AVGConditionsWidget (Subject weatherData) {

            this.weatherData = weatherData;
            weatherData.registerObserver(this);

        }

        #region DisplayElement implementation

        public void display()
        {   
            //Console.Clear();
            Console.WriteLine(" AVG Temperature: " + AVGtemperature/NumberOfMesurments);
            Console.WriteLine("AVG Humidity: " + AVGhumidity/NumberOfMesurments);
            Console.WriteLine("AVG Pressure: " + AVGpressure/NumberOfMesurments);
        }

        #endregion

        #region Observer implementation

        public void update(float temperature, float humidity, float pressure)
        {
            this.AVGtemperature += temperature;
            this.AVGhumidity += humidity;
            this.AVGpressure += pressure;
            NumberOfMesurments++;
            display();
        }

        #endregion



    }
    #endregion
}
