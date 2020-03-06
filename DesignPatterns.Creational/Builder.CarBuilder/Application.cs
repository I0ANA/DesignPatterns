namespace DesignPatterns.Creational.Builder.CarBuilder
{
    // The client code creates a builder object, passes it to the
    // director and then initiates the construction process. The end
    // result is retrieved from the builder object.
    public class Application
    {
        public void MakeCar()
        {
            var builder = new CarBuilder();
            var director = new Director(builder);
            CarBuilder carBuilder = director.ConstructSportsCar();
            var car = builder.GetProduct();

            var manualBuilder = new CarManualBuilder();
            var manualDirector = new Director(manualBuilder);
            var confiduredBuilder = manualDirector.ConstructSportsCar();
            var manual = confiduredBuilder.GetProduct();
        }
    }
}
