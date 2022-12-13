using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class XRInputManager : MonoBehaviour, XRInputAction.IRightHandOculusActions, XRInputAction.ILeftHandOculusActions
{
    [Serializable]
    public struct  Hand
    {
        public Vector2 stick;
        public bool stickTouched;
        public bool stickClicked;
        public bool trigger;
        public bool grip;
        public bool primaryTouched;
        public bool primaryClick;
        public bool secondaryTouched;
        public bool secondaryClick;
        public bool menu;
    }
    
    [Header("Left Hand Inputs")] public Hand leftHand;
    [Header("Right Hand Inputs")] public Hand rightHand;
    

    private XRInputAction _inputAction;

    private void Awake()
    {
        _inputAction = new XRInputAction();
        _inputAction.Enable();
        _inputAction.LeftHandOculus.SetCallbacks(this);
        _inputAction.RightHandOculus.SetCallbacks(this);
    }

    void XRInputAction.IRightHandOculusActions.OnStick(InputAction.CallbackContext context)
    {
        rightHand.stick = context.ReadValue<Vector2>();
        Debug.Log(rightHand.stick+" Left Stick Axis");
    }

    void XRInputAction.ILeftHandOculusActions.OnGrip(InputAction.CallbackContext context)
    {
        leftHand.grip = context.action.IsPressed();
        Debug.Log("Left Hand Grip");
    }

    void XRInputAction.ILeftHandOculusActions.OnTracked(InputAction.CallbackContext context)
    {
        Debug.Log("Left Tracked");
    }

    void XRInputAction.ILeftHandOculusActions.OnPrimaryKey(InputAction.CallbackContext context)
    {
        leftHand.primaryClick = context.action.IsPressed();
        Debug.Log(leftHand.primaryClick + " X Key is Pressed");
        GameManager.Instance.SwitchCharacter();
    }

    void XRInputAction.ILeftHandOculusActions.OnPrimaryTouched(InputAction.CallbackContext context)
    {
        leftHand.primaryTouched = context.action.IsPressed();
        Debug.Log(leftHand.primaryTouched + " X key is touched");
    }

    void XRInputAction.ILeftHandOculusActions.OnSecondaryKey(InputAction.CallbackContext context)
    {
        leftHand.secondaryClick = context.action.IsPressed();
        Debug.Log(leftHand.secondaryClick + " Y key is clicked");
    }

    void XRInputAction.ILeftHandOculusActions.OnSecondaryTouched(InputAction.CallbackContext context)
    {
        leftHand.secondaryTouched = context.action.IsPressed();
        Debug.Log(leftHand.secondaryTouched + " Y key is touched");
    }

    void XRInputAction.ILeftHandOculusActions.OnStart(InputAction.CallbackContext context)
    {
        leftHand.menu = context.action.IsPressed();
        Debug.Log("Left Start key Is Pressed");
    }

    void XRInputAction.ILeftHandOculusActions.OnStickClicked(InputAction.CallbackContext context)
    {
        leftHand.stickClicked = context.action.IsPressed();
        Debug.Log(leftHand.stickClicked+" Left Hand Stick Clicked");
    }

    void XRInputAction.ILeftHandOculusActions.OnStickTouched(InputAction.CallbackContext context)
    {
        leftHand.stickTouched = context.action.IsPressed();
        Debug.Log(leftHand.stickTouched+" Left Hand Stick Touched");

    }

    void XRInputAction.ILeftHandOculusActions.OnTrigger(InputAction.CallbackContext context)
    {
        leftHand.trigger = context.action.IsPressed();
        Debug.Log(leftHand.trigger+" Left Hand Trigger");
    }

    void XRInputAction.ILeftHandOculusActions.OnStick(InputAction.CallbackContext context)
    {
        leftHand.stick = context.ReadValue<Vector2>();
        Debug.Log(leftHand.stick +" Left Stick Value");
    }

    void XRInputAction.IRightHandOculusActions.OnGrip(InputAction.CallbackContext context)
    {
        rightHand.grip = context.action.IsPressed();
        Debug.Log(rightHand.grip+" Right Grip");
    }

    void XRInputAction.IRightHandOculusActions.OnTracked(InputAction.CallbackContext context)
    {
        Debug.Log("Left Hand Tracked");
    }

    void XRInputAction.IRightHandOculusActions.OnPrimaryKey(InputAction.CallbackContext context)
    {
        rightHand.primaryClick = context.action.IsPressed();
        Debug.Log(rightHand.primaryClick+" A is Pressed");
    }

    void XRInputAction.IRightHandOculusActions.OnPrimaryTouched(InputAction.CallbackContext context)
    {
        rightHand.primaryTouched = context.action.IsPressed();
        Debug.Log(rightHand.primaryTouched+" A primary touched");
    }

    void XRInputAction.IRightHandOculusActions.OnSecondaryKey(InputAction.CallbackContext context)
    {
        rightHand.secondaryClick = context.action.IsPressed();
        Debug.Log(rightHand.secondaryClick +" B secondary click");
    }

    void XRInputAction.IRightHandOculusActions.OnSecondaryTouched(InputAction.CallbackContext context)
    {
        rightHand.secondaryTouched = context.action.IsPressed();
        Debug.Log(rightHand.secondaryTouched+" B secondary touched");
    }

    void XRInputAction.IRightHandOculusActions.OnStart(InputAction.CallbackContext context)
    {
    }

    void XRInputAction.IRightHandOculusActions.OnStickClicked(InputAction.CallbackContext context)
    {
        rightHand.stickClicked = context.action.IsPressed();
        Debug.Log(rightHand.stickClicked+"right stick clicked");
    }

    void XRInputAction.IRightHandOculusActions.OnStickTouched(InputAction.CallbackContext context)
    {
        rightHand.stickTouched = context.action.IsPressed();
        Debug.Log(rightHand.stickTouched+" right stick touch");
    }

    void XRInputAction.IRightHandOculusActions.OnTrigger(InputAction.CallbackContext context)
    {
        rightHand.trigger = context.action.IsPressed();
        Debug.Log(rightHand.trigger+" Right Trigger");
    }
}
