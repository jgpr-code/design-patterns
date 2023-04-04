// The Gang of Four Design Patterns https://en.wikipedia.org/wiki/Design_Patterns

// --- Creational ---

// GoF
// [DONE] Abstract factory -> groups object factories that have a common theme.
// [DONE] Builder -> constructs complex objects by separating construction and representation.
// [DONE] Factory method -> creates objects without specifying the exact class to create.
// [todo] Prototype -> creates objects by cloning an existing object.
// [DONE] Singleton -> restricts object creation for a class to only one instance.

// Other
// Dependency Injection -> A class accepts the objects it requires from an injector instead of creating the objects directly.
// Lazy Initialization -> Tactic of delaying the creation of an object, the calculation of a value, or some other expensive process until the first time it is needed. This pattern appears in the GoF catalog as "virtual proxy", an implementation strategy for the Proxy pattern.
// Multiton -> Ensure a class has only named instances, and provide a global point of access to them.
// Object Pool -> Avoid expensive acquisition and release of resources by recycling objects that are no longer in use. Can be considered a generalisation of connection pool and thread pool patterns.
// RAII -> Ensure that resources are properly released by tying them to the lifespan of suitable objects.

// --- Structural ---

// GoF
// [DONE] Adapter -> allows classes with incompatible interfaces to work together by wrapping its own interface around that of an already existing class.
// [todo] Bridge -> decouples an abstraction from its implementation so that the two can vary independently.
// [todo] Composite -> composes zero-or-more similar objects so that they can be manipulated as one object.
// [DONE] Decorator -> dynamically adds/overrides behaviour in an existing method of an object.
// [DONE] Facade -> provides a simplified interface to a large body of code.
// [todo] Flyweight -> reduces the cost of creating and manipulating a large number of similar objects.
// [todo] Proxy -> provides a placeholder for another object to control access, reduce cost, and reduce complexity.

// Other
// Extension Object -> Adding functionality to a hierarchy without changing the hierarchy.
// Front Controller -> The pattern relates to the design of Web applications. It provides a centralized entry point for handling requests.
// Marker -> Empty interface to associate metadata with a class.
// Module Group -> several related elements, such as classes, singletons, methods, globally used, into a single conceptual entity.
// Twin -> Twin allows modeling of multiple inheritance in programming languages that do not support this feature.

// --- Behavioral ---

// GoF
// [todo] Chain of responsibility -> delegates commands to a chain of processing objects.
// [todo] Command -> creates objects that encapsulate actions and parameters.
// [todo] Interpreter -> implements a specialized language.
// [todo] Iterator -> accesses the elements of an object sequentially without exposing its underlying representation.
// [todo] Mediator -> allows loose coupling between classes by being the only class that has detailed knowledge of their methods.
// [todo] Memento -> provides the ability to restore an object to its previous state (undo).
// [DONE] Observer -> is a publish / subscribe pattern, which allows a number of observer objects to see an event.
// [todo] State -> allows an object to alter its behavior when its internal state changes.
// [DONE] Strategy -> allows one of a family of algorithms to be selected on-the-fly at runtime.
// [DONE] Template method -> defines the skeleton of an algorithm as an abstract class, allowing its subclasses to provide concrete behavior.
// [todo] Visitor -> separates an algorithm from an object structure by moving the hierarchy of methods into one object.

// Other
// Blackboard -> Artificial intelligence pattern for combining disparate sources of data (see blackboard system)
// Null Object -> Avoid null references by providing a default object.
// Servant -> Define common functionality for a group of classes. The servant pattern is also frequently called helper class or utility class implementation for a given set of classes. The helper classes generally have no objects hence they have all static methods that act upon different kinds of class objects.
// Specification -> Recombinable business logic in a Boolean fashion.
// Fluent Interface -> Design an API to be method chained so that it reads like a DSL. Each method call returns a context through which the next logical method call(s) are made available.


