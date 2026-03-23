using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Modules")]
    [SerializeField] private PlayerMover _playerMover;

    private void Awake()
    {
        // 각 모듈들이 스스로 초기화하지 않고, 최상위 Player가 초기화를 지시함
        _playerMover.Init(this);
    }

    private void Update()
    {
        // 최상위에서 상태를 판단하고, 이동이 가능할 때만 Mover를 작동시킴
        if (CanMove())
        {
            _playerMover.HandleMovement();
        }
    }

    private bool CanMove()
    {
       
        return true;
    }
}
