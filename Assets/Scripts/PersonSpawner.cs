using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] personPrefabs;

    void Start()
    {
        if(personPrefabs == null)
        {
            personPrefabs = GameObject.FindGameObjectsWithTag("Person");
        }
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "SpawnPoint")
        {
            GameObject newPerson = personPrefabs[Random.Range(0, personPrefabs.Length)];

            var colPos = collision.transform.position;
            Vector3 newPos = new Vector3(colPos.x, colPos.y, 0);
            Instantiate(newPerson, newPos, collision.gameObject.transform.rotation);
            
        }
    }
}
