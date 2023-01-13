//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/InputActions/MainInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @MainInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainInputActions"",
    ""maps"": [
        {
            ""name"": ""Camera"",
            ""id"": ""91a76a2a-3608-43c4-b67f-8df51eda4f2d"",
            ""actions"": [
                {
                    ""name"": ""Scroll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""45d2b04e-a0d0-4644-bfc2-5b65c3a4e991"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""c5ae23af-bc1a-4d7d-9166-53e9c771bfdf"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Vertical Movement"",
                    ""type"": ""Value"",
                    ""id"": ""e7c01393-12af-4e3e-9526-c6846a40af3f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shift"",
                    ""type"": ""Button"",
                    ""id"": ""e91ad0a0-2cdc-4eaf-9c9f-2a4dd7187fe9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MidClick"",
                    ""type"": ""Button"",
                    ""id"": ""ee915187-df4a-451c-bbef-40e2c31466ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Mouse Movement"",
                    ""type"": ""Value"",
                    ""id"": ""3b0d4a7e-a9f7-4c19-8136-86fdf379587d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Right Click"",
                    ""type"": ""Button"",
                    ""id"": ""179459f8-176e-410d-9e9a-c3731a68e52b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4e683652-4d1f-4eb5-8954-287c8a05c615"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""70ce7a12-2f93-49d5-98e6-40a2517acc0f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""93cca0c7-5e83-42fb-96ea-597c86da5cc5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e1f9df83-78a3-41d1-8094-caed61023c77"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b1a802f1-0a22-4f78-818c-a60a8d42aaca"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4ae7d260-8223-472e-9dbd-18e4cf8b1d10"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""655b82ca-37bb-471f-a898-b78696959b77"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d5c736b6-9767-4f31-8b9c-f38b795239a0"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""020f070c-d587-4e65-a85c-1d36228ffa03"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bdce6416-c8c9-4672-a53c-ca2457287de6"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2bbb3987-e455-4eba-bc5a-907683244d8c"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MidClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d40f90f-e820-41b5-b2ac-22e48fd07d7d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14709f04-1039-4c5a-a77c-4886dad63767"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""9280cadd-06d8-4352-b921-49bf6b364858"",
            ""actions"": [
                {
                    ""name"": ""Cursor Pos"",
                    ""type"": ""Value"",
                    ""id"": ""075499d0-471d-4f4b-b201-1ce1e74c1ade"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""281fae1a-9a56-49be-a3f0-382e7c1aeaf8"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cursor Pos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_Scroll = m_Camera.FindAction("Scroll", throwIfNotFound: true);
        m_Camera_Movement = m_Camera.FindAction("Movement", throwIfNotFound: true);
        m_Camera_VerticalMovement = m_Camera.FindAction("Vertical Movement", throwIfNotFound: true);
        m_Camera_Shift = m_Camera.FindAction("Shift", throwIfNotFound: true);
        m_Camera_MidClick = m_Camera.FindAction("MidClick", throwIfNotFound: true);
        m_Camera_MouseMovement = m_Camera.FindAction("Mouse Movement", throwIfNotFound: true);
        m_Camera_RightClick = m_Camera.FindAction("Right Click", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_CursorPos = m_UI.FindAction("Cursor Pos", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_Scroll;
    private readonly InputAction m_Camera_Movement;
    private readonly InputAction m_Camera_VerticalMovement;
    private readonly InputAction m_Camera_Shift;
    private readonly InputAction m_Camera_MidClick;
    private readonly InputAction m_Camera_MouseMovement;
    private readonly InputAction m_Camera_RightClick;
    public struct CameraActions
    {
        private @MainInputActions m_Wrapper;
        public CameraActions(@MainInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Scroll => m_Wrapper.m_Camera_Scroll;
        public InputAction @Movement => m_Wrapper.m_Camera_Movement;
        public InputAction @VerticalMovement => m_Wrapper.m_Camera_VerticalMovement;
        public InputAction @Shift => m_Wrapper.m_Camera_Shift;
        public InputAction @MidClick => m_Wrapper.m_Camera_MidClick;
        public InputAction @MouseMovement => m_Wrapper.m_Camera_MouseMovement;
        public InputAction @RightClick => m_Wrapper.m_Camera_RightClick;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @Scroll.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnScroll;
                @Scroll.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnScroll;
                @Scroll.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnScroll;
                @Movement.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnMovement;
                @VerticalMovement.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnVerticalMovement;
                @VerticalMovement.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnVerticalMovement;
                @VerticalMovement.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnVerticalMovement;
                @Shift.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnShift;
                @Shift.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnShift;
                @Shift.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnShift;
                @MidClick.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnMidClick;
                @MidClick.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnMidClick;
                @MidClick.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnMidClick;
                @MouseMovement.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnMouseMovement;
                @MouseMovement.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnMouseMovement;
                @MouseMovement.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnMouseMovement;
                @RightClick.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnRightClick;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Scroll.started += instance.OnScroll;
                @Scroll.performed += instance.OnScroll;
                @Scroll.canceled += instance.OnScroll;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @VerticalMovement.started += instance.OnVerticalMovement;
                @VerticalMovement.performed += instance.OnVerticalMovement;
                @VerticalMovement.canceled += instance.OnVerticalMovement;
                @Shift.started += instance.OnShift;
                @Shift.performed += instance.OnShift;
                @Shift.canceled += instance.OnShift;
                @MidClick.started += instance.OnMidClick;
                @MidClick.performed += instance.OnMidClick;
                @MidClick.canceled += instance.OnMidClick;
                @MouseMovement.started += instance.OnMouseMovement;
                @MouseMovement.performed += instance.OnMouseMovement;
                @MouseMovement.canceled += instance.OnMouseMovement;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_CursorPos;
    public struct UIActions
    {
        private @MainInputActions m_Wrapper;
        public UIActions(@MainInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @CursorPos => m_Wrapper.m_UI_CursorPos;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @CursorPos.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCursorPos;
                @CursorPos.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCursorPos;
                @CursorPos.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCursorPos;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CursorPos.started += instance.OnCursorPos;
                @CursorPos.performed += instance.OnCursorPos;
                @CursorPos.canceled += instance.OnCursorPos;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface ICameraActions
    {
        void OnScroll(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnVerticalMovement(InputAction.CallbackContext context);
        void OnShift(InputAction.CallbackContext context);
        void OnMidClick(InputAction.CallbackContext context);
        void OnMouseMovement(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnCursorPos(InputAction.CallbackContext context);
    }
}
