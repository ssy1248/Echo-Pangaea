using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerMover : MonoBehaviour
{
    private Player _player;

    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 5f;

    // Start 대신 Init을 사용하여 초기화 시점을 Player가 통제하게 함
    public void Init(Player player)
    {
        _player = player;
    }

    // Update 대신 Player에서 명시적으로 호출하는 함수
    public void HandleMovement()
    {
        // 실제 이동 로직 구현 (Input System 연동 등)
    }
}
