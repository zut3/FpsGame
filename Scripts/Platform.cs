using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;
    [SerializeField] private float _speed;

    
    private void Update()
    {
        float horisontal = _joystick.Horizontal;
        float vertical = _joystick.Vertical;

        Vector3 offset = new Vector3(horisontal, 0, vertical) * Time.deltaTime * _speed;
        transform.Translate(offset);
    }

}
