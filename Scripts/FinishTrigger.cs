using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class FinishTrigger : MonoBehaviour
{
    [SerializeField] private InteractofPlatform _interact;
    [SerializeField] private UnityEvent _easterevent;
    

    private void OnTriggerEnter(Collider other)
    {
        _interact.ExitfromPlatform();
        _easterevent.Invoke();
    }
}
