namespace DesignPatterns.Creational.FactoryMethod.AirConditionerFactory
{
    public class CoolingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature)
        {
            return new Cooling(temperature);
        }
    }
}
