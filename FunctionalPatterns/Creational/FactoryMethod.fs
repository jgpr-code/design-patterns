namespace FunctionalPatterns
namespace FunctionalPatterns.Creational

module FactoryMethod =

    // record is not necessary, type alias for unit -> unit would also suffice
    type FileReader = { read: unit -> unit }

    let readTextFile () = printfn "Reading text file..."

    let readPdfFile () = printfn "Reading PDF file..."

    let createFileReader (extension: string) =
        match extension.ToLower() with
        | ".txt" -> { read = readTextFile }
        | ".pdf" -> { read = readPdfFile }
        | _ -> raise (System.ArgumentException("Unsupported file type"))
