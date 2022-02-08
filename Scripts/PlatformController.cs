using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] private Platform _platformScript;
    [SerializeField] private Transform _platform;
    [SerializeField] private InteractofPlatform _interactofPlatform;


    void Start()
    {
        _platformScript.enabled = false;
    }

    private void Update()
    {
        if (_platform.position.y < -5f)
        {
            _interactofPlatform.ExitfromPlatform();
        }
    }
}
