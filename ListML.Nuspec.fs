namespace ListML

module Nuspec =

  open Core

  let package = node "package" [attr "xmlns" "http://schemas.microsoft.com/packaging/2010/07/nuspec.xsd"]
  let metadata = node "metadata" []
  let id = node "id" []
  let version = node "version" []
  let authors = node "authors" []
  let description = node "description" []
  let language = node "language" []
  let projectUrl = node "projectUrl" []
  let licenseUrl = node "licenseUrl" []
  let copyright = node "copyright" []
  let files = node "files" []
  let file = node "file"
  let summary = node "summary" []
  let title = node "title" []
