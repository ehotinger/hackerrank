open System

let readInput() = 
  Seq.initInfinite (fun _ -> Console.ReadLine())
  |> Seq.takeWhile (fun s -> s <> null)
  |> Seq.map int
  
[<EntryPoint>]
let main argv = 
    let s = Console.ReadLine() |> int

    readInput()
    |> Seq.iter (fun x -> for i in 1..s do printfn "%d" x)

    0 // return an integer exit code