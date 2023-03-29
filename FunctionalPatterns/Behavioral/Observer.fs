namespace FunctionalPatterns
namespace FunctionalPatterns.Behavioral

module Observer =

    type StockMarket =
        { name: string
          price: double }

    let newStockMarket name price =
        { name = name
          price = price }

    let updateStockMarket stock price =
        { stock with price = price }

    type Investor =
        { name: string
          action: StockMarket -> unit }

    let newInvestor name =
        { name = name
          action = fun market -> printfn "[%s] received update from %s: %f" name market.name market.price}

    // just a small helper to get an empty F# list in C#
    let noInitialObservers: Investor list = []
    
    let registerObserver (investor: Investor) marketObservers = investor :: marketObservers

    let removeObserver investor marketObservers =
        List.filter (fun obs -> obs.name <> investor.name) marketObservers

    let notifyObservers market marketObservers =
        List.iter (fun investor -> investor.action market) marketObservers