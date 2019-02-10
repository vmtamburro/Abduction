using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOGenerator : MonoBehaviour
{
    public GameObject UFOPrefab;


    public int numberOfUFO = 1;
    public float minimumx = -20f;
    public float maximumx = 20f;
    public float minimumz = -20f;
    public float maximumz = 20f;




    // Use this for initialization
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfUFO; i++)
        {
            spawnPosition.z = Random.Range(minimumz, maximumz);
            spawnPosition.y = 3;
            spawnPosition.x = Random.Range(minimumx, maximumx);
            Instantiate(UFOPrefab, spawnPosition, Quaternion.identity);

        }
    }
}
