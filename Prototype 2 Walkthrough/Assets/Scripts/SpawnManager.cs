/*
 * Sarahi Murillo
 * SpawnManager.cs
 * Prototype 2 Walkthrough
 * Animals spawn randomly 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Drag the prefabs to spawn onto this array in the inspector 
    public GameObject[] prefabsToSpawn;

    //variables for spawn position 
    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 20;

    public HealthSystem healthsystem;

    void Start()
    {
        //get reference to the health system script

        healthsystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();

        // InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);
        StartCoroutine(SpawnRandomPrefabWithCouroutine());
    }

    IEnumerator SpawnRandomPrefabWithCouroutine()
    {
        //add 3 secod delay b4 first spawning objects
        yield return new WaitForSeconds(3f);

        while(!healthsystem.gameOver)
        {
            SpawnRandomPrefab();

            float randomDelay = Random.Range(0.8f, 3.0f);

            yield return new WaitForSeconds(randomDelay);

        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {

            //SpawnRandomPrefab();

        }
    }

    void SpawnRandomPrefab()
    {
        //Step 2:
        //Pick random index between 0 and the length of the array
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        //generate spawn pos
        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

        //Spawn 
        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }
}
