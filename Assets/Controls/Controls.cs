// GENERATED AUTOMATICALLY FROM 'Assets/Controls/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""d83cb9c4-1d9c-4bc6-b6a3-f141e741f161"",
            ""actions"": [
                {
                    ""name"": ""SpawnBallLeft"",
                    ""type"": ""Button"",
                    ""id"": ""9ef9c8b7-352f-486d-952c-9d2957632db2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpawnBallRight"",
                    ""type"": ""Button"",
                    ""id"": ""5e3c243c-a950-4117-9233-872217a6b7d1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RestartGame"",
                    ""type"": ""Button"",
                    ""id"": ""5344c814-0d15-4ddf-af65-5382ffe0da18"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""3226df66-b3c3-4642-a98e-e5e331b25e98"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c07aa3c2-1bed-4f93-9403-039238ad9e3f"",
                    ""path"": ""<XRController>{LeftHand}/triggerButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RestartGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a8f397f-9928-4a59-bd26-0bc194429194"",
                    ""path"": ""<XRController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RestartGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1921d3c1-d4a5-4b0d-b3f3-09e537888f03"",
                    ""path"": ""<XRController>{LeftHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RestartGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a3c8a20-1b42-41d3-b4a7-1e8542f87122"",
                    ""path"": ""<XRController>{LeftHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnBallLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c6f5e86-75bf-4d06-8cd7-9841b1265f7b"",
                    ""path"": ""<XRController>{LeftHand}/triggerButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnBallLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91096cbd-6be1-473d-8457-3949ac2583a8"",
                    ""path"": ""<XRController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnBallLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf553e04-a613-491e-b3b2-e5dab659c447"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RestartGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6eb8c0a8-5ee6-4581-a3cd-c6a0a7d960ed"",
                    ""path"": ""<XRController>{RightHand}/triggerButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RestartGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f3d0983-ed95-4cb4-83eb-cbc34f4f1b3f"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RestartGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd0decaa-3980-4303-99fa-1b6c2d8f3d33"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnBallRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec2495f9-d695-44e0-bf19-4b49c7634852"",
                    ""path"": ""<XRController>{RightHand}/triggerButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnBallRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2db3709c-334e-48f3-9546-07b9dc06bef7"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnBallRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c320282-dfb0-41bb-b94b-613a895e23d6"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""VR"",
            ""bindingGroup"": ""VR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_SpawnBallLeft = m_Player.FindAction("SpawnBallLeft", throwIfNotFound: true);
        m_Player_SpawnBallRight = m_Player.FindAction("SpawnBallRight", throwIfNotFound: true);
        m_Player_RestartGame = m_Player.FindAction("RestartGame", throwIfNotFound: true);
        m_Player_Escape = m_Player.FindAction("Escape", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_SpawnBallLeft;
    private readonly InputAction m_Player_SpawnBallRight;
    private readonly InputAction m_Player_RestartGame;
    private readonly InputAction m_Player_Escape;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SpawnBallLeft => m_Wrapper.m_Player_SpawnBallLeft;
        public InputAction @SpawnBallRight => m_Wrapper.m_Player_SpawnBallRight;
        public InputAction @RestartGame => m_Wrapper.m_Player_RestartGame;
        public InputAction @Escape => m_Wrapper.m_Player_Escape;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @SpawnBallLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpawnBallLeft;
                @SpawnBallLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpawnBallLeft;
                @SpawnBallLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpawnBallLeft;
                @SpawnBallRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpawnBallRight;
                @SpawnBallRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpawnBallRight;
                @SpawnBallRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpawnBallRight;
                @RestartGame.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRestartGame;
                @RestartGame.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRestartGame;
                @RestartGame.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRestartGame;
                @Escape.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEscape;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SpawnBallLeft.started += instance.OnSpawnBallLeft;
                @SpawnBallLeft.performed += instance.OnSpawnBallLeft;
                @SpawnBallLeft.canceled += instance.OnSpawnBallLeft;
                @SpawnBallRight.started += instance.OnSpawnBallRight;
                @SpawnBallRight.performed += instance.OnSpawnBallRight;
                @SpawnBallRight.canceled += instance.OnSpawnBallRight;
                @RestartGame.started += instance.OnRestartGame;
                @RestartGame.performed += instance.OnRestartGame;
                @RestartGame.canceled += instance.OnRestartGame;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_VRSchemeIndex = -1;
    public InputControlScheme VRScheme
    {
        get
        {
            if (m_VRSchemeIndex == -1) m_VRSchemeIndex = asset.FindControlSchemeIndex("VR");
            return asset.controlSchemes[m_VRSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnSpawnBallLeft(InputAction.CallbackContext context);
        void OnSpawnBallRight(InputAction.CallbackContext context);
        void OnRestartGame(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
    }
}
