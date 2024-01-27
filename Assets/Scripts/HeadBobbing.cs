using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBobbing : MonoBehaviour
{
    public float walkingBobbingSpeed = 14f;
    public float bobbingAmount = 0.05f;
    public PlayerMovement controller;
    
    float defaultPosY = 0;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        defaultPosY = transform.localPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(controller.currentDirection.x) > 0.1f || Mathf.Abs(controller.currentDirection.y) > 0.1f)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, defaultPosY + Mathf.Sin(timer * walkingBobbingSpeed) * bobbingAmount, transform.localPosition.z);
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.Lerp(transform.localPosition.y, defaultPosY, Time.deltaTime * walkingBobbingSpeed), transform.localPosition.z);
        }
    }
}
