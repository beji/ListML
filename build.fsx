#I "./packages/FAKE/tools/"
#r "FakeLib.dll"
#load "ListML.fs"
#load "ListML.Nuspec.fs"

open Fake
open Fake.AssemblyInfoFile
open System.IO
open ListML.Core
open ListML.Nuspec

let title ="ListML"
let desc = "ListML is a collection of rather basic functions to generate a string representation of a XML-tree. It is inspired (but not nearly as elegant as) the X-Expressions used in Racket. The ListML.HTML module contains functions to ease the creation of a HTML-Tree and serves as an implementation example"
let versionString = "1.1.1.0"
let author = "Björn Erlwein"


Target "Clean" (fun _ ->
    CleanDir "bin/Release")

Target "AssemblyInfo" (fun _ ->
  CreateFSharpAssemblyInfo "./AssemblyInfo.fs"
    [Attribute.Title title
     Attribute.Description desc
     Attribute.Version versionString])

Target "BuildRelease" (fun _ ->

    ["./ListML.fsproj"]
    |> MSBuildRelease "bin/Release" "Build"
    |> Log "AppBuild-Output: ")

Target "Nuspec" (fun _ ->

  let nuspecfile =
    "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
    package [
      metadata [
        id [title]
        ListML.Nuspec.title [title]
        version [versionString]
        authors [author]
        description [desc]
        summary [desc]
        language ["en-US"]
        projectUrl ["https://github.com/beji/ListML"]
        licenseUrl ["https://github.com/beji/ListML/blob/master/LICENSE"]
        copyright ["Copyright 2015-2016"]]
      files [
        file [attr "src" "bin/Release/ListML.dll"; attr "target" "lib"] []]]
  File.WriteAllText((title + ".nuspec"), nuspecfile)
  )

"Clean"
==> "AssemblyInfo"
==> "BuildRelease"
==> "Nuspec"

RunTargetOrDefault "Nuspec"