// The most common patterns according to ChatGPT are:
// [DONE] Singleton pattern: ensures that only one instance of a class is created and provides a global point of access to that instance.
// [DONE] Factory method pattern: defines an interface for creating objects, but lets subclasses decide which class to instantiate.
// [DONE] Abstract factory pattern: provides an interface for creating families of related or dependent objects without specifying their concrete classes.
// [DONE] Builder pattern: separates the construction of a complex object from its representation, allowing the same construction process to create different representations.
// [DONE] Adapter pattern: converts the interface of a class into another interface clients expect.
// [DONE] Decorator pattern: attaches additional responsibilities to an object dynamically.
// [DONE] Facade pattern: provides a unified interface to a set of interfaces in a subsystem.
// [DONE] Observer pattern: defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
// [DONE] Strategy pattern: defines a family of algorithms, encapsulates each one, and makes them interchangeable.
// [DONE] Template method pattern: defines the skeleton of an algorithm in a method, deferring some steps to subclasses.

using System.Text;

using ObjectOrientedPatterns.Creational.AbstractFactory;
using ObjectOrientedPatterns.Creational.Builder;
using ObjectOrientedPatterns.Creational.FactoryMethod;
using ObjectOrientedPatterns.Creational.Singleton;
using FunctionalPatterns.Creational;

using ObjectOrientedPatterns.Structural.Adapter;
using ObjectOrientedPatterns.Structural.Decorator;
using ObjectOrientedPatterns.Structural.Facade;
using FunctionalPatterns.Structural;

using ObjectOrientedPatterns.Behavioral.Observer;
using ObjectOrientedPatterns.Behavioral.Strategy;
using ObjectOrientedPatterns.Behavioral.TemplateMethod;
using FunctionalPatterns.Behavioral;

readonly struct PatternConfig
{
    public PatternConfig(string patternKeys, string patternName, Action patternExample_OO, Action patternExample_FP)
    {
        keys = patternKeys;
        name = patternName;
        example_OO = patternExample_OO;
        example_FP = patternExample_FP;
    }
    public readonly string keys;
    public readonly string name;
    public readonly Action example_OO;
    public readonly Action example_FP;
}

class Program
{
    #region Creational Examples
    #region AbstractFactory
    static void Example_AbstractFactory_OO()
    {
        // The concrete factory can be easily exchanged without the need to modify any other code
        // This can even happen at runtime
        ICarFactory factory =
        new TeslaFactory();
        //new OpelFactory();

        IExpensiveCar expensiveCar = factory.CreateExpensiveCar();
        expensiveCar.Drive();
        expensiveCar.Entertainment();

        ICheapCar car = factory.CreateCheapCar();
        car.Drive();
    }
    static void Example_AbstractFactory_FP()
    {
        // Types that hold functions in their fields can emulate this pattern
        AbstractFactory.CarFactory factory =
        //AbstractFactory.newTeslaFactory();
        AbstractFactory.newOpelFactory();

        AbstractFactory.ExpensiveCar expensiveCar = factory.createExpensiveCar.Invoke(null); // () in F# is null in C#
        expensiveCar.drive.Invoke(null);
        expensiveCar.entertain.Invoke(null);

        AbstractFactory.CheapCar car = factory.createCheapCar.Invoke(null);
        car.drive.Invoke(null);
    }
    #endregion
    #region Builder
    static void Example_Builder_OO()
    {
        var metalChoreo = new MetalChoreoBuilder();
        Choreographer metalDirector = new(metalChoreo);
        metalDirector.StandardChoreo();
        Console.WriteLine(metalChoreo.GetChoreo());

        var classicChoreo = new ClassicChoreoBuilder();
        Choreographer classicDirector = new(classicChoreo);
        classicDirector.StandardChoreo();
        Console.WriteLine(classicChoreo.GetChoreo());
    }
    static void Example_Builder_FP()
    {
        // Note: functional style doesn't mutate the builder but instead creates a new one
        var metalChoreo = Builder.createChoreo(Builder.newMetalBuilder);
        Console.WriteLine(metalChoreo.getChoreo.Invoke(null));

        var classicChoreo = Builder.createChoreo(Builder.newClassicBuilder);
        Console.WriteLine(classicChoreo.getChoreo.Invoke(null));
    }
    #endregion
    #region FactoryMethod
    static void Example_FactoryMethod_OO()
    {
        IFileReader textFileReader = FileReaderFactory.CreateFileReader(".txt");
        textFileReader.Read();

        IFileReader pdfFileReader = FileReaderFactory.CreateFileReader(".pdf");
        pdfFileReader.Read();
    }
    static void Example_FactoryMethod_FP()
    {
        FactoryMethod.FileReader textFileReader = FactoryMethod.createFileReader(".txt");
        textFileReader.read.Invoke(null);

        FactoryMethod.FileReader pdfFileReader = FactoryMethod.createFileReader(".pdf");
        pdfFileReader.read.Invoke(null);
    }
    #endregion
    #region Singleton
    static void Example_Singleton_OO()
    {
        var singleton = ConfigSingleton.GetInstance;
        Console.WriteLine(singleton.GetValue());
        Console.WriteLine(singleton.GetValue());
    }
    static void Example_Singleton_FP()
    {
        Console.WriteLine(Singleton.getValue());
        Console.WriteLine(Singleton.getValue());
    }
    #endregion
    #endregion

