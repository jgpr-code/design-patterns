namespace FunctionalPatterns
namespace FunctionalPatterns.Creational

module Singleton =
    open System

    // Not really a functional solution as we use mutable.
    // Singleton is very difficult (not possible?) to implement purely functional.
    // So here we make use of F# multiparadigm features.
    let mutable private configValue = lazy None

    let private parseInt () =
        Console.WriteLine("Initialize Singleton: Please config a value (int):")
        let line = Console.ReadLine()
        try
           Int32.Parse(line)
        with
           | _ -> 0

    let getValue () =
        match configValue.Force() with
        | Some value -> value
        | None ->
            let value = parseInt ()
            configValue <- lazy Some(value)
            value
