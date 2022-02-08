using UnityEngine;

public class Interact : MonoBehaviour
{

    [SerializeField] protected Camera _camera;

    protected Ray _ray;
    protected RaycastHit hit;


    protected void Ray()
    {
        _ray = _camera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
    }

    protected void Raycast()
    {
        Physics.Raycast(_ray, out hit);
    }
}
