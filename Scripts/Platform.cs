using System;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;
    [SerializeField] private float _speed;
    [SerializeField] private InteractofPlatform _interactofPlatform;

    private void Update()
    {
        float horisontal = _joystick.Horizontal;
        float vertical = _joystick.Vertical;

        Vector3 offset = new Vector3(vertical, 0, -horisontal) * Time.deltaTime * _speed;
        transform.Translate(offset);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            _interactofPlatform.ExitfromPlatform();        
        }
    }
}
