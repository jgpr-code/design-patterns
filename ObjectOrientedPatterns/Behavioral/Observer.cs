namespace ObjectOrientedPatterns.Behavioral.Observer
{
    // Subject
    public interface IStockMarket
    {
        string Name { get; }
        double Price { get; set; }
        void AddObserver(IInvestor investor);
        void RemoveObserver(IInvestor investor);
        void NotifyObservers();
    }

    // ConcreteSubject
    public class StockMarket : IStockMarket
    {
        public StockMarket(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; }
        public double Price
        {
            get => myPrice;
            set
            {
                if (myPrice != value)
                {
                    myPrice = value;
                    NotifyObservers();
                }
            }
        }
        public void AddObserver(IInvestor investor) => myInvestors.Add(investor);
        public void RemoveObserver(IInvestor investor) => myInvestors.Remove(investor);
        public void NotifyObservers()
        {
            foreach (var investor in myInvestors)
            {
                investor.Update(this);
            }
        }

        private readonly List<IInvestor> myInvestors = new List<IInvestor>();
        private double myPrice;
    }

    // Observer
    public interface IInvestor
    {
        void Update(IStockMarket stockMarket);
    }

    // ConcreteObserver
    public class Investor : IInvestor
    {
        public Investor(string name) => myName = name;

        public void Update(IStockMarket stockMarket) =>
            Console.WriteLine($"[{myName}] received update from {stockMarket.Name}: ${stockMarket.Price}");

        private readonly string myName;
    }

}
