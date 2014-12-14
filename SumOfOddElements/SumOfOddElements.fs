open System
  
[<EntryPoint>]
let main argv = 
    Seq.initInfinite (fun _ -> Console.ReadLine())
        |> Seq.takeWhile (fun i -> i <> null)
        |> Seq.map int
        |> Seq.filter(fun i -> i % 2 <> 0)
        |> Seq.sum
        |> printfn "%d"

    0 // return an integer exit code