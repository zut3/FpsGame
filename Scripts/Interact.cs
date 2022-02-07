using UnityEngine;

public class Interact : MonoBehaviour
{

    [SerializeField] protected Camera _camera;
    
    protected Ray _ray;
    protected RaycastHit hit;
    [SerializeField] protected float MaxDistanceRay = 4f;


    protected void Ray()
    {
        _ray = _camera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
    }

    protected void Raycast()
    {
        if(Physics.Raycast(_ray, out hit, MaxDistanceRay))
        {
            Debug.DrawRay(_ray.origin , _ray.direction , Color.blue);
        }
        
    }
}
