let rec insertionSort l = 
    let rec insert elem list = 
        match list with
            |[] -> [elem]
            |h::t -> if elem > h then
                        elem::list
                     else h::(insert elem t)
    
    match l with
        |[] -> []
        |h::t -> insert h (insertionSort t)


printf "%A" (insertionSort [1..10])