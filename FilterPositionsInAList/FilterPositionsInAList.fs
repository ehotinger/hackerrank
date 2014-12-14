open System

let readInput() = 
  Seq.initInfinite (fun _ -> Console.ReadLine())
  |> Seq.takeWhile (fun s -> s <> null)
  |> Seq.map int
  
[<EntryPoint>]
let main argv = 
    readInput()
    |> Seq.mapi (fun i s -> i, int s)
    |> Seq.choose (fun (i, n) ->
      if i % 2 = 0 then None else Some n)
        |> Seq.iter (printfn "%d")

    0 // return an integer exit code