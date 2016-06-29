namespace ListML

module Core =

  let attr (key:string) (value:string) = key, value

  let renderAttribute kv =
    let key, value = kv
    sprintf "%s=\"%s\"" key value

  let checkforClosingTag hasClosingtag trueCond falseCond =
    match hasClosingtag with
    | true -> trueCond
    | false -> falseCond

  let node (tag:string) (attributes:(string * string) list) (children: string list) =

    let hasClosingtag =
      match children with
      | [] -> false
      | _ -> true
    
    let concat left right = sprintf "%s%s" left right

    [
      "<"
      tag
      List.fold (fun left right -> sprintf "%s %s" left (renderAttribute right)) "" attributes
      checkforClosingTag hasClosingtag ">" "/>"
      List.fold concat "" children
      checkforClosingTag hasClosingtag "</" ""
      checkforClosingTag hasClosingtag tag ""
      checkforClosingTag hasClosingtag ">" ""
    ] |> List.fold concat ""
