using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManholeCover : MonoBehaviour
{

    [SerializeField]
    private GameObject targetManhole;

    public float timeToComplete = 1f;

    [SerializeField]
    private AudioClip dragSound;
    AudioSource audioSource;
    [SerializeField]
    private AudioClip fitSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        audioSource.PlayOneShot(dragSound, 1f);

        transform.DOMoveX(targetManhole.transform.position.x, timeToComplete).OnComplete(() => {
            targetManhole.SetActive(false);
            audioSource.PlayOneShot(fitSound, 1f);
        });
    }

}
