namespace FunctionalPatterns

module AbstractFactory =

    type CheapCar = { drive: unit -> unit }

    type ExpensiveCar =
        { drive: unit -> unit
          entertain: unit -> unit }

    type CarFactory =
        { createCheapCar: unit -> CheapCar
          createExpensiveCar: unit -> ExpensiveCar }

    let private createCheapOpel () =
        { drive = fun () -> printfn "drive a cheap Opel" }

    let private createExpensiveOpel () =
        { drive = fun () -> printfn "drive an expensive Opel"
          entertain = fun () -> printfn "Opel entertains you" }

    let private createCheapTesla () =
        { drive = fun () -> printfn "drive a cheap Tesla (you're walking)" }

    let private createExpensiveTesla () =
        { drive = fun () -> printfn "drive an expensive Tesla"
          entertain = fun () -> printfn "Tesla entertains you" }

    let createOpelFactory () =
        { createCheapCar = fun () -> createCheapOpel ()
          createExpensiveCar = fun () -> createExpensiveOpel () }

    let createTeslaFactory () =
        { createCheapCar = fun () -> createCheapTesla ()
          createExpensiveCar = fun () -> createExpensiveTesla () }
