let rec checkPalindrom (str : string) =
   let size = str.Length
   match size with
   | 0 |  1 -> true
   | _ -> if (str.[0] <> str.[size-1] ) then false
          else checkPalindrom str.[1..size - 2]


printfn "%b" (checkPalindrom "azaza")
printfn "%b" (checkPalindrom "avada kedavra")
printfn "%b" (checkPalindrom "l")
printfn "%b" (checkPalindrom "")
  