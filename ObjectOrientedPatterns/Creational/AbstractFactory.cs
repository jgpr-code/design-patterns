namespace ObjectOrientedPatterns.Creational.AbstractFactory
{
    // see https://en.wikipedia.org/wiki/Abstract_factory_pattern

    // interface AbstractProductA
    public interface ICheapCar
    {
        public void Drive();
    }

    // interface AbstractProductB
    public interface IExpensiveCar
    {
        public void Drive();
        public void Entertainment();
    }

    // interface AbstractFactory
    public interface ICarFactory
    {
        public ICheapCar CreateCheapCar();
        public IExpensiveCar CreateExpensiveCar();
    }

    // ProductA1
    internal class CheapOpel : ICheapCar
    {
        public void Drive() => Console.WriteLine("driving a cheap Opel");
    }

    // ProductB1
    internal class ExpensiveOpel : IExpensiveCar
    {
        public void Drive() => Console.WriteLine("driving an expensive Opel");
        public void Entertainment() => Console.WriteLine("Opel entertainment");
    }

    // ProductA2
    internal class CheapTesla : ICheapCar
    {
        public void Drive() => Console.WriteLine("driving a cheap Tesla (you're walking)");
    }

    // ProductB2
    internal class ExpensiveTesla : IExpensiveCar
    {
        public void Drive() => Console.WriteLine("driving an expensive Tesla");
        public void Entertainment() => Console.WriteLine("Tesla entertainment");
    }

    // ConcreteFactory1
    public class OpelFactory : ICarFactory
    {
        public ICheapCar CreateCheapCar() => new CheapOpel();
        public IExpensiveCar CreateExpensiveCar() => new ExpensiveOpel();
    }

    // ConcreteFactory2
    public class TeslaFactory : ICarFactory
    {
        public ICheapCar CreateCheapCar() => new CheapTesla();
        public IExpensiveCar CreateExpensiveCar() => new ExpensiveTesla();
    }
}