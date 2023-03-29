namespace FunctionalPatterns
namespace FunctionalPatterns.Behavioral

module TemplateMethod =

    type Game =
        { init: unit -> unit
          startPlay: unit -> unit
          finish: unit -> unit }

    let playGame game =
        game.init ()
        game.startPlay ()
        game.finish ()

    let mario =
        { init = fun () -> printfn "Starting console"
          startPlay = fun () -> printfn "... jump jump jump ..."
          finish = fun () -> printfn "Thanks for saving me, Mario!" }

    let chess =
        { init = fun () -> printfn "Setting up the pieces"
          startPlay = fun () -> printfn "... moving pieces around ..."
          finish = fun () -> printfn "Checkmate!" }
