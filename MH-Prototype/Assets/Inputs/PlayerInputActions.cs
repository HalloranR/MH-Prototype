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
                },
                {
                    ""name"": ""Pull"",
                    ""type"": ""Button"",
                    ""id"": ""9e52f995-caa9-491a-ad4c-bc8548ee4d08"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Stop"",
                    ""type"": ""Button"",
                    ""id"": ""cee41146-958d-492a-9dc0-68d3dbfc14ee"",
                    ""expectedControlType"": ""Button"",
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
                    ""path"": ""<Keyboard>/#(W)"",
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
                    ""path"": ""<Keyboard>/#(S)"",
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
                    ""path"": ""<Keyboard>/#(A)"",
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
                    ""path"": ""<Keyboard>/#(D)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""78257716-31c3-47ea-b83f-470e202e9724"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pull"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46fb75c4-6235-4e0d-a99e-b025ec236d38"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Selection"",
            ""id"": ""dba3acd6-fe09-4385-854b-136c533a3bd1"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""887d2f3a-a5c5-448f-9469-e5fbb4046849"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""307b8cd1-9890-4aa6-abe3-b959122dcc0d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""06ba7bea-5165-45dc-a884-271be177e377"",
                    ""path"": ""<Keyboard>/f"",
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
            ""name"": ""Push"",
            ""id"": ""68e08875-df00-404a-935f-60a9b46b787b"",
            ""actions"": [
                {
                    ""name"": ""Push"",
                    ""type"": ""Button"",
                    ""id"": ""eae088ca-4a07-4824-8691-e6965d516f0a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d11df718-7f45-4526-b586-9bd9e87f8919"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Push"",
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
        m_Movement_Pull = m_Movement.FindAction("Pull", throwIfNotFound: true);
        m_Movement_Stop = m_Movement.FindAction("Stop", throwIfNotFound: true);
        // Selection
        m_Selection = asset.FindActionMap("Selection", throwIfNotFound: true);
        m_Selection_Newaction = m_Selection.FindAction("New action", throwIfNotFound: true);
        // Fire
        m_Fire = asset.FindActionMap("Fire", throwIfNotFound: true);
        m_Fire_Fire = m_Fire.FindAction("Fire", throwIfNotFound: true);
        // Push
        m_Push = asset.FindActionMap("Push", throwIfNotFound: true);
        m_Push_Push = m_Push.FindAction("Push", throwIfNotFound: true);
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
    private readonly InputAction m_Movement_Pull;
    private readonly InputAction m_Movement_Stop;
    public struct MovementActions
    {
        private @PlayerInputActions m_Wrapper;
        public MovementActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Movement_Move;
        public InputAction @Pull => m_Wrapper.m_Movement_Pull;
        public InputAction @Stop => m_Wrapper.m_Movement_Stop;
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
                @Pull.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnPull;
                @Pull.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnPull;
                @Pull.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnPull;
                @Stop.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnStop;
                @Stop.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnStop;
                @Stop.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnStop;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Pull.started += instance.OnPull;
                @Pull.performed += instance.OnPull;
                @Pull.canceled += instance.OnPull;
                @Stop.started += instance.OnStop;
                @Stop.performed += instance.OnStop;
                @Stop.canceled += instance.OnStop;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Selection
    private readonly InputActionMap m_Selection;
    private ISelectionActions m_SelectionActionsCallbackInterface;
    private readonly InputAction m_Selection_Newaction;
    public struct SelectionActions
    {
        private @PlayerInputActions m_Wrapper;
        public SelectionActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Selection_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Selection; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SelectionActions set) { return set.Get(); }
        public void SetCallbacks(ISelectionActions instance)
        {
            if (m_Wrapper.m_SelectionActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_SelectionActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_SelectionActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_SelectionActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_SelectionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public SelectionActions @Selection => new SelectionActions(this);

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

    // Push
    private readonly InputActionMap m_Push;
    private IPushActions m_PushActionsCallbackInterface;
    private readonly InputAction m_Push_Push;
    public struct PushActions
    {
        private @PlayerInputActions m_Wrapper;
        public PushActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Push => m_Wrapper.m_Push_Push;
        public InputActionMap Get() { return m_Wrapper.m_Push; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PushActions set) { return set.Get(); }
        public void SetCallbacks(IPushActions instance)
        {
            if (m_Wrapper.m_PushActionsCallbackInterface != null)
            {
                @Push.started -= m_Wrapper.m_PushActionsCallbackInterface.OnPush;
                @Push.performed -= m_Wrapper.m_PushActionsCallbackInterface.OnPush;
                @Push.canceled -= m_Wrapper.m_PushActionsCallbackInterface.OnPush;
            }
            m_Wrapper.m_PushActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Push.started += instance.OnPush;
                @Push.performed += instance.OnPush;
                @Push.canceled += instance.OnPush;
            }
        }
    }
    public PushActions @Push => new PushActions(this);
    public interface IMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnPull(InputAction.CallbackContext context);
        void OnStop(InputAction.CallbackContext context);
    }
    public interface ISelectionActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IFireActions
    {
        void OnFire(InputAction.CallbackContext context);
    }
    public interface IPushActions
    {
        void OnPush(InputAction.CallbackContext context);
    }
}
