ListML
======

ListML is a collection of rather basic functions to generate a string representation of a XML-tree. It is inspired (but not nearly as elegant as) the X-Expressions used in Racket. The ListML.HTML module contains functions to ease the creation of a HTML-Tree and serves as an implementation example

Example (using ListML.HTML)
-------
```fsharp
open ListML.HTML

doctype +
html [attr "lang" "de"; attr "class" "test"] [
    head [] []
    body [] [
        img [attr "src" "http://lorempixel.com/g/100/100/"]
        div [][
            strong [] ["This is text inside the strong, it just works"]
        ]]]
|> printfn "%s"
```
which is evaluated to
```html
<!DOCTYPE html><html lang="de" class="test"><head/><body><img src="http://lorempixel.com/g/100/100/"/><div><strong>This is text inside the strong, it just works</strong></div></body></html>
```
