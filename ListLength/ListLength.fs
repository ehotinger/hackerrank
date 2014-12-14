open System
  
[<EntryPoint>]
let main argv = 
    let s = 0

    Seq.initInfinite (fun _ -> Console.ReadLine())
        |> Seq.takeWhile (fun i -> i <> null)
        |> Seq.map (fun i -> 1)
        |> Seq.sum
        |> printfn "%d"

    0 // return an integer exit code