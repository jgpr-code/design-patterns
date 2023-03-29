namespace FunctionalPatterns
namespace FunctionalPatterns.Structural

module Adapter =

    type Greetings =
        { greetFormal: unit -> string
          greetInformal: unit -> string }

    type Hello =
        { sayHello: string -> unit
          whatsUp: string -> unit }

    let newHello name =
        { sayHello = fun prefix -> printfn "Hello %s %s" prefix name
          whatsUp = fun prefix -> printfn "What's up %s %s" prefix name}

    // Type to be adapted: Hello
    // Type that is needed: Greetings
    // Adapter pattern is basically a function:
    //  Hello -> <Additional Hello config (here prefix)> -> Greetings
    let newGreetingsAdapter legacyHello prefix =
        { greetFormal = fun () -> legacyHello.sayHello prefix; prefix
          greetInformal = fun () -> legacyHello.whatsUp prefix; prefix }

