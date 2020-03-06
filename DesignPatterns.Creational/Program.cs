using System;
using DesignPatterns.Creational.FactoryMethod.AirConditionerFactory;
using Action = DesignPatterns.Creational.FactoryMethod.AirConditionerFactory.Action;

namespace DesignPatterns.Creational
{
    class Program
    {
        static void Main(string[] args)
        {
         
            /*Source: https://code-maze.com/factory-method/*/
            var currentTemperature = 25;
            var newTemperature = 22.5;

            var explicitlyDeclaredFactories = new AirConditioner();
                explicitlyDeclaredFactories.ExecuteCreation(Action.Cooling, newTemperature)
                .Operate();

            //factories created using refletion
            var factory = new AirConditionerWithRefletion()
                .ExecuteCreation(currentTemperature > newTemperature ? Action.Cooling : Action.Warming, newTemperature + 1);
                factory.Operate();

            //factories using reflection but hidden Constructor
            AirConditionerWithFactoryMethod
                .InitializeFactories()
                .ExecuteCreation(Action.Cooling, newTemperature + 2)
                .Operate();

            Console.ReadKey();
        }
    }
}
