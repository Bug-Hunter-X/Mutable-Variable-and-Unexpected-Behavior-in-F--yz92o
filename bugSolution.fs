let mutable x = 0
let addOne () = x <- x + 1
let y = x
printf "%d" y
addOne ()
printf "%d" x