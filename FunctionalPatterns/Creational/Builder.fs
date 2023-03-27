namespace FunctionalPatterns
namespace FunctionalPatterns.Creational

module Builder =

    type Builder = 
        { clap: string -> string
          moveArms: string -> string
          moveLegs: string -> string
          moveHead: string -> string
          getChoreo: unit -> string }

    let metalBuilder =
        { clap = fun s -> s + "Smashing your hands together\n"
          moveArms = fun s -> s + "Wildly swinging your arms\n"
          moveLegs = fun s -> s + "Furiously kicking around\n"
          moveHead = fun s -> s + "Banging your head up and down\n" 
          getChoreo = fun () -> "" }

    let classicBuilder =
        { clap = fun s -> s + "Clapping your hands\n"
          moveArms = fun s -> s + "Waving your arms\n"
          moveLegs = fun s -> s + "Turning your head\n"
          moveHead = fun s -> s + "Moving around\n"
          getChoreo = fun () -> "" }

    let createChoreo (builder: Builder) =
        let build = 
            builder.moveArms
         >> builder.moveLegs
         >> builder.moveArms
         >> builder.moveHead
         >> builder.clap
        { builder with getChoreo = fun () -> build "" }

