using UnityEngine;
using UnityEngine.Events;

public class TriggerEventCaller : MonoBehaviour
{
    [System.Serializable]
    public class TriggerEvent : UnityEvent { }

    public TriggerEvent onTriggerEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            onTriggerEnterEvent.Invoke();
        }
    }
}