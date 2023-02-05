using UnityEngine;
using UnityEngine.Events;

//essentially a bool
[RequireComponent(typeof(Collider))]

public class TriggerEventsBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
	
    private Collider colliderObj;

    private void Start()
    {
        colliderObj = GetComponent<Collider>();
        colliderObj.isTrigger = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

}