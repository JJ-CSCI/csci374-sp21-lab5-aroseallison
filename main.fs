module Assignment

type Tree =
    | Node of Tree * Tree
    | Leaf of int

let rec prod (t:Tree) :int =
  match t with
   | Leaf i -> i
   //match tuple of node with prod(first) * prod(second) 
   | Node (l, r) -> (prod l) * (prod r)

let rec map (f:int->int) (t:Tree) :Tree =
    match t with
    //base function match Leaf with map function
    | Leaf i -> (f i) 
    //deal with node elements? and then map
    | Node (l, r) -> (f l, f r)
    

let rec foldStr (nf:string -> string -> string) (lf:int->string) (t:Tree) :string =
    ""
