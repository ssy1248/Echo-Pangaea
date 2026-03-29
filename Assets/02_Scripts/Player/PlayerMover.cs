using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMover : MonoBehaviour
{
    private Player _player;
    private CharacterController _controller;

    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float rotationSpeed = 10f;
    [SerializeField] private float jumpHeight = 1.2f;
    [SerializeField] private float gravity = -9.81f;

    private Vector3 _velocity;
    private bool _isGrounded;

    public void Init(Player player)
    {
        _player = player;
        _controller = GetComponent<CharacterController>();
    }

    public void HandleMovement(Vector2 input)
    {
        _isGrounded = _controller.isGrounded;
        if (_isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }

        // 입력값을 정규화하여 대각선 이동 속도 뻥튀기 방지
        Vector3 moveInput = new Vector3(input.x, 0, input.y).normalized;

        if (moveInput.magnitude >= 0.1f)
        {
            // 메인 카메라의 Y축 회전값을 가져와서 캐릭터가 바라봐야 할 최종 각도(Target Angle) 계산
            float targetAngle = Mathf.Atan2(moveInput.x, moveInput.z) * Mathf.Rad2Deg + Camera.main.transform.eulerAngles.y;

            // 캐릭터를 부드럽게 해당 각도로 회전
            float angle = Mathf.LerpAngle(transform.eulerAngles.y, targetAngle, rotationSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, angle, 0);

            // 회전한 각도를 바탕으로 실제 이동할 앞(Forward) 방향 벡터를 계산하여 이동
            Vector3 moveDirection = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
            _controller.Move(moveDirection * moveSpeed * Time.deltaTime);
        }

        _velocity.y += gravity * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime);
    }

    public void HandleJump()
    {
        if (_isGrounded)
        {
            _velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }
}
