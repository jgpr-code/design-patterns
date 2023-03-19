namespace ObjectOrientedPatterns
{
    namespace AbstractFactory
    {
        public interface ICheapCar
        {
            public void Drive();
        }

        public interface IExpensiveCar
        {
            public void Drive();
            public void Entertainment();
        }

        public interface ICarFactory
        {
            public ICheapCar CreateCheapCar();
            public IExpensiveCar CreateExpensiveCar();
        }

        internal class CheapOpel : ICheapCar
        {
            public void Drive()
            {
                Console.WriteLine("driving a cheap Opel");
            }
        }

        internal class ExpensiveOpel : IExpensiveCar
        {
            public void Drive()
            {
                Console.WriteLine("driving an expensive Opel");
            }

            public void Entertainment()
            {
                Console.WriteLine("Opel entertainment");
            }
        }

        internal class CheapTesla : ICheapCar
        {
            public void Drive()
            {
                Console.WriteLine("driving a cheap Tesla (you're walking)");
            }
        }

        internal class ExpensiveTesla : IExpensiveCar
        {
            public void Drive()
            {
                Console.WriteLine("driving an expensive Tesla");
            }

            public void Entertainment()
            {
                Console.WriteLine("Tesla entertainment");
            }
        }

        public class OpelFactory : ICarFactory
        {
            public ICheapCar CreateCheapCar()
            {
                return new CheapOpel();
            }

            public IExpensiveCar CreateExpensiveCar()
            {
                return new ExpensiveOpel();
            }
        }

        public class TeslaFactory : ICarFactory
        {
            public ICheapCar CreateCheapCar()
            {
                return new CheapTesla();
            }

            public IExpensiveCar CreateExpensiveCar()
            {
                return new ExpensiveTesla();
            }
        }
    }
}