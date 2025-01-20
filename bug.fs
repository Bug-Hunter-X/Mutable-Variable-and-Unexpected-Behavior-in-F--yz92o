let mutable x = 0
let addOne x = x + 1
let y = addOne x
printf "%d" y
x <- x + 1
printf "%d" x