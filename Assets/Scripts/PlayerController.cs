using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float twirlSpeed = 180f;
    
    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
            
        }
        // Biker
        if (tag == "Biker")
        {

        }
        // Manhole (not manhole cover)
        if (tag == "Manhole")
        {
            var targetPos = new Vector3(collision.gameObject.transform.position.x, 
            collision.gameObject.transform.position.y, collision.gameObject.transform.position.z);
            transform.DOMove(targetPos, 1);

            var newScale = new Vector3(0, 0, 0);
            twirlSpeed = twirlSpeed * 1.5f;
            transform.DOScale(newScale, 2).OnComplete(() => {

            });
            
        }
        // Cat
        if (tag == "Cat")
        {

        }
        // Puddle
        if (tag == "Puddle")
        {

        }
        // Wall
        if (tag == "Wall")
        {

        }
    }
}
