using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    public Vector3 spawnPos;
    public int startDelay = 2;
    public float repeatTime = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalTop", startDelay, repeatTime);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay, repeatTime);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay, repeatTime);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimalTop()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        spawnPos = new Vector3(Random.Range(-10, 10), 0, 39);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalRight()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        spawnPos = new Vector3(22, 0, Random.Range(-3, 50));
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation * Quaternion.AngleAxis(90, Vector3.up));
    }

    void SpawnRandomAnimalLeft()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        spawnPos = new Vector3(-22, 0, Random.Range(-3, 50));
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation * Quaternion.AngleAxis(-90, Vector3.up));
    }
}
