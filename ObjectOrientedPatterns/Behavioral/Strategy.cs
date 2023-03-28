namespace ObjectOrientedPatterns.Behavioral.Strategy
{
    public interface ISpeakingStrategy
    {
        public void Speak(string text);
    }
    public class Screaming : ISpeakingStrategy
    {
        public void Speak(string text) => Console.WriteLine(text.ToUpper());
    }
    public class SlowTalk : ISpeakingStrategy
    {
        public void Speak(string text) => Console.WriteLine(string.Join(' ', text.ToCharArray()));
    }

    public class Speaking
    {
        public Speaking(ISpeakingStrategy strategy)
        {
            myStrategy = strategy;
        }
        public void SpeakText(string text)
        {
            myStrategy.Speak(text);
        }
        private ISpeakingStrategy myStrategy;
    }
}
