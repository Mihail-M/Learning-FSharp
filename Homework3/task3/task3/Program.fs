let even1 l = l |> List.map (fun x -> x % 2) |> List.fold (fun acc x -> acc + x) 0
let even2 l = l |> List.filter (fun x -> x % 2 = 0) |> List.length
let even3 l = l |> List.fold (fun acc x -> (acc + 1) - x % 2 ) 0

even1 [1..10] |> printfn "%A"
even2 [1..10] |> printfn "%A"
even3 [1..10] |> printfn "%A"