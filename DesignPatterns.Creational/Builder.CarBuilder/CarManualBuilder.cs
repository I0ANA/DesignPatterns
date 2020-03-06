using System;

namespace DesignPatterns.Creational.Builder.CarBuilder
{
    public class CarManualBuilder : ICarBuilder
    {
        private ICarManual _manual;

        public CarManualBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _manual = new CarManual();
        }

        public void SetEngine()
        {
            Console.WriteLine("Reset the _manual features");
        }

        public void SetGps()
        {
            Console.WriteLine("Reset the _manual features");
        }

        public void SetSeats()
        {
            Console.WriteLine("Document seats");
        }

        public ICarManual GetProduct()
        {
            //optional reset and return object
            return _manual;
        }
    }
}
