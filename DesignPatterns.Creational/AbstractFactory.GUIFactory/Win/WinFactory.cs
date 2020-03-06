using System;

namespace DesignPatterns.Creational.AbstractFactory.GUIFactory
{

    public class WinFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckbox CreateCheckBox()
        {
            return new WinCheckbox();
        }
    }
}
