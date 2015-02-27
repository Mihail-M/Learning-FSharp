let isUniq _list =
   let  list = List.sort _list
   let forCompare = (List.zip (0::list) (list@[0]) ) |> List.map (fun (x,y) -> (x = y)) 

   not (List.fold (fun acc x -> acc || x) false forCompare)

isUniq [1..10] |> printfn "%A"
isUniq (1::[1..10]) |> printfn "%A"

    