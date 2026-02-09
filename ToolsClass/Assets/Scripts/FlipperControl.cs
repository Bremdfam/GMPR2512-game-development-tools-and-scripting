using System;
using NUnit.Framework;
using UnityEngine;

public class FlipperControl : MonoBehaviour
{
    // Variables
    [SerializeField] private float _flipSpeed = 1000f;
    [SerializeField] private float _returnSpeed = -1000f;
    [SerializeField] private bool isRightFlipper = true;
    private HingeJoint2D _joint;
    private JointMotor2D _motor;
    private PlayerInputActions _input;
    void Awake()
    {
        _joint = GetComponent<HingeJoint2D>();
        _input = new PlayerInputActions();
        
    }
    void OnEnable()
    {
        _input.Enable();
    }
    void OnDisable()
    {
        _input.Disable();
    }

    private void FixedUpdate()
    {
        // Get motor
        _motor = _joint.motor;
        // Check input
        bool isPressed = false;
        if(isRightFlipper) isPressed = _input.Player.RightFlipper.IsPressed();
        else isPressed = _input.Player.LeftFlipper.IsPressed();
        // Set Pressed
        if(isPressed) _motor.motorSpeed = _flipSpeed;
        else _motor.motorSpeed = _returnSpeed;
        // Apply back to joint
        _joint.motor = _motor;
    }

    void Update()
    {
        
    }
}
