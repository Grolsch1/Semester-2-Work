using UnityEngine;
using UnityEngine.InputSystem;
public class FPController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;
    public float gravity = -9.81f;


    [Header("Look Settings")]
    public Transform cameraTransform;
    public float lookSensitivity = 2f; //mouse sensitivity for looking around
    public float verticalLookLimit = 90f;  //mouse sensitivity for vertical look
    private CharacterController controller; //character controller component on player
    private Vector2 moveInput; //input for movement
    private Vector2 lookInput; //input for looking around
    private Vector3 velocity; //velocity for gravity and movement
    private float verticalRotation = 0f; //vertical rotation for camera
    private void Awake() // Initialize the character controller and lock the cursor
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked; //stops the cursor from moving around and leaving the game window
        Cursor.visible = false;
    }
    private void Update()
    {
        HandleMovement();
        HandleLook();
    }
    public void OnMovement(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>(); //returns and x/y value depending on what player pressed
    }
    public void OnLook(InputAction.CallbackContext context)
    {
        lookInput = context.ReadValue<Vector2>();
    }
    public void HandleMovement()
    {
        Vector3 move = transform.right * moveInput.x + transform.forward *
        moveInput.y;
        controller.Move(move * moveSpeed * Time.deltaTime);
        if (controller.isGrounded && velocity.y < 0)
            velocity.y = -2f;
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
    public void HandleLook()
    {
        float mouseX = lookInput.x * lookSensitivity;
        float mouseY = lookInput.y * lookSensitivity;
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -verticalLookLimit,
        verticalLookLimit);
        cameraTransform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }
}