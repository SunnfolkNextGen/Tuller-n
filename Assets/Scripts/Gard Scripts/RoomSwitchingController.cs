using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSwitchingController : MonoBehaviour
{
    
    [SerializeField] private GameObject RoomToBeDisabled;
    [SerializeField] private GameObject RoomToBeEnabled;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"){
            RoomToBeEnabled.gameObject.SetActive(true);
            RoomToBeDisabled.gameObject.SetActive(false);
        }
    }
}
