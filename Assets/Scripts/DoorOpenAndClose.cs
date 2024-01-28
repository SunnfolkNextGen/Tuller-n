using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenAndClose : MonoBehaviour
{
    [SerializeField] private Animator animator  = null;
    [SerializeField] private PlayerMovement player;
    
    [SerializeField]private InputActionsController _input;
    
    [SerializeField] private bool isOpen;

    private bool _isInteractable;
        
    
    
    // Start is called before the first frame update
    void Start()
    {
        _isInteractable = true;
        player = FindObjectOfType<PlayerMovement>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player is in trigger");
            if (_input.Interact>0.1f && _isInteractable)
            {
                Debug.Log("Player is interacting"); 
                if (!isOpen)    
                {   
                    animator.Play("Door Open", 0, 0f);
                    isOpen = true;
                    _isInteractable = false;
                    
                }
                else if (isOpen)
                {
                    animator.Play("Door close", 0, 0f);
                    isOpen = false;     
                    _isInteractable = false;
                }
                
            }

           
        }
    }

    public void MakeInteractable()
    {
        _isInteractable = true;
    }
}
