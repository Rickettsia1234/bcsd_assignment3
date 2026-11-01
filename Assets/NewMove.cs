using UnityEngine;
using UnityEngine.InputSystem;

public class NewMove : MonoBehaviour
{
    private PlayerInput playerInput;
    private InputAction moveAction;
    private InputAction jumpAction;
    private InputAction fireAction;
    private InputAction buyAction;
    private Vector2 moveInput;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions["Move"];
        jumpAction = playerInput.actions["Jump"];
        fireAction = playerInput.actions["Fire"];
        buyAction = playerInput.actions["Buy"];
    }

    private void OnEnable()
    {
        buyAction.started += OnBuyStarted;
        fireAction.started += OnFireStarted;
        fireAction.canceled += OnFireCanceled;
        jumpAction.started += OnJumpStarted;
        jumpAction.canceled += OnJumpCanceled;
    }

    private void OnDisable()
    {
        buyAction.started -= OnBuyStarted;
        fireAction.started -= OnFireStarted;
        fireAction.canceled -= OnFireCanceled;
        jumpAction.started -= OnJumpStarted;
        jumpAction.canceled -= OnJumpCanceled;
    }

    private void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        if (Keyboard.current.anyKey.isPressed)
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");

        moveInput = moveAction.ReadValue<Vector2>();

        if (moveInput.x < 0)
            Debug.Log("왼쪽으로 이동 중");

        if (moveAction.WasReleasedThisFrame())
            Debug.Log("이동을 멈췄습니다.");

        if (fireAction.IsPressed())
            Debug.Log("미사일 모으는 중...");

        if (jumpAction.IsPressed())
            Debug.Log("점프 모으는 중...");

        float h = moveInput.x;
        float v = moveInput.y;

        if (h != 0f)
        {
            Debug.Log("횡 이동 중..." + h);
        }

        if (v != 0f)
        {
            Debug.Log("종 이동 중..." + v);
        }

        Vector3 vec = new Vector3(h, v, 0);
        transform.Translate(vec * Time.deltaTime);
    }

    private void OnBuyStarted(InputAction.CallbackContext context)
    {
        Debug.Log("아이템을 구입했습니다.");
    }

    private void OnFireStarted(InputAction.CallbackContext context)
    {
        Debug.Log("미사일 발사!");
    }

    private void OnFireCanceled(InputAction.CallbackContext context)
    {
        Debug.Log("슈퍼 미사일 발사!!");
    }

    private void OnJumpStarted(InputAction.CallbackContext context)
    {
        Debug.Log("점프!");
    }

    private void OnJumpCanceled(InputAction.CallbackContext context)
    {
        Debug.Log("슈퍼 점프!!");
    }
}