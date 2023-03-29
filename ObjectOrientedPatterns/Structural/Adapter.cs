namespace ObjectOrientedPatterns.Structural.Adapter
{
    // see https://en.wikipedia.org/wiki/Adapter_pattern

    public interface IGreetings
    {
        public string GreetFormal();
        public string GreetInformal();
    }

    public class SayHelloAdapter : IGreetings
    {
        public SayHelloAdapter(SayHello sayHello, string prefix)
        {
            mySayHello = sayHello;
            myPrefix = prefix;
        }
        public string GreetFormal()
        {
            mySayHello.Hello(myPrefix);
            return myPrefix;
        }
        public string GreetInformal()
        {
            mySayHello.WhatsUp(myPrefix);
            return myPrefix;
        }
        private readonly SayHello mySayHello;
        private readonly string myPrefix;
    }

    public class SayHello
    {
        public SayHello(string name)
        {
            myName = name;
        }
        public void Hello(string prefix)
        {
            Console.WriteLine("Hello " + prefix + " " + myName);
        }
        public void WhatsUp(string prefix)
        {
            Console.WriteLine("What's up " + prefix + " " + myName);
        }
        private readonly string myName;
    }
}
