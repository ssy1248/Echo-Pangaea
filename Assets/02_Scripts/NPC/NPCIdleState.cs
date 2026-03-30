using UnityEngine;

public class NPCIdleState : NPCState
{
    public NPCIdleState(NonPlayerCharacter nPc, NPCStateMachine stateMachine) : base(nPc, stateMachine) { }

    public override void Enter()
    {
        base.Enter();
        // Debug.Log($"{nPc.name}: Idle State Enter");
    }

    public override void Update()
    {
        base.Update();
        // Logic for idle behavior or transitions
    }

    public override void Exit()
    {
        base.Exit();
        // Debug.Log($"{nPc.name}: Idle State Exit");
    }
}
