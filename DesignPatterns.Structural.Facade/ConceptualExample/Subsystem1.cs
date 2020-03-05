namespace DesignPatterns.Structural.Facade.ConceptualExample
{
    // The Subsystem can accept requests either from the facade or client
    // directly. In any case, to the Subsystem, the Facade is yet another
    // client, and it's not a part of the Subsystem.
    public class Subsystem1
    {
        public string operation1()
        {
            return "Subsystem1: Ready!\n";
        }
        public string OperationN()
        {
            return "Subsystem1: Go!\n";
        }
        public string OperationNNNN()
        {
            return "Subsystem1: Nth unnecessary method!\n";
        }
    }
}