using System;

namespace DesignPatterns.Creational.AbstractFactory.GUIFactory
{
    // The application picks the factory type depending on the
    // current configuration or environment settings and creates it
    // at runtime (usually at the initialization stage).
    class ApplicationConfigurator
    {
        public void Main()
        {
            var configuration = ReadConfigurationFromConfigFile();
            IGuiFactory factory;

            if (configuration.OS == "Windows")
                factory = new WinFactory();
            else if (configuration.OS == "Mac")
                factory = new MacFactory();
            else
                throw new Exception("Error! Unknown operating system.");

            Application app = new Application(factory);

        }

        private static Configuration ReadConfigurationFromConfigFile()
        {
            return "Windows";
        }

        internal class Configuration
        {
            public string OS { get; set; }
        }
    }
}
