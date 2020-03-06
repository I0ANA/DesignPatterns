using System.Collections.Generic;

namespace DesignPatterns.Creational.FactoryMethod.AirConditionerFactory
{
    public class AirConditioner
    {
        private readonly Dictionary<Action, AirConditionerFactory> _factories;

        public AirConditioner()
        {
            _factories = new Dictionary<Action, AirConditionerFactory>
            {
                { Action.Cooling, new CoolingFactory() },
                { Action.Warming, new WarmingFactory() }
            };
       }

        public IAirConditioner ExecuteCreation(Action action, double temperature)
            => _factories[action].Create(temperature); 
    }
}
