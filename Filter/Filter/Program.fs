let rec filter f list = 
    match list with
        |[] -> []
        |(x::t) -> if f x then x::(filter f t)
                   else filter f t

printfn "Example Filter: only even  %A " (filter (fun x -> x%2 = 0 ) [2..10..100])

//example long "Quicksort" 

let rec quicksort l = 
    match l with
        |[] -> []
        |x::l -> (quicksort (List.filter ((>=) x) l)) @ [x] @ (quicksort (List.filter ((<) x) l))

printfn "Example Filter: Quicksort  %A " (quicksort [3; 2; 4; 1; 43; 34; 1; 9])
