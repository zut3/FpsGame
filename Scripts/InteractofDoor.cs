using UnityEngine;

public class InteractofDoor : Interact
{
    [SerializeField] private GameObject _Openbutton;
    private bool _RayInDoor = false;

    private void Update()
    {
        Ray();
        Raycast();
        InteractDoor();
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
        if (_RayInDoor)
        {
            hit.collider.gameObject.GetComponent<Door>().Open();
        }
    }

    public void ClickOpenButton()
    {
        OpenDoor();
    }

}
