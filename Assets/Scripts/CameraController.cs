using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float step = 0.01f;

    [SerializeField]
    private Transform wayPoint;

    void Start()
    {
        
    }

    void Update()
    {
        var cameraPosition = Camera.main.gameObject.transform.position;
        
        if(cameraPosition.y >= wayPoint.position.y)
        {
            // stop camera
            cameraPosition.y = wayPoint.position.y;
        }
        else
        {
            cameraPosition.y += step;
            Camera.main.gameObject.transform.position = cameraPosition;
        }
    }
}
