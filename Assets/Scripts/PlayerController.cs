using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float twirlSpeed = 180f;
    
    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    [SerializeField]
    private AudioClip fallSound;
    AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.Rotate(0, 0, twirlSpeed * Time.deltaTime);

        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        moveVelocity = moveInput.normalized * movementSpeed;
        
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /* Death collision conditions */
        string tag = collision.gameObject.tag;
        // Person
        if (tag == "Person")
        {
            SceneManager.LoadScene(3);
        }
        // Biker
        if (tag == "Biker")
        {
            SceneManager.LoadScene(3);
        }
        // Manhole (not manhole cover)
        if (tag == "Manhole")
        {
            audioSource.PlayOneShot(fallSound, 1f);
            var targetPos = new Vector3(collision.gameObject.transform.position.x, 
            collision.gameObject.transform.position.y, collision.gameObject.transform.position.z);
            transform.DOMove(targetPos, 1);

            var newScale = new Vector3(0, 0, 0);
            twirlSpeed = twirlSpeed * 1.5f;
            transform.DOScale(newScale, 2).OnComplete(() => {
                
                SceneManager.LoadScene(3);
            });
            
        }
        // Cat
        if (tag == "Cat")
        {
            SceneManager.LoadScene(3);
        }
        // Puddle
        if (tag == "Puddle")
        {
            SceneManager.LoadScene(3);
        }
        // Wall
        if (tag == "Wall")
        {
            SceneManager.LoadScene(3);
        }
        // Car
        if(tag == "Car")
        {
            SceneManager.LoadScene(3);
        }
    }
}
