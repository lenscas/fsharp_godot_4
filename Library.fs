namespace TestFSharpGodot


open MyriadgodotMyriad

[<MyriadgodotMyriad.Example>]
module Say =
    open MyriadgodotMyriad.Helper
    open Godot

    type BasicState =
        { Hello: int
          IAmInner: string }

        member this.Default() = { Hello = 0; IAmInner = "nice" }

    let _Ready (node: INodeWithState<Node, BasicState>) (state: BasicState) : BasicState =
        GD.Print("Hello from F#")
        GD.Print("my exported value is: " + (state.Hello.ToString()))
        GD.Print("And my inner value is: " + state.IAmInner)
        state

    let _Process (node: INodeWithState<Node, BasicState>) (state: BasicState) : BasicState =
        GD.Print("In process!")
        GD.Print(state.Hello.ToString())
        let newState = { state with Hello = state.Hello + 1 }
        newState
//------------------------------------------------------------------------------
//        This code was generated by myriad.
//        Changes to this file will be lost when the code is regenerated.
//------------------------------------------------------------------------------
