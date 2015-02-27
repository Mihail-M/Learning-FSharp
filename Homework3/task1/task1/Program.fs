let listTepmlate =  [1; 5; 6; 2]
let l = List.zip (0::listTepmlate) (listTepmlate @ [0]) 
let listSumPair = List.map (fun (x, y) -> x+y) l
let listMax= List.max listSumPair

printfn "%A"  (List.findIndex ((=)listMax ) listSumPair)