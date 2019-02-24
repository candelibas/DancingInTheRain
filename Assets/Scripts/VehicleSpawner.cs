using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class VehicleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] vehiclePrefabs;

    void Start()
    {
        InvokeRepeating("SpawnVehicle", 1f, 5f);
    }

    void SpawnVehicle()
    {
        Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y, 0);
        Instantiate(vehiclePrefabs[Random.Range(0, vehiclePrefabs.Length)], spawnPos, Quaternion.identity);
    }
}
