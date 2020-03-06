namespace DesignPatterns.Creational.Builder.CarBuilder
{
    // The director is only responsible for executing the building
    // steps in a particular sequence. It's helpful when producing
    // products according to a specific order or configuration.
    // Strictly speaking, the director class is optional, since the
    // client can control builders directly.
    class Director
    {
        private ICarBuilder _carBuilder;

        // The director works with any builder instance that the
        // client code passes to it. This way, the client code may
        // alter the final type of the newly assembled product.
        public Director(ICarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }

        // The director can construct several product variations
        // using the same building steps.
        public CarBuilder ConstructSportsCar()
        {
            _carBuilder.Reset();
            _carBuilder.SetEngine();
            _carBuilder.SetGps(true);

            return _carBuilder;
        }

        public void ConstructSUVCar()
        {
         //...
        }
    }
}
