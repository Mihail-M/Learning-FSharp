let reverse list = 
    let rec iteration list result  =  
        match list with
          | [] -> result
          | hd::tl ->  iteration  tl (hd :: result)
    iteration list []

printfn "%A \n" (reverse ["Dasha", "Sasha", "VLad", "Ivan", "Valera", "Grisha", "Kudren", "Ivan", "Ilya", "Artem", "Lida" ])

