using System;

namespace DesignPatterns.Creational.AbstractFactory.GUIFactory
{
    public class WinButton : IButton
    {
        // Concrete products are created by corresponding concrete
        // factories.
        public void Click()
        {
            Console.WriteLine("Painting a button in Window style");
        }
    }
}