using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    //private Vector3 screenPoint;
    //private Vector3 offset;

    public bool clicked = false;

    [SerializeField]
    private Transform targetWay;

    void Start()
    {
        
    }

    void Update()
    {
        transform.DOMoveY(-10, 15).OnComplete(() => {
            Destroy(gameObject);
        });
    }

    void OnMouseDown()
    {
        transform.DOMoveX(-5, 5);
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
