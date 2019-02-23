using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biker : MonoBehaviour
{
    public float bikeSpeed = 3f;
    private float boostSpeed = 1f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.up * bikeSpeed * boostSpeed * Time.deltaTime);
    }

    private void OnMouseDown()
    {
        boostSpeed = 3f;
    }
}
