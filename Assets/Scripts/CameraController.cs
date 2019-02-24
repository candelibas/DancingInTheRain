using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    public float step = 0.01f;

    [SerializeField]
    private Transform wayPoint;

    void Update()
    {
        var cameraPosition = Camera.main.gameObject.transform.position;
        
        if(cameraPosition.y >= wayPoint.position.y)
        {
            // stop camera
            cameraPosition.y = wayPoint.position.y;

            // The end!
            Invoke("GoEndingScene", 2f);
        }
        else
        {
            cameraPosition.y += step;
            Camera.main.gameObject.transform.position = cameraPosition;
        }
    }

    void GoEndingScene()
    {
        SceneManager.LoadScene(5);
    }
}
