using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
     public GameObject[] FoodPrefabs;
    private float spawnRangeX = 4f;
    private float spawnPosZ = 4;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 15 , Random.Range(-spawnPosZ, spawnPosZ));
        int animalIndex = Random.Range(0, FoodPrefabs.Length);
        Instantiate(FoodPrefabs[animalIndex],spawnPos, FoodPrefabs[animalIndex].transform.rotation);
    }
}
