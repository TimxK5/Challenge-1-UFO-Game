using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotator : MonoBehaviour
{


    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, -45) * Time.deltaTime);
    }
}