    #region Structural Examples
    #region Adapter
    static void Example_Adapter_OO()
    {
        SayHello legacyHello = new("Friend");

        var functionYouWantToUse = (IGreetings greet) =>
        {
            greet.GreetFormal();
            greet.GreetInformal();
        };

        SayHelloAdapter adapter = new(legacyHello, "Dear");

        functionYouWantToUse(adapter);
    }
    static void Example_Adapter_FP()
    {
        Adapter.Hello legacyHello = Adapter.newHello("Friend");

        var functionYouWantToUse = (Adapter.Greetings greet) =>
        {
            greet.greetFormal.Invoke(null);
            greet.greetInformal.Invoke(null);
        };

        Adapter.Greetings adapter = Adapter.newGreetingsAdapter(legacyHello, "Best");

        functionYouWantToUse(adapter);
    }
    #endregion
    #region Decorator
    static void Example_Decorator_OO()
    {
        IWindow window = new NormalWindow();
        window = new VerticalScrollbarDecorator(window);
        window = new MenuBarDecorator(window);
        window.Draw();
    }
    static void Example_Decorator_FP()
    {
        // Invoke is only needed for FSharpFunc's this however is compiled to a method
        Decorator.Window window = Decorator.newNormalWindow();

        window = Decorator.verticalScrollbar(window);
        window = Decorator.menuBar(window);
        window.draw.Invoke(null);
    }
    #endregion
    #region Facade
    static void Example_Facade_OO()
    {
        Cpu cpu = new();
        HardDrive hardDrive = new();
        Memory memory = new();
        ComputerFacade computer = new(cpu, hardDrive, memory);
        computer.Start();
    }
    static void Example_Facade_FP()
    {
        Facade.Cpu cpu = Facade.newCpu;
        Facade.HardDrive hardDrive = Facade.newHardDrive;
        Facade.Memory memory = Facade.newMemory;

        Facade.Computer computer = Facade.newComputer(cpu, hardDrive, memory);
        computer.start.Invoke(null);
    }
    #endregion
    #endregion

    #region Behavioral Examples
    #region Observer
    static void Example_Observer_OO()
    {
        var stockMarket = new StockMarket("NASDAQ", 100.00);

        var investor1 = new Investor("John");
        var investor2 = new Investor("Jane");

        stockMarket.AddObserver(investor1);
        stockMarket.AddObserver(investor2);

        stockMarket.Price = 105.00;

        stockMarket.RemoveObserver(investor1);

        stockMarket.Price = 110.00;
    }
    static void Example_Observer_FP()
    {
        // I wanted to avoid mutation here, so the states are chained through the computations
        var stockMarket = Observer.newStockMarket("NASDAQ", 100.00);

        var observers = Observer.noInitialObservers;
        var investor1 = Observer.newInvestor("Haskell");
        var investor2 = Observer.newInvestor("Curry");

        observers = Observer.registerObserver(investor1, observers);
        observers = Observer.registerObserver(investor2, observers);

        stockMarket = Observer.updateStockMarket(stockMarket, 105.00);
        Observer.notifyObservers(stockMarket, observers);

        observers = Observer.removeObserver(investor1, observers);

        stockMarket = Observer.updateStockMarket(stockMarket, 110.00);
        Observer.notifyObservers(stockMarket, observers);
    }
    #endregion
    #region Strategy
    static void Example_Strategy_OO()
    {
        Speaking screaming = new Speaking(new Screaming());
        screaming.SpeakText("hello");
        Speaking slowTalking = new Speaking(new SlowTalk());
        slowTalking.SpeakText("hello");
    }
    static void Example_Strategy_FP()
    {
        Strategy.SpeakingType screaming = Strategy.screaming;
        Strategy.speakText(screaming, "hello");
        Strategy.SpeakingType slowTalking = Strategy.slowTalking;
        Strategy.speakText(slowTalking, "hello");
    }
    #endregion
    #region TemplateMethod
    static void Example_TemplateMethod_OO()
    {
        Game mario = new Mario();
        mario.Play();
        Console.WriteLine("---");
        Game chess = new Chess();
        chess.Play();
    }
    static void Example_TemplateMethod_FP()
    {
        var mario = TemplateMethod.mario;
        TemplateMethod.playGame(mario);
        Console.WriteLine("---");
        var chess = TemplateMethod.chess;
        TemplateMethod.playGame(chess);
    }
    #endregion
    #endregion

