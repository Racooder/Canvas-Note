using Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Settings
    public float movementSpeed = 7f;
    public float fastMovementMultiplier = 2f;
    public float scrollSpeed = 5f;
    public bool multiplyScrollSpeed = true;
    public float rotationSpeed = 800f;
    public float dragSpeed = 5f;
    public bool multiplyDragSpeed = false;

    // References
    [SerializeField]
    private Transform cameraTransform;
    [SerializeField]
    private CinemachineVirtualCamera virtualCamera;
    [SerializeField]
    private Texture2D eyeCursor;

    // Private Vars
    private MainInputActions mainInputActions;
    private Vector2 movement;
    private float verticalMovement;
    private float movementMultiplier = 1;
    private CinemachinePOV cinemachinePOV;
    private float scroll;
    private bool drag = false;
    private Vector2 mouseDelta;

    private void Start()
    {
        cinemachinePOV = virtualCamera.GetCinemachineComponent<CinemachinePOV>();

        mainInputActions = new MainInputActions();
        mainInputActions.Camera.RightClick.started += RightClick_started;
        mainInputActions.Camera.RightClick.canceled += RightClick_canceled;
        mainInputActions.Camera.Shift.started += Shift_started;
        mainInputActions.Camera.Shift.canceled += Shift_canceled;
        mainInputActions.Camera.Scroll.performed += Scroll_performed;
        mainInputActions.Camera.MidClick.started += MidClick_started;
        mainInputActions.Camera.MidClick.canceled += MidClick_canceled;
        mainInputActions.Camera.MouseMovement.performed += MouseMovement_performed;
        mainInputActions.Enable();
    }

    private void Update()
    {
        movement = mainInputActions.Camera.Movement.ReadValue<Vector2>();
        verticalMovement = mainInputActions.Camera.VerticalMovement.ReadValue<float>();

        gameObject.transform.Translate(movementMultiplier * movementSpeed * Time.deltaTime * (cameraTransform.forward * movement.y + cameraTransform.up * verticalMovement + cameraTransform.right * movement.x));
    }

    private void MouseMovement_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        if (!drag) return;

        mouseDelta = obj.ReadValue<Vector2>();
        gameObject.transform.Translate((multiplyDragSpeed ? movementMultiplier : 1) * dragSpeed * (-1 * mouseDelta.y * cameraTransform.up + -1 * mouseDelta.x * cameraTransform.right));
    }

    private void MidClick_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        drag = true;
        stopPOV();
    }

    private void MidClick_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        drag = false;
    }

    private void Scroll_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        scroll = obj.ReadValue<float>();
        if (scroll > 0)
            scroll = 1;
        else if (scroll < 0)
            scroll = -1;
        gameObject.transform.Translate((multiplyScrollSpeed ? movementMultiplier : 1) * scroll * scrollSpeed * cameraTransform.forward);
    }

    private void RightClick_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        if (drag) return;

        cinemachinePOV.m_VerticalAxis.m_MaxSpeed = rotationSpeed;
        cinemachinePOV.m_HorizontalAxis.m_MaxSpeed = rotationSpeed;
        Cursor.SetCursor(eyeCursor, Vector2.zero, CursorMode.Auto);
    }

    private void RightClick_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        stopPOV();
    }

    private void stopPOV()
    {
        cinemachinePOV.m_VerticalAxis.m_MaxSpeed = 0;
        cinemachinePOV.m_HorizontalAxis.m_MaxSpeed = 0;
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    private void Shift_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        movementMultiplier = fastMovementMultiplier;
    }

    private void Shift_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        movementMultiplier = 1;
    }
}
