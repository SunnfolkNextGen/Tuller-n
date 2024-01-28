using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float gravity = -13f;
    [SerializeField] private float moveSpeed = 6f;
    [SerializeField] private float sprintSpeed = 12f;
    [SerializeField] [Range(0f, 1f)] private float _moveSmoothTime = 0.3f;
    // Start is called before the first frame update
    
    
    private CharacterController _characterController;
    [SerializeField]private InputActionsController _input;
    
    
    private float _vel;
    public Vector2 currentDirection = Vector2.zero;
    private Vector2 _currentDirectionVel = Vector2.zero;
    
    public int DoorIndex;
    [SerializeField] private InfiniteCorridorController infinteCorridor;


    public bool isInteracting;
    void Awake()
    {
        _input = GetComponent<InputActionsController>();
        _characterController = GetComponent<CharacterController>();
        infinteCorridor = FindObjectOfType<InfiniteCorridorController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        currentDirection = Vector2.SmoothDamp(currentDirection, _input.MoveVector, 
            ref _currentDirectionVel, _moveSmoothTime);
        if (_characterController.isGrounded)
        {
            _vel = -2f;
        }
        else
        {
            _vel += gravity * Time.deltaTime;
        }
        
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

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Door1")
        {
            Debug.Log("Du er p� d�r 1");
            if (_input.Interact > 0.1f)
            {
                //Debug.Log("du �pnet d�r 1");
                DoorIndex = 1;
            }
            else infinteCorridor.spawnFix = true;
        }

        if (other.gameObject.tag == "Door2")
        {
            Debug.Log("Du er p� d�r 2");
            if (_input.Interact > 0.1f)
            {
                //Debug.Log("du �pnet d�r 2");
                DoorIndex = 2;
            }
            else infinteCorridor.spawnFix = true;
        }

        if (other.gameObject.tag == "Door3")
        {
            Debug.Log("Du er p� d�r 3");
            if (_input.Interact > 0.1f)
            {
                //Debug.Log("du �pnet d�r 3");
                DoorIndex = 3;
            }
            else infinteCorridor.spawnFix = true;
        }

        if (other.gameObject.tag == "Door4")
        {
            Debug.Log("Du er p� d�r 4");
            if (_input.Interact > 0.1f)
            {
                //Debug.Log("du �pnet d�r 4");
                DoorIndex = 4;
            }
            else infinteCorridor.spawnFix = true;
        }
    }
}
