using UnityEngine;


public class Movement : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;
    private float _speed = 10f;


    private void Update()
    {

        float x = _joystick.Horizontal;
        float z = _joystick.Vertical;

        Vector3 offset = new Vector3(x, 0, z) * _speed * Time.deltaTime;
        transform.Translate(offset);

    }

}
