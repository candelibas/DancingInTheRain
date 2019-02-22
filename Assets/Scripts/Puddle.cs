using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puddle : MonoBehaviour
{
    [SerializeField]
    private GameObject subTarget;

    [SerializeField]
    private GameObject particleEffect;

    private void OnMouseDown()
    {
        if(subTarget == null) // small puddle
        {
            gameObject.SetActive(false);

            // bomb the particle effect!
            Instantiate(particleEffect, transform.position, Quaternion.identity);
            // todo: play sound
        }
        else // big & medium puddles
        {
            gameObject.SetActive(false);
            subTarget.SetActive(true);
        }
    }
}
