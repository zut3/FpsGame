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
        if (hit.transform && hit.transform.GetComponent<Door>())
        {
            _Openbutton.SetActive(true);
            _RayInDoor = true;

        }
        else
        {
            _Openbutton.SetActive(false);
            _RayInDoor = false;
        }
    }



    public void OpenDoor()
    {
        if (_RayInDoor)
        {
            hit.collider.gameObject.GetComponent<Door>().Open();
        }
    }

}
