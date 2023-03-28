namespace FunctionalPatterns
namespace FunctionalPatterns.Structural

module Adapter =

    type Greetings =
        { greetFormal: unit -> string
          greetInformal: unit -> string }

    type Hello =
        { sayHello: string -> unit
          whatsUp: string -> unit }

    let sayHello prefix name =
        printfn "Hello %s %s" prefix name

    let whatsUp prefix name =
        printfn "What's up %s %s" prefix name

    let private flip f x y = f y x
    let getHello name =
        { sayHello = fun (prefix) -> sayHello prefix name
          whatsUp =  (flip whatsUp) name} // Flip + currying :)

    let greetFormalAdapter (legacyHellos: Hello) prefix =
        legacyHellos.sayHello prefix
        prefix

    let greetInformalAdapter (legacyHellos: Hello) prefix =
        legacyHellos.whatsUp prefix
        prefix

    // Type to be adapted: Hellos
    // Type that is needed: Greetings
    // Adapter pattern is basically a function:
    //  Hellos -> <Additional Hellos config (here prefix)> -> Greetings
    let getGreetingsAdapter legacyHellos prefix =
        { greetFormal = fun () -> greetFormalAdapter legacyHellos prefix
          greetInformal = fun () -> greetInformalAdapter legacyHellos prefix}

