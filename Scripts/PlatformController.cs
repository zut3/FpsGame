using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] private Platform platform;
    void Start()
    {
        platform.enabled = false;
    }
}
