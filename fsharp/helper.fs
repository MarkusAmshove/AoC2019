module fsharp.helper
open System.IO

let readInputLines fileName toType =
    Path.Combine(__SOURCE_DIRECTORY__, "inputs", fileName)
    |> File.ReadLines
    |> Seq.map toType
