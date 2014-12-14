open System

[<EntryPoint>]
let main args = 
    let i = Console.ReadLine() |> int

    for j in 1..i do
        printfn "Hello World"

    0