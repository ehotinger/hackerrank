open System

[<EntryPoint>]
let main args = 
  let negative n = if n > 0 then n else -n

  Seq.initInfinite (fun _ -> Console.ReadLine())
      |> Seq.takeWhile (fun s -> s <> null)
      |> Seq.map (int >> negative)
      |> Seq.iter (printfn "%d")
  0