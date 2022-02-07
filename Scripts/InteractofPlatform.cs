using UnityEngine;

public class InteractofPlatform : Interact
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _button;
    [SerializeField] private Camera _Platformcamera;
    private Platform _platform;

    private void Update()
    {
        Ray();
        Raycast();
        CheckPlatform();
    }

    private void CheckPlatform()
    {
        _platform = hit.collider.gameObject.GetComponent<Platform>();
        if (_platform)
        {
            _button.SetActive(true);
        }
        else
        { 
            _button.SetActive(false);
        }
    }

    public void GoToPlatform()
    {
        _player.SetActive(false);
        _Platformcamera.enabled = true;
        Camera.SetupCurrent(_Platformcamera);
        _platform.enabled = true;
    }
}
