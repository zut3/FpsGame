using UnityEngine;

public class MouseControll : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Joystick _joystick;
    private float xRotation;
    [SerializeField] private float _sens = 250f;

    // Update is called once per frame

    private void Update()
    {
        float MouseX = _joystick.Horizontal * _sens * Time.deltaTime;
        float MouseY = _joystick.Vertical * _sens * Time.deltaTime;

        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        _player.Rotate(Vector3.up * MouseX);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
    }
}