    #region Main machinery
    private static readonly List<PatternConfig> myCreationalPatterns = new()
    {
        new PatternConfig("af", "AbstractFactory", Example_AbstractFactory_OO, Example_AbstractFactory_FP),
        new PatternConfig("bu", "Builder", Example_Builder_OO, Example_Builder_FP),
        new PatternConfig("fm", "FactoryMethod", Example_FactoryMethod_OO, Example_FactoryMethod_FP),
        new PatternConfig("si", "Singleton", Example_Singleton_OO, Example_Singleton_FP),
    };
    private static readonly List<PatternConfig> myStructuralPatterns = new()
    {
        new PatternConfig("ad", "Adapter", Example_Adapter_OO, Example_Adapter_FP),
        new PatternConfig("de", "Decorator", Example_Decorator_OO, Example_Decorator_FP),
        new PatternConfig("fa", "Facade", Example_Facade_OO, Example_Facade_FP),
    };
    private static readonly List<PatternConfig> myBehavioralPatterns = new()
    {
        new PatternConfig("ob", "Observer", Example_Observer_OO, Example_Observer_FP),
        new PatternConfig("st", "Strategy", Example_Strategy_OO, Example_Strategy_FP),
        new PatternConfig("tm", "TemplateMethod", Example_TemplateMethod_OO, Example_TemplateMethod_FP),
    };
    private static readonly Dictionary<string, (string, Action, Action)> myPatternsDict;

    static Program()
    {
        var allPatterns =
            myCreationalPatterns
            .Concat(myStructuralPatterns)
            .Concat(myBehavioralPatterns);
        myPatternsDict = new();
        foreach (var pattern in allPatterns) {
            myPatternsDict.Add(pattern.keys, (pattern.name, pattern.example_OO, pattern.example_FP));
        }
    }

    private const string QuitKeys = "q";
    public static void Main(string[] args)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("         Welcome to the DesignPatterns examples");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        StringBuilder sb = new();
        sb.AppendLine("Please select an example to run.");
        sb.AppendLine("Creational:");
        foreach (var pattern in myCreationalPatterns)
        {
            sb.AppendLine(Choice(pattern.keys, pattern.name));
        }
        sb.AppendLine("Structural:");
        foreach (var pattern in myStructuralPatterns)
        {
            sb.AppendLine(Choice(pattern.keys, pattern.name));
        }
        sb.AppendLine("Behavioral:");
        foreach (var pattern in myBehavioralPatterns)
        {
            sb.AppendLine(Choice(pattern.keys, pattern.name));
        }
        sb.AppendLine();
        sb.AppendLine(Choice(QuitKeys, "Quit"));
        sb.AppendLine("------------------------------------------------------------");
        var prompt = sb.ToString();
        RunRepl(prompt);
    }

    static string Choice(string keys, string command)
    {
        return keys.PadRight(3) + "-> " + command;
    }

    static void RunRepl(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine() ?? "";
            if (input == QuitKeys)
            {
                return;
            }
            else if (myPatternsDict.ContainsKey(input))
            {
                var (name, example_oo, example_fp) = myPatternsDict[input];
                RunExamples(name, example_oo, example_fp);
            }
            else
            {
                Console.WriteLine("unknown keys (you entered: " + input + ") -> try again");
            }
        }
    }

    static void RunExamples(string patternName, Action objectOrientedExample, Action functionalExample)
    {
        Console.WriteLine(patternName + ':');
        Console.WriteLine();
        Console.WriteLine("-> Object Oriented:");
        objectOrientedExample();
        Console.WriteLine();
        Console.WriteLine("-> Functional:");
        functionalExample();
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
    #endregion
}
