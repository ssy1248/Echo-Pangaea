using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [Header("Modules")]
    [SerializeField] private PlayerMover _playerMover;
    
    [Header("Input Settings")]
    [SerializeField] private PlayerInput _playerInput;

    private InputAction _moveAction;
    private InputAction _jumpAction;

    private void Awake()
    {
        _playerMover.Init(this);

        if (_playerInput != null)
        {
            _moveAction = _playerInput.actions["Move"];
            _jumpAction = _playerInput.actions["Jump"];
        }
    }

    private void Update()
    {
        if (CanMove())
        {
            Vector2 moveInput = _moveAction != null ? _moveAction.ReadValue<Vector2>() : Vector2.zero;
            _playerMover.HandleMovement(moveInput);

            if (_jumpAction != null && _jumpAction.WasPressedThisFrame())
            {
                _playerMover.HandleJump();
            }
        }
    }

    private bool CanMove()
    {
        return true;
    }
}
