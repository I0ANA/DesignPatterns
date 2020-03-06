using System;

namespace DesignPatterns.Creational.AbstractFactory.GUIFactory
{
    // Concrete products are created by corresponding concrete
    // factories.
    public class MacFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckBox()
        {
            return new MacCheckbox();
        }
    }
}
