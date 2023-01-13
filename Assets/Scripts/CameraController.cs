using Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float movementSpeed = 7f;
    public float fastMovementMultiplier = 2f;
    public float rotationSpeed = 800f;

    [SerializeField]
    private Transform cameraTransform;
    [SerializeField]
    private CinemachineVirtualCamera virtualCamera;
    [SerializeField]
    private Texture2D eyeCursor;

    private MainInputActions mainInputActions;
    private Vector2 movement;
    private float verticalMovement;
    private float movementMultiplier = 1;
    private CinemachinePOV cinemachinePOV;

    // Start is called before the first frame update
    void Start()
    {
        cinemachinePOV = virtualCamera.GetCinemachineComponent<CinemachinePOV>();

        mainInputActions = new MainInputActions();
        mainInputActions.Camera.RightClick.started += RightClick_started;
        mainInputActions.Camera.RightClick.canceled += RightClick_canceled;
        mainInputActions.Camera.Shift.started += Shift_started;
        mainInputActions.Camera.Shift.canceled += Shift_canceled;
        mainInputActions.Enable();
    }

    private void RightClick_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        cinemachinePOV.m_VerticalAxis.m_MaxSpeed = rotationSpeed;
        cinemachinePOV.m_HorizontalAxis.m_MaxSpeed = rotationSpeed;
        Cursor.SetCursor(eyeCursor, Vector2.zero, CursorMode.Auto);
    }

    private void RightClick_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
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

    // Update is called once per frame
    void Update()
    {
        movement = mainInputActions.Camera.Movement.ReadValue<Vector2>();
        verticalMovement = mainInputActions.Camera.VerticalMovement.ReadValue<float>();

        gameObject.transform.Translate((cameraTransform.forward * movement.y + cameraTransform.up * verticalMovement + cameraTransform.right * movement.x) * Time.deltaTime * movementSpeed * movementMultiplier);
    }
}
