let plus x y = x + y
let plus2 = plus 2 

printfn "%A" (List.map (fun x -> plus x 2 ) [1..10] )
printfn "%A" (List.map (plus2) [1..10] )
printfn "%A" (List.map (plus 2) [1..10] )