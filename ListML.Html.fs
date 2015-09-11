namespace ListML

module HTML =

  open ListML.Core

  ///Defines a doctype
  let doctype = "<!DOCTYPE html>"
  ///Defines a hyperlink
  let a = node "a"
  ///Defines an abbreviation or an acronym
  let abbr = node "abbr"
  ///Defines contact information for the author/owner of a document
  let address = node "address"
  ///Defines an area inside an image-map
  let area = node "area"
  ///Defines an article
  let article = node "article"
  ///Defines content aside from the page content
  let aside = node "aside"
  ///Defines sound content
  let audio = node "audio"
  ///Defines bold text
  let b = node "b"
  ///Specifies the base URL/target for all relative URLs in a document
  let basenode = node "base"
  ///Isolates a part of text that might be formatted in a different direction from other text outside it
  let bdi = node "bdi"
  ///Overrides the current text direction
  let bdo = node "bdo"
  ///Defines a section that is quoted from another source
  let blockquote = node "blockquote"
  ///Defines the document's body
  let body = node "body"
  ///Defines a single line break
  let br attributes = node "br" attributes []
  ///Defines a clickable button
  let button = node "button"
  ///Used to draw graphics, on the fly, via scripting (usually JavaScript)
  let canvas = node "canvas"
  ///Defines a table caption
  let caption = node "caption"
  ///Defines the title of a work
  let cite = node "cite"
  ///Defines a piece of computer code
  let code = node "code"
  ///Specifies column properties for each column within a <colgroup> element
  let col = node "col"
  ///Specifies a group of one or more columns in a table for formatting
  let colgroup = node "colgroup"
  ///Specifies a list of pre-defined options for input controls
  let datalist = node "datalist"
  ///Defines a description/value of a term in a description list
  let dd = node "dd"
  ///Defines text that has been deleted from a document
  let del = node "del"
  ///Defines additional details that the user can view or hide
  let details = node "details"
  ///Represents the defining instance of a term
  let dfn = node "dfn"
  ///Defines a dialog box or window
  let dialog = node "dialog"
  ///Defines a section in a document
  let div = node "div"
  ///Defines a description list
  let dl = node "dl"
  ///Defines a term/name in a description list
  let dt = node "dt"
  ///Defines emphasized text
  let em = node "em"
  ///Defines a container for an external (non-HTML) application
  let embed = node "embed"
  ///Groups related elements in a form
  let fieldset = node "fieldset"
  ///Defines a caption for a let figure = node "figure" element
  let figcaption = node "figcaption"
  ///Specifies self-contained content
  let figure = node "figure"
  ///Defines a footer for a document or section
  let footer = node "footer"
  ///Defines an HTML form for user input
  let form = node "form"
  ///Defines HTML headings
  let h1 = node "h1"
  ///Defines HTML headings
  let h2 = node "h2"
  ///Defines HTML headings
  let h3 = node "h3"
  ///Defines HTML headings
  let h4 = node "h4"
  ///Defines HTML headings
  let h5 = node "h5"
  ///Defines HTML headings
  let h6 = node "h6"
  ///Defines information about the document
  let head = node "head"
  ///Defines a header for a document or section
  let header = node "header"
  ///Defines a thematic change in the content
  let hr = node "hr"
  ///Defines the root of an HTML document
  let html = node "html"
  ///Defines a part of text in an alternate voice or mood
  let i = node "i"
  ///Defines an inline frame
  let iframe = node "iframe"
  ///Defines an image
  let img attributes = node "img" attributes []
  ///Defines an input control
  let input = node "input"
  ///Defines a text that has been inserted into a document
  let ins = node "ins"
  ///Defines keyboard input
  let kbd = node "kbd"
  ///Defines a key-pair generator field (for forms)
  let keygen = node "keygen"
  ///Defines a label for an let input = node "input" element
  let label = node "label"
  ///Defines a caption for a let fieldset = node "fieldset" element
  let legend = node "legend"
  ///Defines a list item
  let li = node "li"
  ///Defines the relationship between a document and an external resource (most used to link to style sheets)
  let link = node "link"
  ///Specifies the main content of a document
  let main = node "main"
  ///Defines a client-side image-map
  let map = node "map"
  ///Defines marked/highlighted text
  let mark = node "mark"
  ///Defines a list/menu of commands
  let menu = node "menu"
  ///Defines a command/menu item that the user can invoke from a popup menu
  let menuitem = node "menuitem"
  ///Defines metadata about an HTML document
  let meta attributes = node "meta" attributes []
  ///Defines a scalar measurement within a known range (a gauge)
  let meter = node "meter"
  ///Defines navigation links
  let nav = node "nav"
  ///Defines an alternate content for users that do not support client-side scripts
  let noscript = node "noscript"
  ///Defines an embedded object
  let objectnode = node "object"
  ///Defines an ordered list
  let ol = node "ol"
  ///Defines a group of related options in a drop-down list
  let optgroup = node "optgroup"
  ///Defines an option in a drop-down list
  let option = node "option"
  ///Defines the result of a calculation
  let output = node "output"
  ///Defines a paragraph
  let p = node "p"
  ///Defines a parameter for an object
  let param = node "param"
  ///Defines preformatted text
  let pre = node "pre"
  ///Represents the progress of a task
  let progress = node "progress"
  ///Defines a short quotation
  let q = node "q"
  ///Defines what to show in browsers that do not support ruby annotations
  let rp = node "rp"
  ///Defines an explanation/pronunciation of characters (for East Asian typography)
  let rt = node "rt"
  ///Defines a ruby annotation (for East Asian typography)
  let ruby = node "ruby"
  ///Defines text that is no longer correct
  let s = node "s"
  ///Defines sample output from a computer program
  let samp = node "samp"
  ///Defines a client-side script
  let script = node "script"
  ///Defines a section in a document
  let section = node "section"
  ///Defines a drop-down list
  let select = node "select"
  ///Defines smaller text
  let small = node "small"
  ///Defines multiple media resources for media elements (<video> and <audio>)
  let source = node "source"
  ///Defines a section in a document
  let span = node "span"
  ///Defines strikethrough text
  ///Not supported in HTML5. Use <del> or <s> instead.
  let strike = node "strike"
  ///Defines important text
  let strong = node "strong"
  ///Defines style information for a document
  let style = node "style"
  ///Defines subscripted text
  let sub = node "sub"
  ///Defines a visible heading for a let details = node "details" element
  let summary = node "summary"
  ///Defines superscripted text
  let sup = node "sup"
  ///Defines a table
  let table = node "table"
  ///Groups the body content in a table
  let tbody = node "tbody"
  ///Defines a cell in a table
  let td = node "td"
  ///Defines a multiline input control (text area)
  let textarea = node "textarea"
  ///Groups the footer content in a table
  let tfoot = node "tfoot"
  ///Defines a header cell in a table
  let th = node "th"
  ///Groups the header content in a table
  let thead = node "thead"
  ///Defines a date/time
  let time = node "time"
  ///Defines a title for the document
  let title = node "title"
  ///Defines a row in a table
  let tr = node "tr"
  ///Defines text tracks for media elements (let video = node "video" and let audio = node "audio")
  let track = node "track"
  ///Defines text that should be stylistically different from normal text
  let u = node "u"
  ///Defines an unordered list
  let ul = node "ul"
  ///Defines a variable
  let var = node "var"
  ///Defines a video or movie
  let video = node "video"
  ///Defines a possible line-break
  let wbr = node "wbr"
