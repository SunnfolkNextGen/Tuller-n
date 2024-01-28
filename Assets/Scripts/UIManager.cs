using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TMP_Text textTimer;
    [SerializeField]private InputActionsController input;
    [SerializeField]private Animator animator;
    private static readonly int IsHoldingUpArm = Animator.StringToHash("IsHoldingUpArm");

    // Start is called before the first frame update

    private void Awake()
    {
        animator.Play("idle");
        textTimer.alpha = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (input.SeeTimer)
        {
            animator.SetBool(IsHoldingUpArm, true);
            
           
        }
        else
        {
            animator.SetBool(IsHoldingUpArm, false);
            
        }
        
        
    }
    
    
}
