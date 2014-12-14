open System
  
[<EntryPoint>]
let main argv = 
    let s = Console.ReadLine() |> int
    seq { for i in 1..s do yield i }
    |> Seq.fold (fun s i ->
        if s = "" then sprintf "%i" i
        else sprintf "%s, %i" s i) ""
    |> (fun s -> sprintf "[%s]" s)
    |> Console.WriteLine

    0 // return an integer exit code

// To get the points
//open System
//  
//[<EntryPoint>]
//let main argv =
//    let s = Console.ReadLine() |> int
//    printfn "%d" s
//    0