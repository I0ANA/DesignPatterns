using System;

namespace DesignPatterns.Structural.Facade.VideoConverter
{
    // We create a facade class to hide the framework's complexity
    // behind a simple interface. It's a trade-off between
    // functionality and simplicity.
    public interface IVideoConverterFacade
    {
        FileTest Convert(string fileName, string format);
    }

    public class VideoConverterFacade : IVideoConverterFacade
    {
        public FileTest Convert(string fileName, string format)
        {
            var file = new VideoFile(fileName);

            var sourceCodec = new CodecFactory().Extract(file);

            IMyInterface destinationCodec;
            if (format == "mp4")
                destinationCodec = new MPEG4CompressionCodec();
            else
                destinationCodec = new OggCompressionCodec();

            var buffer = BitrateReader.Read(fileName, sourceCodec);
            var result = BitrateReader.Convert(buffer, destinationCodec);
            result = (new AudioMixer()).Fix(result);

            return new FileTest(result);
        }
    }

    public class FileTest
    {
        public FileTest(string result)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }


    // These are some of the classes of a complex 3rd-party video
    // conversion framework. We don't control that code, therefore
    // can't simplify it.

    public struct AudioMixer
    {
        public string Fix(object result)
        {
            throw new NotImplementedException();
        }
    }

    public class BitrateReader
    {
        public static string Read(string filename, string sourceCodec)
        {
            throw new NotImplementedException();
        }

        public static string Convert(object buffer, IMyInterface destinationCodec)
        {
            throw new NotImplementedException();
        }
    }

    public interface IMyInterface{}

    public class OggCompressionCodec : IMyInterface
    {
    }

    public class MPEG4CompressionCodec : IMyInterface
    {
    }

    public class CodecFactory
    {
        public string Extract(VideoFile file)
        {
            throw new NotImplementedException();
        }
    }

    public class VideoFile
    {
        private readonly string _fileName;

        public VideoFile(string fileName)
        {
            _fileName = fileName;
        }
        }
}