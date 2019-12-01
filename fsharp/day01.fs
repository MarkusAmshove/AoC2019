module fsharp.day01
open fsharp

let calculateFuelRequirement mass =
    (mass / 3) - 2

let solvePart1 masses =
    masses |> Seq.sumBy calculateFuelRequirement

let rec calculateTotalFuelRequirement mass =
    match calculateFuelRequirement mass with
    | m when m > 0 -> m + calculateTotalFuelRequirement m
    | _ -> 0

let solvePart2 masses =
    masses |> Seq.sumBy calculateTotalFuelRequirement

let solve =
    let input = helper.readInputLines "01.txt" int
    printfn "Part 01: %d" (solvePart1 input)
    printfn "Part 02: %d" (solvePart2 input)
