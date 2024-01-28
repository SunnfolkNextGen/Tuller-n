using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]private Timer timer;
    [SerializeField]private InputActionsController input;
    [SerializeField]private Animator animator;
    private static readonly int IsHoldingUpArm = Animator.StringToHash("IsHoldingUpArm");

    // Start is called before the first frame update

    private void Awake()
    {
        animator.Play("idle");
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
        
        Debug.Log(timer.timeRemaining);
    }
    
    private IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
    }
}
