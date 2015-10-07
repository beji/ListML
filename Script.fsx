// Learn more about F# at http://fsharp.net. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "ListML.fs"
#load "ListML.Html.fs"
open ListML.Core
open ListML.HTML

doctype +
html ["lang","de"; "class","test"] [
    head [] []
    body [] [
        img [attr "src" "http://lorempixel.com/g/100/100/"]
        div [][
            strong [] ["This is text inside the strong, it just works"]
        ]]]
|> printfn "%s"
