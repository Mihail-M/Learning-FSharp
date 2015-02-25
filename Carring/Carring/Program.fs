let plus x y = x + y
let plus2 = plus 2 

printfn "%A" (List.map (fun x -> plus x 2 ) [1..10] )
printfn "%A" (List.map (plus2) [1..10] )
printfn "%A" (List.map (plus 2) [1..10] )

//exist element on list
let exist e = (List.fold ((||)) false) << (List.map ((=) e) )

printfn "Existing element in list [1..10] 2 and 11: "
printfn "2 - %b" (exist 2 [1..10])
printfn "11 - %b" (exist 11 [1..10])