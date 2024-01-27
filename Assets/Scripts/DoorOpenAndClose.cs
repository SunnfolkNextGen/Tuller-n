using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenAndClose : MonoBehaviour
{
    [SerializeField] private Animator animator  = null;
    [SerializeField] private PlayerMovement player;
    
    [SerializeField] private bool isOpenTrigger;
    [SerializeField] private bool isCloseTrigger;
    
    private InputActionsController _input;
    // Start is called before the first frame update
    void Start()
    {
        //player = FindObjectOfType<PlayerMovement>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player is in trigger");
            if (player.isInteracting)
            {
                if (isOpenTrigger)
                {   
                    animator.Play("Door Open", 0, 0f);
                }
                else if (isCloseTrigger)
                {
                    animator.Play("Door close", 0, 0f);
                }
              
            }
            
        }
    }
    // Update is called once per frame
    
}
