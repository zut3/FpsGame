using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayControll : MonoBehaviour
{
    [SerializeField] private Transform _sun;
    [SerializeField]private float _offset = 0.75f;


    void Update()
    {
        _sun.Rotate(new Vector3(0, _offset, 0) * Time.deltaTime);
    }
}
