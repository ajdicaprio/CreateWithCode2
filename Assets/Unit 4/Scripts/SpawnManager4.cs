using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager4 : MonoBehaviour
{
    public GameObject enemyPrefab;
    float spawnRange = 9.0f;
    public int enemyCount;
    public int waveNumber;
    public GameObject powerupPrefab;


    // Start is called before the first frame update
    void Start()
    {
        SpawnenemyWave(waveNumber);
        //Instantiate(powerupPrefab, GenerateSpawnPos(), powerupPrefab.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy4>().Length; 
        //tambien existe FindObjectOfType sin la s

        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnenemyWave(waveNumber);
            Instantiate(powerupPrefab, GenerateSpawnPos(), powerupPrefab.transform.rotation);

        }

    }

    private Vector3 GenerateSpawnPos()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;

    }

    private void SpawnenemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPos(), enemyPrefab.transform.rotation);

        }
    }
}
