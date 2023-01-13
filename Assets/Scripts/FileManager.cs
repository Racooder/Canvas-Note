using UnityEngine;

public class FileManager : MonoBehaviour
{
    [SerializeField]
    private GameObject rightClickMenu;
    private RectTransform rcmTransform;

    private MainInputActions mainInputActions;
    private Vector2 cursorPosition;
    private bool rcmEnabled;

    private void Start()
    {
        rcmTransform = rightClickMenu.GetComponent<RectTransform>();

        mainInputActions = new MainInputActions();
        mainInputActions.UI.Enable();
    }

    public void showRightClickMenu()
    {
        rcmEnabled = true;
        rightClickMenu.SetActive(true);
        cursorPosition = mainInputActions.UI.CursorPos.ReadValue<Vector2>();
        rcmTransform.position = new Vector3(cursorPosition.x, cursorPosition.y, 0);
    }

    public void hideRightClickMenu()
    {
        if (!rcmEnabled) return;
        rightClickMenu.SetActive(false);
    }
}
