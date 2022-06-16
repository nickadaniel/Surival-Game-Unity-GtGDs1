using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Chapter1{
public class Spawner : MonoBehaviour
{

    public GameObject objectToSpawn;
    public int numberOfEnemies;
    private float spawnRadius = 5;
    private Vector3 spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject(){
        for(int i = 0;i < numberOfEnemies;i++)
        {
            spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
        }
    }

}

}
