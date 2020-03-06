using System;
using System.Collections.Generic;

namespace DesignPatterns.Creational.FactoryMethod.AirConditionerFactory
{
    public class AirConditionerWithRefletion
    {

        private readonly Dictionary<Action, AirConditionerFactory> _factories;

        public AirConditionerWithRefletion()
        {
            _factories = new Dictionary<Action, AirConditionerFactory>();

            foreach (Action action in Enum.GetValues(typeof(Action)))
            {
                var factory = (AirConditionerFactory)Activator.CreateInstance(Type.GetType("DesignPatterns.Creational.AirConditionerFactory." + Enum.GetName(typeof(Action), action) + "Factory"));
                _factories.Add(action, factory);
            }
        }

        public IAirConditioner ExecuteCreation(Action action, double temperature) => _factories[action].Create(temperature);
    }
}
