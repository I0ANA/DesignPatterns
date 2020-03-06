using System;

namespace DesignPatterns.Creational.AbstractFactory.GUIFactory
{
    public class MacButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Painting a button in Mac style");
        }
    }
}