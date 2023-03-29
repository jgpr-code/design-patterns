namespace ObjectOrientedPatterns.Creational.FactoryMethod
{
    // see https://en.wikipedia.org/wiki/Factory_method_pattern

    public interface IFileReader
    {
        void Read();
    }

    class TextFileReader : IFileReader
    {
        public void Read() => Console.WriteLine("Reading text file...");
    }

    class PDFFileReader : IFileReader
    {
        public void Read() => Console.WriteLine("Reading PDF file...");
    }

    public class FileReaderFactory
    {
        public static IFileReader CreateFileReader(string fileExtension)
        {
            switch (fileExtension.ToLower())
            {
                case ".txt":
                    return new TextFileReader();
                case ".pdf":
                    return new PDFFileReader();
                default:
                    throw new ArgumentException("Unsupported file type");
            }
        }
    }
}
