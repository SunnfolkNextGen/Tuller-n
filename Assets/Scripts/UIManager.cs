using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]private Timer timer;
    [SerializeField]private InputActionsController input;
    [SerializeField]private Animator animator;
    
    // Start is called before the first frame update

    private void Awake()
    {
        animator.Play("idle");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (input.SeeTimer>0)
        {
           
            animator.Play("ArmAnimation");
        }

        if (input.SeeTimer<=0)
        
        {
            animator.Play("PutAwayArm");
        }
        
        Debug.Log(timer.timeRemaining);
    }
    
    private IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
    }
}
