using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puddle : MonoBehaviour
{
    [SerializeField]
    private GameObject subTarget;

    [SerializeField]
    private GameObject particleEffect;

    [SerializeField]
    private AudioClip explosionSound;
    [SerializeField]
    private AudioClip puddleClickSound;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        if(subTarget == null) // small puddle
        {
            // bomb the particle effect!
            Instantiate(particleEffect, transform.position, Quaternion.identity);

            gameObject.SetActive(false);
            
            
        }
        else // big & medium puddles
        {
            gameObject.SetActive(false);
            subTarget.SetActive(true);
        }
    }

    private void OnDisable()
    {   
        if(subTarget == null)
        {
            audioSource.PlayOneShot(explosionSound, 1f);
        }
        else
        {
            audioSource.PlayOneShot(puddleClickSound, 1f);
        }
    }

}
