using System;

namespace DesignPatterns.Creational.AbstractFactory.GUIFactory
{
    public class MacCheckbox : ICheckbox
    {
        public void Create()
        {
            Console.WriteLine("Creating a checkboc in Mac style");
        }
    }
}