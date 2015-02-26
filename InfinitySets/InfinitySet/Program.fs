//пустое множество
let empty = false
//числа от 2 до 100
let from2to100 e = (e >=2 && e <= 100)

//odds
let odds e = (e % 2 = 1)

//intersect
let intersect s1 s2 e = (s1 e) && (s2 e)
let union s1 s2 e = (s1 e) || (s2 e)
let diff s1 s2 e = (s1 e) && !(s2 e)

//добавить элемент а 
let addElem a s e = (e = a) || (s e) 
//example
let SwithA a = addElem a

//удалить элемент
let remElem a s e = (e <> a) && (s e)

let fromSet = List.filter
printf "%A" (fromSet odds [1..40])

//обратная fromSet [] -> (int -> bool)
let fromList ls e = List.exists e ls
//example 
let oddFrom2to100 = fromList [2..2..100]






