namespace DesignPatterns.Creational.FactoryMethod.AirConditionerFactory
{
    public abstract class AirConditionerFactory
    {
        public abstract IAirConditioner Create(double temperature);
    }
}
