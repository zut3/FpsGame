using UnityEngine;

public class MainCamera : MonoBehaviour
{
    private void Start()
    {
        Camera cam = GetComponent<Camera>();
        cam.enabled = true;
    }
}
