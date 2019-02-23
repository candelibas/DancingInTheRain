using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    //private Vector3 screenPoint;
    //private Vector3 offset;

    public bool clicked = false;
    private bool keepTweening = true;

    private Rigidbody2D rb;

    [SerializeField]
    private Transform targetWay;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(keepTweening)
        {
            transform.DOMoveY(-10, 15).OnComplete(() => {
                Destroy(gameObject);
            });
        }
        
    }

    void OnMouseDown()
    {
        if(keepTweening)
        {
            // todo: add click sound
            transform.DOMoveX(targetWay.transform.position.x, 4);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tag == "Manhole")
        {
            keepTweening = false;
            var colPos = collision.gameObject.transform.position; 
            var newPos = new Vector3(colPos.x, colPos.y, colPos.z);

            transform.DOMove(newPos, 2);
            transform.DOScale(new Vector3(0, 0, 0), 2).OnComplete(() => {
                Destroy(gameObject);
            });
        }
    }

    /* Dragging 
    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        offset =  transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
    */

}
