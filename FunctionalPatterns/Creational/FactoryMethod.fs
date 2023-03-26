namespace FunctionalPatterns
namespace FunctionalPatterns.Creational

module FactoryMethod =

    type FileReader = { read: unit -> unit }

    let readTextFile () = printfn "Reading text file..."

    let readPdfFile () = printfn "Reading pdf file..."

    let createFileReader (extension: string) =
        match extension.ToLower() with
        | ".txt" -> { read = readTextFile }
        | ".pdf" -> { read = readPdfFile }
