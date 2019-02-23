using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biker : MonoBehaviour
{
    public float bikeSpeed = 3f;
    private float boostSpeed = 1f;

    [SerializeField]
    private AudioClip sound;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.Translate(Vector2.up * bikeSpeed * boostSpeed * Time.deltaTime);
    }

    private void OnMouseDown()
    {
        audioSource.PlayOneShot(sound, 1F);
        boostSpeed = 3f;
    }
}
