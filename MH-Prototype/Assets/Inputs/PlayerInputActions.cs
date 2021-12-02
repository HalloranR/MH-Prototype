// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""3de02a95-250f-4821-a6f9-74d6be3f9473"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1b479800-3eff-4670-b01d-2300e6e25039"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Movement"",
                    ""id"": ""4c1e3f75-6046-4cc6-b934-5fcc58e2dd1a"",
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
                    ""id"": ""31072740-72ef-48cf-8936-0dbda9b07c70"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c4f3dd56-e479-4978-a28d-ec0be1eee8c6"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""020951ad-e059-4cc0-8c88-a8e713b78c86"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""41d299a4-c35a-4b7f-9eb3-f4c6078539ec"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Movement"",
                    ""id"": ""e41126c1-ecdb-4409-be2e-698969d779e8"",
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
                    ""id"": ""b7888a43-5b73-4281-8760-391d36f30305"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5575b5c0-5f13-447c-a254-37771102d506"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""48a5705e-023f-4b9e-8530-e919cd88651b"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2489ea11-b475-4cd8-9933-f0b98753d31e"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Fire"",
            ""id"": ""00f66c0b-2e55-44e3-80da-339f937a2738"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""01b9b678-5217-4a75-a7b3-582e39cd0835"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""06ba7bea-5165-45dc-a884-271be177e377"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7a193a7-0117-45a1-a651-a726b4fa9ad5"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""A"",
            ""id"": ""d72203fe-29d2-466f-9a0c-1c1631759228"",
            ""actions"": [
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""9abec9e8-a385-4c54-bb49-81a497e0c1b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""04d6580c-366f-4e24-8b0b-8495227f676a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0f68410-eae9-496b-b077-daf239620703"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""B"",
            ""id"": ""eb015a31-9ed3-4a37-9d9a-50f57e278862"",
            ""actions"": [
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""10bb732a-a6e6-42e3-87b5-052261d57b9b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5fb0b0cd-f11a-40d3-b0ba-1dc635261bfe"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79e6f1f4-892e-4cea-ba87-06c028ebf91f"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Move = m_Movement.FindAction("Move", throwIfNotFound: true);
        // Fire
        m_Fire = asset.FindActionMap("Fire", throwIfNotFound: true);
        m_Fire_Fire = m_Fire.FindAction("Fire", throwIfNotFound: true);
        // A
        m_A = asset.FindActionMap("A", throwIfNotFound: true);
        m_A_A = m_A.FindAction("A", throwIfNotFound: true);
        // B
        m_B = asset.FindActionMap("B", throwIfNotFound: true);
        m_B_B = m_B.FindAction("B", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Move;
    public struct MovementActions
    {
        private @PlayerInputActions m_Wrapper;
        public MovementActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Movement_Move;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Fire
    private readonly InputActionMap m_Fire;
    private IFireActions m_FireActionsCallbackInterface;
    private readonly InputAction m_Fire_Fire;
    public struct FireActions
    {
        private @PlayerInputActions m_Wrapper;
        public FireActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire => m_Wrapper.m_Fire_Fire;
        public InputActionMap Get() { return m_Wrapper.m_Fire; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FireActions set) { return set.Get(); }
        public void SetCallbacks(IFireActions instance)
        {
            if (m_Wrapper.m_FireActionsCallbackInterface != null)
            {
                @Fire.started -= m_Wrapper.m_FireActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_FireActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_FireActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_FireActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public FireActions @Fire => new FireActions(this);

    // A
    private readonly InputActionMap m_A;
    private IAActions m_AActionsCallbackInterface;
    private readonly InputAction m_A_A;
    public struct AActions
    {
        private @PlayerInputActions m_Wrapper;
        public AActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @A => m_Wrapper.m_A_A;
        public InputActionMap Get() { return m_Wrapper.m_A; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AActions set) { return set.Get(); }
        public void SetCallbacks(IAActions instance)
        {
            if (m_Wrapper.m_AActionsCallbackInterface != null)
            {
                @A.started -= m_Wrapper.m_AActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_AActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_AActionsCallbackInterface.OnA;
            }
            m_Wrapper.m_AActionsCallbackInterface = instance;
            if (instance != null)
            {
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
            }
        }
    }
    public AActions @A => new AActions(this);

    // B
    private readonly InputActionMap m_B;
    private IBActions m_BActionsCallbackInterface;
    private readonly InputAction m_B_B;
    public struct BActions
    {
        private @PlayerInputActions m_Wrapper;
        public BActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @B => m_Wrapper.m_B_B;
        public InputActionMap Get() { return m_Wrapper.m_B; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BActions set) { return set.Get(); }
        public void SetCallbacks(IBActions instance)
        {
            if (m_Wrapper.m_BActionsCallbackInterface != null)
            {
                @B.started -= m_Wrapper.m_BActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_BActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_BActionsCallbackInterface.OnB;
            }
            m_Wrapper.m_BActionsCallbackInterface = instance;
            if (instance != null)
            {
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
            }
        }
    }
    public BActions @B => new BActions(this);
    public interface IMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IFireActions
    {
        void OnFire(InputAction.CallbackContext context);
    }
    public interface IAActions
    {
        void OnA(InputAction.CallbackContext context);
    }
    public interface IBActions
    {
        void OnB(InputAction.CallbackContext context);
    }
}
