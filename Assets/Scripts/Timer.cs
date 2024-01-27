using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    
    public float timeRemaining = 300;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        Debug.Log(timeRemaining);
        
        if (timeRemaining <0)
        {
            TimeHasRunOut();
        }
    }
    
    void TimeHasRunOut()
    {
        Debug.Log("Time has run out!");
    }
}
