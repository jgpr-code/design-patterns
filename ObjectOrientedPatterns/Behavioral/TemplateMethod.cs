namespace ObjectOrientedPatterns.Behavioral.TemplateMethod
{
    // see https://en.wikipedia.org/wiki/Template_method_pattern

    public abstract class Game
    {
        public void Play()
        {
            Init();

            StartPlay();

            End();
        }

        protected abstract void Init();
        protected abstract void StartPlay();
        protected abstract void End();
    }

    public class Mario : Game
    {
        protected sealed override void Init() => Console.WriteLine("Starting console");
        protected sealed override void StartPlay() => Console.WriteLine("... jump jump jump ...");
        protected sealed override void End() => Console.WriteLine("Thanks for saving me, Mario!");
    }

    public class Chess : Game
    {
        protected sealed override void Init() => Console.WriteLine("Setting up the pieces");
        protected sealed override void StartPlay() => Console.WriteLine("moving pieces around");
        protected sealed override void End() => Console.WriteLine("Checkmate!");
    }
}
