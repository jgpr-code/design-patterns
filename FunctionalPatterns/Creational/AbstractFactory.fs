namespace FunctionalPatterns
namespace FunctionalPatterns.Creational

module AbstractFactory =

    // Observation: Record types that just hold functions can be used like interfaces

    type CheapCar = { drive: unit -> unit }

    type ExpensiveCar =
        { drive: unit -> unit
          entertain: unit -> unit }

    type CarFactory =
        { createCheapCar: unit -> CheapCar
          createExpensiveCar: unit -> ExpensiveCar }

    let private newCeapOpel () =
        { CheapCar.drive = fun () -> printfn "driving a cheap Opel" }

    let private newExpensiveOpel () =
        { ExpensiveCar.drive = fun () -> printfn "driving an expensive Opel"
          entertain = fun () -> printfn "Opel entertainment" }

    let private newCheapTesla () =
        { CheapCar.drive = fun () -> printfn "driving a cheap Tesla (you're walking)" }

    let private newExpensiveTesla () =
        { ExpensiveCar.drive = fun () -> printfn "driving an expensive Tesla"
          entertain = fun () -> printfn "Tesla entertainment" }

    let newOpelFactory () =
        { createCheapCar = fun () -> newCeapOpel ()
          createExpensiveCar = newExpensiveOpel }

    let newTeslaFactory () =
        { createCheapCar = newCheapTesla
          createExpensiveCar = newExpensiveTesla }
