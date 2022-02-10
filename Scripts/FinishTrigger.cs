using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    [SerializeField] private InteractofPlatform _interact;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Win!");
        _interact.ExitfromPlatform();
    }
}
