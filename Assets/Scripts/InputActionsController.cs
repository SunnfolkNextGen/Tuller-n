using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;


[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]

public class InputActionsController : MonoBehaviour
{
    //private InputSystem _inputSystem;
    private CharacterController _characterController;
    private PlayerInput _playerInput;
    public Vector2 MoveVector { get; private set; }
    public Vector2 LookVector { get; private set; }
    
    public float Sprint { get; private set; }
    public float Interact { get; private set; }
    
    public bool SeeTimer{ get; private set; }
    // Start is called before the first frame update
    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
        _playerInput = new PlayerInput();
    }


    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        MoveVector = _playerInput.Input.Movement.ReadValue<Vector2>();
        LookVector = _playerInput.Input.Look.ReadValue<Vector2>();
        Sprint = _playerInput.Input.Sprint.ReadValue<float>();
        Interact = _playerInput.Input.Interact.ReadValue<float>();
        SeeTimer = _playerInput.Input.SeeTimer.IsPressed();

    }
}
