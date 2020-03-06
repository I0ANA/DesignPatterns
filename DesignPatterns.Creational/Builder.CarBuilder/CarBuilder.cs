using System;

namespace DesignPatterns.Creational.Builder.CarBuilder
{
    class CarBuilder : ICarBuilder
    {
        private ICar _car;

        public CarBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            Console.WriteLine("Reset _car features");
        }

        public void SetEngine()
        {
            Console.WriteLine("Install a given engine to _car");
        }
        public void SetGps(bool v)
        {
            throw new NotImplementedException();
        }

        public void SetSeats()
        {
            Console.WriteLine("Set the number of seats in the _car");
        }

        // Usually, after returning the end result to the client, a
        // builder instance is expected to be ready to start
        // producing another product. That's why it's a usual
        // practice to call the reset method at the end of the
        // `getProduct` method body. However, this behavior isn't
        // mandatory, and you can make your builder wait for an
        // explicit reset call from the client code before disposing
        // of the previous result.
        public ICar GetProduct()
        {
            var product = _car;

            //optional
            Reset();

            return product;
        }


    }
}
