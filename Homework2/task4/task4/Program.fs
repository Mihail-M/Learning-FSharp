let firstEntry list element = 
   let rec loop list element index = 
       match list with 
       | [] -> -1
       | head :: tail -> if (element = head) then index
                         else loop tail element (index + 1)

   loop list element 0

printfn "%d" (firstEntry [1..4] 5)
printfn "%d" (firstEntry [1..3] 1)
printfn "%d" (firstEntry [1..3] 3)

