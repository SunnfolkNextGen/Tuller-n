using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] private float moveSpeed = 6f;
    [SerializeField] private float sprintSpeed = 12f;
    [SerializeField] [Range(0f, 1f)] private float _moveSmoothTime = 0.3f;
    // Start is called before the first frame update
    
    
    private CharacterController _characterController;
    private InputActionsController _input;
    
    
    private float _vel  = -2f;
    public Vector2 currentDirection = Vector2.zero;
    private Vector2 _currentDirectionVel = Vector2.zero;
    
    public bool isInteracting;
    void Awake()
    {
        _input = GetComponent<InputActionsController>();
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        currentDirection = Vector2.SmoothDamp(currentDirection, _input.MoveVector, 
            ref _currentDirectionVel, _moveSmoothTime);
        
        _vel = Mathf.Clamp(_vel, -26f, 26f);
 
        //Saves inputted movement & gravity
        var vel = (transform.forward * currentDirection.y + transform.right * currentDirection.x) * moveSpeed + Vector3.up * _vel;

        //Moves the character based on vel
        _characterController.Move(vel * Time.deltaTime);
        
        if (_input.Sprint > 0.1f)
        {
            moveSpeed = sprintSpeed;
            Debug.Log("Sprinting");
        }
        else
        {
            moveSpeed = 6f;
        }

        if (_input.Interact > 0.1f)
        {
            isInteracting = true;
        }
        else
        {
            isInteracting = false;
        }
        
    }
}
