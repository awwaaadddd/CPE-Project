using System;
using UnityEngine;

public class CustomHandVisualControl : MonoBehaviour
{
    public enum Hand
    {
        LeftHand = 0,
        RightHand = 1,
    }

    [SerializeField] private Hand hand;

    [SerializeField] private bool showControllers;
    
    [Header("VR Controller")]
    [SerializeField] private GameObject controllerPrefab;
    [SerializeField] private Vector3 controllerOffset;

    [Header("VR Hands")] [SerializeField] private GameObject handPrefab;
    [SerializeField] private Vector3 offset;

    private XRInputManager _manager;
    private XRInputManager.Hand _handInput;

    private GameObject _controller;
    private GameObject _hand;

    private Animator _animator;
    
    private void Awake()
    {
        _manager = FindObjectOfType<XRInputManager>();
        if (_manager == null)
        {
            _manager = Instantiate(new GameObject("XRInputManager"), Vector3.zero, Quaternion.identity)
                .AddComponent<XRInputManager>();
        }
    }

    private void Start()
    {
        if (showControllers)
        {
            _controller = Instantiate(controllerPrefab, transform);
        }
        else
        {
            _hand = Instantiate(handPrefab, transform);
            _animator = _hand.GetComponentInChildren<Animator>();
        }
        
        _handInput = hand switch
        {
            Hand.LeftHand => _manager.leftHand,
            Hand.RightHand => _manager.rightHand,
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    private void LateUpdate()
    {
        if (showControllers) return;
        _animator.SetBool("Grip", _handInput.grip);
        _animator.SetBool("Trigger", _handInput.trigger);
    }

}
