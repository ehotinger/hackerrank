open System

[<EntryPoint>]
let main args = 
  let input = 
    Seq.initInfinite (fun _ -> Console.ReadLine())
    |> Seq.takeWhile (fun s -> s <> null)
    |> Seq.map int
    |> List.ofSeq
  List.filter (fun t -> t < (List.head input)) (List.tail input)
  |> List.iter (printfn "%d")
  0