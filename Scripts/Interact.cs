using UnityEngine;

public class Interact : MonoBehaviour
{

    [SerializeField] private Camera _camera;
    [SerializeField] private GameObject _Openbutton;
    private Ray _ray;
    private RaycastHit hit;
    private bool _buttonClick = false;
    private bool _RayInDoor = false;
    [SerializeField] private float MaxDistanceRay = 4f;


    private void Update()
    {
        Ray();
        DrawRay();
        InteractDoor();
    }

    private void Ray()
    {
        _ray = _camera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
    }

    private void DrawRay()
    {
        if (Physics.Raycast(_ray, out hit, MaxDistanceRay))
        {
            Debug.DrawRay(_ray.origin, _ray.direction * MaxDistanceRay, Color.red);
        }
    }


    private void InteractDoor()
    {
        if (hit.transform != null && hit.transform.GetComponent<Door>())
        {
            Debug.DrawRay(_ray.origin, _ray.direction * MaxDistanceRay, Color.blue);
            _Openbutton.SetActive(true);
            _RayInDoor = true;

        }
        else
        {
            _Openbutton.SetActive(false);
            _RayInDoor = false;
        }
    }

    
    
    private void OpenDoor()
    {
        if (_buttonClick && _RayInDoor)
        {
            hit.collider.gameObject.GetComponent<Door>().Open();
        }
    }
    
    public void ClickOpenButton()
    {
        _buttonClick = true;
        OpenDoor();
    }



}
