// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerInput/InputSystem/GameplayControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameplayControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameplayControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameplayControls"",
    ""maps"": [
        {
            ""name"": ""PlayerActionMap"",
            ""id"": ""90f47b6c-65b5-42fb-bee7-62a89acbc2c7"",
            ""actions"": [
                {
                    ""name"": ""MovePlayer"",
                    ""type"": ""PassThrough"",
                    ""id"": ""de32b82d-1615-4723-a397-10c730a7ad21"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveHCell"",
                    ""type"": ""Value"",
                    ""id"": ""a7f8dfa9-d6a0-4432-a510-9edfe1eaac6b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveVCell"",
                    ""type"": ""Value"",
                    ""id"": ""7efd46ba-26cb-487f-8e69-a03a5691ff8e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LClick"",
                    ""type"": ""Button"",
                    ""id"": ""bad81604-4857-40fc-92dc-ed4540868e7c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Spacebar"",
                    ""type"": ""Button"",
                    ""id"": ""9385b6fb-7f7b-49bf-b6e6-8f08e09bb8e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9d39e77b-ae3e-43c1-8138-53268418dfc5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovePlayer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f15ada1f-fb86-4176-97c5-0ae8131a4f9d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovePlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""74f3383f-5729-4105-b364-b985d64e3272"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovePlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""de5c26d3-4a42-462e-a763-965e8b921842"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovePlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""82216432-1fb0-426f-a84b-7972ed36ba9a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovePlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""0f3067d5-4992-4a64-95be-14fd720b0b7d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveHCell"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c717e53f-ba01-4923-ab86-326d3de5821f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveHCell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4a391a43-8d98-4ed6-ba3b-b220c4410b71"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveHCell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""a121983d-6ba3-4bab-b6cb-7acdeed8364b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveVCell"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f76c4949-e8a6-4f91-b01c-c284d1e318aa"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveVCell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9bdf4625-4621-4f96-b589-43647082e148"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveVCell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""522dc153-a1cb-42ac-a0f0-b5a499a7fa19"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b05ce0e3-e179-4ed7-839f-ef9269dfbbb4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spacebar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerActionMap
        m_PlayerActionMap = asset.FindActionMap("PlayerActionMap", throwIfNotFound: true);
        m_PlayerActionMap_MovePlayer = m_PlayerActionMap.FindAction("MovePlayer", throwIfNotFound: true);
        m_PlayerActionMap_MoveHCell = m_PlayerActionMap.FindAction("MoveHCell", throwIfNotFound: true);
        m_PlayerActionMap_MoveVCell = m_PlayerActionMap.FindAction("MoveVCell", throwIfNotFound: true);
        m_PlayerActionMap_LClick = m_PlayerActionMap.FindAction("LClick", throwIfNotFound: true);
        m_PlayerActionMap_Spacebar = m_PlayerActionMap.FindAction("Spacebar", throwIfNotFound: true);
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

    // PlayerActionMap
    private readonly InputActionMap m_PlayerActionMap;
    private IPlayerActionMapActions m_PlayerActionMapActionsCallbackInterface;
    private readonly InputAction m_PlayerActionMap_MovePlayer;
    private readonly InputAction m_PlayerActionMap_MoveHCell;
    private readonly InputAction m_PlayerActionMap_MoveVCell;
    private readonly InputAction m_PlayerActionMap_LClick;
    private readonly InputAction m_PlayerActionMap_Spacebar;
    public struct PlayerActionMapActions
    {
        private @GameplayControls m_Wrapper;
        public PlayerActionMapActions(@GameplayControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovePlayer => m_Wrapper.m_PlayerActionMap_MovePlayer;
        public InputAction @MoveHCell => m_Wrapper.m_PlayerActionMap_MoveHCell;
        public InputAction @MoveVCell => m_Wrapper.m_PlayerActionMap_MoveVCell;
        public InputAction @LClick => m_Wrapper.m_PlayerActionMap_LClick;
        public InputAction @Spacebar => m_Wrapper.m_PlayerActionMap_Spacebar;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionMapActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionMapActions instance)
        {
            if (m_Wrapper.m_PlayerActionMapActionsCallbackInterface != null)
            {
                @MovePlayer.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnMovePlayer;
                @MovePlayer.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnMovePlayer;
                @MovePlayer.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnMovePlayer;
                @MoveHCell.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnMoveHCell;
                @MoveHCell.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnMoveHCell;
                @MoveHCell.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnMoveHCell;
                @MoveVCell.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnMoveVCell;
                @MoveVCell.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnMoveVCell;
                @MoveVCell.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnMoveVCell;
                @LClick.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnLClick;
                @LClick.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnLClick;
                @LClick.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnLClick;
                @Spacebar.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnSpacebar;
                @Spacebar.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnSpacebar;
                @Spacebar.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnSpacebar;
            }
            m_Wrapper.m_PlayerActionMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovePlayer.started += instance.OnMovePlayer;
                @MovePlayer.performed += instance.OnMovePlayer;
                @MovePlayer.canceled += instance.OnMovePlayer;
                @MoveHCell.started += instance.OnMoveHCell;
                @MoveHCell.performed += instance.OnMoveHCell;
                @MoveHCell.canceled += instance.OnMoveHCell;
                @MoveVCell.started += instance.OnMoveVCell;
                @MoveVCell.performed += instance.OnMoveVCell;
                @MoveVCell.canceled += instance.OnMoveVCell;
                @LClick.started += instance.OnLClick;
                @LClick.performed += instance.OnLClick;
                @LClick.canceled += instance.OnLClick;
                @Spacebar.started += instance.OnSpacebar;
                @Spacebar.performed += instance.OnSpacebar;
                @Spacebar.canceled += instance.OnSpacebar;
            }
        }
    }
    public PlayerActionMapActions @PlayerActionMap => new PlayerActionMapActions(this);
    public interface IPlayerActionMapActions
    {
        void OnMovePlayer(InputAction.CallbackContext context);
        void OnMoveHCell(InputAction.CallbackContext context);
        void OnMoveVCell(InputAction.CallbackContext context);
        void OnLClick(InputAction.CallbackContext context);
        void OnSpacebar(InputAction.CallbackContext context);
    }
}
