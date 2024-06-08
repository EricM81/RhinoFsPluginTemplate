namespace FSharpRhinoPlayground

open System.Reflection
open System.Runtime.CompilerServices
open System.Runtime.InteropServices
open Rhino.PlugIns
open Microsoft.FSharp.Core

module IDs =
    [<Literal>]
    let Assembly = "008fa96d-c827-4dab-bc9f-4013556c5d23"
    [<Literal>]
    let Plugin = "0c6cf0b2-131c-43a0-ad27-05c7005eb30f"

    [<Literal>]
    let Cmd1 = "3439269b-f328-4462-a360-43cc4b3469d2"
    
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[<assembly: AssemblyTitle("FSharpRhinoPlayground")>]
[<assembly: AssemblyDescription("")>]
[<assembly: AssemblyConfiguration("")>]
[<assembly: AssemblyCompany("")>]
[<assembly: AssemblyProduct("FSharpRhinoPlayground")>]
[<assembly: AssemblyCopyright("Copyright ©  $year$")>]
[<assembly: AssemblyTrademark("")>]
[<assembly: AssemblyCulture("")>]

[<assembly: PlugInDescription(DescriptionType.Address, "")>]
[<assembly: PlugInDescription(DescriptionType.Country, "")>]
[<assembly: PlugInDescription(DescriptionType.Email, "")>]
[<assembly: PlugInDescription(DescriptionType.Phone, "")>]
[<assembly: PlugInDescription(DescriptionType.Fax, "")>]
[<assembly: PlugInDescription(DescriptionType.Organization, "")>]
[<assembly: PlugInDescription(DescriptionType.UpdateUrl, "")>]
[<assembly: PlugInDescription(DescriptionType.WebSite, "")>]
// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[<assembly: ComVisible(false)>]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[<assembly: Guid(IDs.Plugin)>]

// Version information for an assembly consists of the following four values:
// 
//       Major Version
//       Minor Version 
//       Build Number
//       Revision
// 
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [<assembly: AssemblyVersion("1.0.*")>]
[<assembly: AssemblyVersion("1.0.*")>]
[<assembly: AssemblyFileVersion("1.0.*")>]
[<assembly: PlugInDescription(DescriptionType.Icon, "EmbeddedResources.plugin-utility.ico")>]

do
    ()
