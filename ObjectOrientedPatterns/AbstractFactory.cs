namespace ObjectOrientedPatterns
{
    namespace AbstractFactory
    {
        public interface ICheapCar
        {
            public void drive();
        }
        public interface IExpensiveCar
        {
            public void drive();
            public void entertain();
        }
        public interface ICarFactory
        {
            public ICheapCar createCheapCar();
            public IExpensiveCar createExpensiveCar();
        }
        internal class CheapOpel : ICheapCar
        {
            public void drive()
            {
                Console.WriteLine("driving a cheap Opel");
            }
        }
        internal class ExpensiveOpel : IExpensiveCar
        {
            public void drive()
            {
                Console.WriteLine("driving an expensive Opel");
            }

            public void entertain()
            {
                Console.WriteLine("you are entertained by your expensive Opel");
            }
        }
        internal class CheapTesla : ICheapCar
        {
            public void drive()
            {
                Console.WriteLine("drive a cheap Tesla (you're walking)");
            }
        }
        internal class ExpensiveTesla : IExpensiveCar
        {
            public void drive()
            {
                Console.WriteLine("driving an expensive Tesla");
            }

            public void entertain()
            {
                Console.WriteLine("you are entertained by your expensive Tesla");
            }
        }
        public class OpelFactory : ICarFactory
        {
            public ICheapCar createCheapCar()
            {
                return new CheapOpel();
            }

            public IExpensiveCar createExpensiveCar()
            {
                return new ExpensiveOpel();
            }
        }
        public class TeslaFactory : ICarFactory
        {
            public ICheapCar createCheapCar()
            {
                return new CheapTesla();
            }

            public IExpensiveCar createExpensiveCar()
            {
                return new ExpensiveTesla();
            }
        }
    }
}