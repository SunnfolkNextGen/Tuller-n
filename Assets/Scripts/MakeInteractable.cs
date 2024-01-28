using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeInteractable : MonoBehaviour
{
    
    public DoorOpenAndClose doorOpenAndClose;
    // Start is called before the first frame update
    public void MakeInteractableDoor()
    {
        doorOpenAndClose.MakeInteractable();
    }
}
