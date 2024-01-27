using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiinteCorridorRoomSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject RoomToBeEnabled1;
    [SerializeField] private GameObject RoomToBeEnabled2;
    [SerializeField] private GameObject RoomToBeDisabled1;
    [SerializeField] private GameObject RoomToBeDisabled2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"){
            RoomToBeEnabled1.gameObject.SetActive(true);
            RoomToBeEnabled2.gameObject.SetActive(true);
            RoomToBeDisabled1.gameObject.SetActive(false);
            RoomToBeDisabled2.gameObject.SetActive(false);
        }
    }

}
