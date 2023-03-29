namespace FunctionalPatterns
namespace FunctionalPatterns.Structural

module Decorator =

    type Window = { draw: unit -> unit }

    let newNormalWindow () =
        { draw = fun () -> printfn "A normal window" }

    let verticalScrollbar window =
        { draw = window.draw >> (fun () -> printfn "  with scroll bar") }

    let menuBar window =
        { draw = window.draw >> (fun () -> printfn "  with menu bar")}
