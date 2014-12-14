open System
  
[<EntryPoint>]
let main argv = 
    Seq.initInfinite (fun _ -> Console.ReadLine())
        |> Seq.takeWhile (fun i -> i <> null)
        |> List.ofSeq
        |> List.fold (fun acc elem -> elem :: acc) []
        |> Seq.iter (printfn "%s")

    0 // return an integer exit code