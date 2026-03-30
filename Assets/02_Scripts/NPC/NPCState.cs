using UnityEngine;

public abstract class NPCState
{
    protected NonPlayerCharacter nPc;
    protected NPCStateMachine stateMachine;

    public NPCState(NonPlayerCharacter nPc, NPCStateMachine stateMachine)
    {
        this.nPc = nPc;
        this.stateMachine = stateMachine;
    }

    public virtual void Enter() { }
    public virtual void Update() { }
    public virtual void FixedUpdate() { }
    public virtual void Exit() { }
}
