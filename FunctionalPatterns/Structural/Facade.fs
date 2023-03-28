namespace FunctionalPatterns
namespace FunctionalPatterns.Structural

module Facade =

    type Cpu = 
        { freeze: unit -> unit
          jump: int64 -> unit
          execute: unit -> unit }
    let newCpu =
        { freeze = fun () -> printfn "Freeze Cpu"
          jump = fun pos -> printfn "Jump %d" pos
          execute = fun () -> printfn "Execute"}

    type HardDrive = { read: int64 -> int32 -> unit }
    let newHardDrive =
        { read = fun lba size -> printfn "Read at %d of size %d" lba size}

    type Memory = { load: int64 -> unit }
    let newMemory =
        { load = fun pos -> printfn "Loading at %d" pos}

    type Computer =
        { start: unit -> unit }
    let newComputer cpu hardDrive memory =
        { start = fun () ->
            let bootSector = 7
            let sectorSize = 42
            let bootAddress = 1234
            cpu.freeze ()
            hardDrive.read bootSector sectorSize
            memory.load bootAddress
            cpu.jump bootAddress
            cpu.execute () }
