let rec insertionSort l= 
    let rec insert f elem list = 
        match list with
            |[] -> [elem]
            |h::t -> if f elem h then
                        elem::list
                     else h::(insert f elem t)
    
    match l with
        |[] -> []
        |h::t -> insert  (fun a b -> a > b) h (insertionSort t) 


printf "%A" (insertionSort [1..10])