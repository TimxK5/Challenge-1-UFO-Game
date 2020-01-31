using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public Vector2 a, b;
    [Range(0, 1)]
    public float speed = 1.0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = Vector3.Lerp(a, b, Mathf.PingPong(Time.time * speed, 1)); 
    }
}
