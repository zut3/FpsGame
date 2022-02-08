using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Transform _platform;

    private void Update()
    {
        transform.position = _platform.position + offset;
    }
}
