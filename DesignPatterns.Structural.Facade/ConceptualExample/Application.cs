using System.Diagnostics;

namespace DesignPatterns.Structural.Facade.ConceptualExample
{
    public class Application
    {
        //Source: https://refactoring.guru/design-patterns/facade/csharp/example#
        public void MainConceptualFacade(string[] args)
        {
            // The client code may have some of the subsystem's objects already
            // created. In this case, it might be worthwhile to initialize the
            // Facade with these objects instead of letting the Facade create
            // new instances.
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            Facade facade = new Facade(subsystem1, subsystem2);

            Client.ClientCode(facade);
        }
    }
}