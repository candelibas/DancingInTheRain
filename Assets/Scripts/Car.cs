using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

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

    private void OnMouseDown()
    {
        audioSource.PlayOneShot(sound, 1f);
    }
}
