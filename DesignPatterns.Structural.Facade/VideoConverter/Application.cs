namespace DesignPatterns.Structural.Facade.VideoConverter
{
    // Application classes don't depend on a billion classes
    // provided by the complex framework. Also, if you decide to
    // switch frameworks, you only need to rewrite the facade class.
    public class Application
    {

        //Source: https://refactoring.guru/design-patterns/facade
        public void Main()
        {
            IVideoConverterFacade convertor = new VideoConverterFacade();
            var mp4 = convertor.Convert("funny-cats-video.ogg", "mp4");
            mp4.Save();
        }
    }
}