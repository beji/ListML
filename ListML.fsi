namespace ListML

module Core =
  /// A Basic record contaning a key and a value
  /// Mainly used as a basic implementation of the tag attributes
  type KeyValue = {key: string; value: string}

  /// Creates a new KeyValue record with the given parameters
  val attr : key:string -> value:string -> KeyValue

  /// Renders the given node element into its XML representation
  /// A nested XML-Tree can easily be handeled by nesting calls of the node function
  /// Text inside the element can be handled by passing a simple String as one of the children
  /// Example:
  /// node "html" [attr "lang" "en"] [
  ///   node "head" [] []
  ///   node "body" [] ["I am a simple Text"]]
  ///
  /// Which results in <html lang="en"><head></head><body></body></html>
  /// Helper functions to shorten the typing for HTML-Code can be found in the
  /// ListMl.HTML module
  val node : tag:string -> attributes:KeyValue list -> children: string list -> string
