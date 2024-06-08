namespace FSharpRhinoPlayground

open Rhino
open Rhino.PlugIns
open Rhino.Commands
open Rhino.DocObjects
open Rhino.Geometry

[<AllowNullLiteral>]
[<System.Runtime.InteropServices.Guid(IDs.Cmd1)>]
type Cmd1 () as this = 
    inherit Command()
   
    static let mutable instance: Command = null
    
    do 
        instance <- this :> Command
        
    let SetShimInstance(shim: Command) = 
        instance <- shim
    override this.EnglishName = "Cmd1"  
    
    //override this.ReplayHistory (e: ReplayHistoryData) =
        
        
    override this.RunCommand (doc, _): Result =
        RhinoApp.WriteLine("Hello World!")
        Result.Success
        
