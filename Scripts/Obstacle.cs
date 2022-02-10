using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Renderer _renderer;
    private Color _startcolor;
    [SerializeField] private Color _endColor;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _startcolor = _renderer.material.color;
        
    }

    
    void Update()
    {
        _renderer.material.color = Color.Lerp(_startcolor, _endColor, Mathf.PingPong(Time.time , 1));
        
    }
}
