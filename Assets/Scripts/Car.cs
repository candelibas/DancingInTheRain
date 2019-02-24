using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float bikeSpeed = 3f;
    private float boostSpeed = 1f;

    [SerializeField]
    private AudioClip sound;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        transform.DOMoveY(transform.position.y + 45, 5).OnComplete(() => {
            Destroy(gameObject);
        });
    }

    void Update()
    {
        
    }
}
