namespace ListML

module Core =

  let attr (key:string) (value:string) = key, value

  let renderAttribute kv =
    let key, value = kv
    key + "=\"" + value + "\""

  let checkforClosingTag hasClosingtag trueCond falseCond =
    match hasClosingtag with
    | true -> trueCond
    | false -> falseCond

  let node (tag:string) (attributes:(string * string) list) (children: string list) =

    let hasClosingtag =
      match children with
      | [] -> false
      | _ -> true

    [
      "<"
      tag
      List.fold (fun left right -> left + " " + (renderAttribute right)) "" attributes
      checkforClosingTag hasClosingtag ">" "/>"
      List.fold (fun left right -> left + "" + right) "" children
      checkforClosingTag hasClosingtag "</" ""
      checkforClosingTag hasClosingtag tag ""
      checkforClosingTag hasClosingtag ">" ""
    ] |> List.fold (fun left right -> left + "" + right) ""
