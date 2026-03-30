using UnityEngine;

public class NonPlayerCharacter : MonoBehaviour
{
    public NPCStateMachine StateMachine { get; private set; }

    #region State Instances
    public NPCIdleState IdleState { get; private set; }
    // Add more states here as needed, e.g., PatrolState, CombatState
    #endregion

    protected virtual void Awake()
    {
        StateMachine = new NPCStateMachine();

        // Initialize States
        IdleState = new NPCIdleState(this, StateMachine);
    }

    protected virtual void Start()
    {
        // Set initial state
        StateMachine.Initialize(IdleState);
    }

    protected virtual void Update()
    {
        StateMachine.CurrentState?.Update();
    }

    protected virtual void FixedUpdate()
    {
        StateMachine.CurrentState?.FixedUpdate();
    }

    // Helper method to change state if needed from external sources or common logic
    public void ChangeState(NPCState newState)
    {
        StateMachine.ChangeState(newState);
    }
}
