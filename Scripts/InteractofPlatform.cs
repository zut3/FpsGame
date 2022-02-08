using UnityEngine;

public class InteractofPlatform : Interact
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _duck;
    [SerializeField] private GameObject _button;
    [SerializeField] private GameObject _Platformcamera;
    [SerializeField] private Transform _spawn;
    private Platform _platformControll;
    [SerializeField] private GameObject _platform;

    private void Update()
    {
        Ray();
        Raycast();
        CheckPlatform();
    }

    private void CheckPlatform()
    {
        Platform plat = hit.collider.gameObject.GetComponent<Platform>();
        if (plat)
        {
            _button.SetActive(true);
            _platformControll = plat;
            Debug.DrawRay(_ray.origin, _ray.direction, Color.red);
        }
        else
        {
            _button.SetActive(false);
            _platformControll = null;
        }
    }

    public void GoToPlatform()
    {
        _player.SetActive(false);
        _Platformcamera.SetActive(true);
        _platformControll.enabled = true;
        _duck.SetActive(true);
    }

    public void ExitfromPlatform()
    {
        _Platformcamera.SetActive(false);
        _player.SetActive(true);
        _platformControll.enabled = false;
        _platform.transform.position = _spawn.position;
        _duck.SetActive(false);
    }
}
