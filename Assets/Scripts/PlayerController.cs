using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, 180 * Time.deltaTime);
    }
}
