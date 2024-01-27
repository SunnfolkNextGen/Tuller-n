using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneTimeSound : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().enabled = true;
        GetComponent<BoxCollider>().enabled = false;
    }
}
