// GENERATED AUTOMATICALLY FROM 'Assets/Externals/Input/PlayerInputAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputAction"",
    ""maps"": [
        {
            ""name"": ""GroundMovement"",
            ""id"": ""73cc8b1a-0bd6-45cb-bf6e-cebeb7507903"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a853dd31-8608-489b-87db-1e8d7c25fdd6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""26c09868-ef99-4848-8dd5-4540825c1675"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Slide"",
                    ""type"": ""Button"",
                    ""id"": ""3356c67c-fc14-4108-9b8d-1ffb471d2ae4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dodge"",
                    ""type"": ""Button"",
                    ""id"": ""d6b5602b-8785-4248-8519-efe225fe81d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b6102ad3-3076-48d4-a6d5-6a5f5847709c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ffdc63b1-e932-4cd5-aa47-58cce44334a0"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""ae0f75aa-ac3f-4650-b42c-9f1fbe2e270f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c2c4237d-7285-47e3-98b0-54975d07cd2b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""47037679-5ab8-4f7d-9550-4dfd90c03a39"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8582f8f6-816b-47e1-80a7-7bc1cdef6b16"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0fe3f0da-fc48-4130-8538-6c00e58173a7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""dd466256-042a-4f1c-be49-935fb4b17664"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d41f19c9-a619-4244-9141-9ba5ef163cca"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d16a0051-490f-48b4-a979-8fd6d3460ffc"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""441f9f33-d469-47e6-af56-94983ee3b030"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b98bf6f6-1d2f-4236-8fbe-d6347ec6a11e"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""InGame"",
            ""id"": ""05ec6d5c-abea-43a3-bcae-f29c2c37e59a"",
            ""actions"": [
                {
                    ""name"": ""CursorControl"",
                    ""type"": ""Button"",
                    ""id"": ""f67f222f-b628-4963-b80c-ba3fef5c9c13"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""be41acb7-b187-4b1f-865f-53a4e7784451"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CursorControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""gameplayControls"",
            ""id"": ""2ee7c966-e79a-4d80-8541-0c48c6d31518"",
            ""actions"": [
                {
                    ""name"": ""slowmo"",
                    ""type"": ""Button"",
                    ""id"": ""713c0566-f282-477c-abe2-a7dfae8d301d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""shoot"",
                    ""type"": ""Value"",
                    ""id"": ""4e5cd88c-40f8-49e7-af07-9c67ef3c8c1c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""323a8aef-7863-47be-aeb7-36e78c1321a0"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""slowmo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e68c434c-9018-4fcb-becc-5d5009ec6e9e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GroundMovement
        m_GroundMovement = asset.FindActionMap("GroundMovement", throwIfNotFound: true);
        m_GroundMovement_Move = m_GroundMovement.FindAction("Move", throwIfNotFound: true);
        m_GroundMovement_Jump = m_GroundMovement.FindAction("Jump", throwIfNotFound: true);
        m_GroundMovement_Slide = m_GroundMovement.FindAction("Slide", throwIfNotFound: true);
        m_GroundMovement_Dodge = m_GroundMovement.FindAction("Dodge", throwIfNotFound: true);
        m_GroundMovement_MouseX = m_GroundMovement.FindAction("MouseX", throwIfNotFound: true);
        m_GroundMovement_MouseY = m_GroundMovement.FindAction("MouseY", throwIfNotFound: true);
        // InGame
        m_InGame = asset.FindActionMap("InGame", throwIfNotFound: true);
        m_InGame_CursorControl = m_InGame.FindAction("CursorControl", throwIfNotFound: true);
        // gameplayControls
        m_gameplayControls = asset.FindActionMap("gameplayControls", throwIfNotFound: true);
        m_gameplayControls_slowmo = m_gameplayControls.FindAction("slowmo", throwIfNotFound: true);
        m_gameplayControls_shoot = m_gameplayControls.FindAction("shoot", throwIfNotFound: true);
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

    // GroundMovement
    private readonly InputActionMap m_GroundMovement;
    private IGroundMovementActions m_GroundMovementActionsCallbackInterface;
    private readonly InputAction m_GroundMovement_Move;
    private readonly InputAction m_GroundMovement_Jump;
    private readonly InputAction m_GroundMovement_Slide;
    private readonly InputAction m_GroundMovement_Dodge;
    private readonly InputAction m_GroundMovement_MouseX;
    private readonly InputAction m_GroundMovement_MouseY;
    public struct GroundMovementActions
    {
        private @PlayerInputAction m_Wrapper;
        public GroundMovementActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_GroundMovement_Move;
        public InputAction @Jump => m_Wrapper.m_GroundMovement_Jump;
        public InputAction @Slide => m_Wrapper.m_GroundMovement_Slide;
        public InputAction @Dodge => m_Wrapper.m_GroundMovement_Dodge;
        public InputAction @MouseX => m_Wrapper.m_GroundMovement_MouseX;
        public InputAction @MouseY => m_Wrapper.m_GroundMovement_MouseY;
        public InputActionMap Get() { return m_Wrapper.m_GroundMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GroundMovementActions set) { return set.Get(); }
        public void SetCallbacks(IGroundMovementActions instance)
        {
            if (m_Wrapper.m_GroundMovementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnJump;
                @Slide.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSlide;
                @Slide.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSlide;
                @Slide.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSlide;
                @Dodge.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnDodge;
                @Dodge.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnDodge;
                @Dodge.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnDodge;
                @MouseX.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseY;
            }
            m_Wrapper.m_GroundMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Slide.started += instance.OnSlide;
                @Slide.performed += instance.OnSlide;
                @Slide.canceled += instance.OnSlide;
                @Dodge.started += instance.OnDodge;
                @Dodge.performed += instance.OnDodge;
                @Dodge.canceled += instance.OnDodge;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
            }
        }
    }
    public GroundMovementActions @GroundMovement => new GroundMovementActions(this);

    // InGame
    private readonly InputActionMap m_InGame;
    private IInGameActions m_InGameActionsCallbackInterface;
    private readonly InputAction m_InGame_CursorControl;
    public struct InGameActions
    {
        private @PlayerInputAction m_Wrapper;
        public InGameActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @CursorControl => m_Wrapper.m_InGame_CursorControl;
        public InputActionMap Get() { return m_Wrapper.m_InGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameActions set) { return set.Get(); }
        public void SetCallbacks(IInGameActions instance)
        {
            if (m_Wrapper.m_InGameActionsCallbackInterface != null)
            {
                @CursorControl.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnCursorControl;
                @CursorControl.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnCursorControl;
                @CursorControl.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnCursorControl;
            }
            m_Wrapper.m_InGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CursorControl.started += instance.OnCursorControl;
                @CursorControl.performed += instance.OnCursorControl;
                @CursorControl.canceled += instance.OnCursorControl;
            }
        }
    }
    public InGameActions @InGame => new InGameActions(this);

    // gameplayControls
    private readonly InputActionMap m_gameplayControls;
    private IGameplayControlsActions m_GameplayControlsActionsCallbackInterface;
    private readonly InputAction m_gameplayControls_slowmo;
    private readonly InputAction m_gameplayControls_shoot;
    public struct GameplayControlsActions
    {
        private @PlayerInputAction m_Wrapper;
        public GameplayControlsActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @slowmo => m_Wrapper.m_gameplayControls_slowmo;
        public InputAction @shoot => m_Wrapper.m_gameplayControls_shoot;
        public InputActionMap Get() { return m_Wrapper.m_gameplayControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayControlsActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayControlsActions instance)
        {
            if (m_Wrapper.m_GameplayControlsActionsCallbackInterface != null)
            {
                @slowmo.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnSlowmo;
                @slowmo.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnSlowmo;
                @slowmo.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnSlowmo;
                @shoot.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnShoot;
                @shoot.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnShoot;
                @shoot.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_GameplayControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @slowmo.started += instance.OnSlowmo;
                @slowmo.performed += instance.OnSlowmo;
                @slowmo.canceled += instance.OnSlowmo;
                @shoot.started += instance.OnShoot;
                @shoot.performed += instance.OnShoot;
                @shoot.canceled += instance.OnShoot;
            }
        }
    }
    public GameplayControlsActions @gameplayControls => new GameplayControlsActions(this);
    public interface IGroundMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSlide(InputAction.CallbackContext context);
        void OnDodge(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
    }
    public interface IInGameActions
    {
        void OnCursorControl(InputAction.CallbackContext context);
    }
    public interface IGameplayControlsActions
    {
        void OnSlowmo(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
}
