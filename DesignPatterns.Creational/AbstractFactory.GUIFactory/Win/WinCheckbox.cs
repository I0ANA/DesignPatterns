using System;

namespace DesignPatterns.Creational.AbstractFactory.GUIFactory
{
    public class WinCheckbox : ICheckbox
    {
        // Concrete products are created by corresponding concrete
        // factories.
        public void Create()
        {
            Console.WriteLine("Creating a checkBox in Window style");
        }
    }
}