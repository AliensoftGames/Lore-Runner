//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/PlayerTouch.inputactions
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

public partial class @PlayerTouch: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerTouch()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerTouch"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""69d6c5eb-878f-4964-a809-8f310fd12e6b"",
            ""actions"": [
                {
                    ""name"": ""FisrtContact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""54243e49-8baa-4677-b800-f6cc71c21d85"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FirstPos"",
                    ""type"": ""PassThrough"",
                    ""id"": ""76383a99-abba-4762-a2c7-a071baf04cea"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7cccd33f-6036-42ce-9e92-fdd1cae38051"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FisrtContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b2f901f-d89c-4c41-a7d7-19636119c96b"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FirstPos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Touch
        m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
        m_Touch_FisrtContact = m_Touch.FindAction("FisrtContact", throwIfNotFound: true);
        m_Touch_FirstPos = m_Touch.FindAction("FirstPos", throwIfNotFound: true);
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

    // Touch
    private readonly InputActionMap m_Touch;
    private List<ITouchActions> m_TouchActionsCallbackInterfaces = new List<ITouchActions>();
    private readonly InputAction m_Touch_FisrtContact;
    private readonly InputAction m_Touch_FirstPos;
    public struct TouchActions
    {
        private @PlayerTouch m_Wrapper;
        public TouchActions(@PlayerTouch wrapper) { m_Wrapper = wrapper; }
        public InputAction @FisrtContact => m_Wrapper.m_Touch_FisrtContact;
        public InputAction @FirstPos => m_Wrapper.m_Touch_FirstPos;
        public InputActionMap Get() { return m_Wrapper.m_Touch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
        public void AddCallbacks(ITouchActions instance)
        {
            if (instance == null || m_Wrapper.m_TouchActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TouchActionsCallbackInterfaces.Add(instance);
            @FisrtContact.started += instance.OnFisrtContact;
            @FisrtContact.performed += instance.OnFisrtContact;
            @FisrtContact.canceled += instance.OnFisrtContact;
            @FirstPos.started += instance.OnFirstPos;
            @FirstPos.performed += instance.OnFirstPos;
            @FirstPos.canceled += instance.OnFirstPos;
        }

        private void UnregisterCallbacks(ITouchActions instance)
        {
            @FisrtContact.started -= instance.OnFisrtContact;
            @FisrtContact.performed -= instance.OnFisrtContact;
            @FisrtContact.canceled -= instance.OnFisrtContact;
            @FirstPos.started -= instance.OnFirstPos;
            @FirstPos.performed -= instance.OnFirstPos;
            @FirstPos.canceled -= instance.OnFirstPos;
        }

        public void RemoveCallbacks(ITouchActions instance)
        {
            if (m_Wrapper.m_TouchActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITouchActions instance)
        {
            foreach (var item in m_Wrapper.m_TouchActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TouchActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TouchActions @Touch => new TouchActions(this);
    public interface ITouchActions
    {
        void OnFisrtContact(InputAction.CallbackContext context);
        void OnFirstPos(InputAction.CallbackContext context);
    }
}