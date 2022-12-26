using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject barreraPrefab;
    public GameObject treePrefab;

    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private Vector3 spawnObject = new Vector3(30, 0, -6);
    private float startDelay = 2f;
    private float repeatDelay = 2f;
    private PlayerController3 playerControllerScript;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBarrera", startDelay, repeatDelay);
        InvokeRepeating("SpawnTree", 1f, 5f);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController3>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnBarrera()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(barreraPrefab, spawnPos, barreraPrefab.transform.rotation);
        }
    }

    private void SpawnTree()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(treePrefab, spawnObject, treePrefab.transform.rotation);
        }
    }
}
