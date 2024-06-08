namespace FSharpRhinoPlayground

open Rhino.PlugIns

[<AllowNullLiteral>]
[<System.Runtime.InteropServices.Guid(IDs.Plugin)>]
type PluginFs() as this = 
    inherit PlugIn()
    static let mutable instance = null

    do  
        instance <- this

    static member val Instance = instance   

    override this.LoadTime = PlugInLoadTime.AtStartup
    
