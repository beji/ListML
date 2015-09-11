namespace ListML

module Core =

  type KeyValue = {key: string; value: string}

  let attr key value = {key = key; value = value}

  let renderAttribute kv = kv.key + "=\"" + kv.value + "\""

  let checkforClosingTag hasClosingtag trueCond falseCond =
    match hasClosingtag with
    | true -> trueCond
    | false -> falseCond

  let node (tag:string) (attributes:KeyValue list) (children: string list) =

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
