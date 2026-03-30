using UnityEngine;

public class NPCStateMachine
{
    public NPCState CurrentState { get; private set; }

    public void Initialize(NPCState initialState)
    {
        CurrentState = initialState;
        CurrentState.Enter();
    }

    public void ChangeState(NPCState newState)
    {
        CurrentState.Exit();
        CurrentState = newState;
        CurrentState.Enter();
    }
}
