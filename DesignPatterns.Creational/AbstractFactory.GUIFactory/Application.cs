namespace DesignPatterns.Creational.AbstractFactory.GUIFactory
{
    public class Application
    {
        private readonly IGuiFactory _abstractFactory;
        private IButton _button;

        public Application(IGuiFactory abstractFactory)
        {
            _abstractFactory = abstractFactory;
        }

        public void CreateUserInterface()
        {
            _button = _abstractFactory.CreateButton();
            var checkboxc = _abstractFactory.CreateCheckBox();
        }

        public void Click()
        {
            _button.Click();
        }
    }
}
