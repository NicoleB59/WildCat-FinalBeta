using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject binPrefabs;
    public GameObject gekkoPrefabs;
    private Vector3 spawnPos = new Vector3(235, 2.3f, -10);
    private float startDelay = 2; 
    private float repeatRate = 8;
    public bool gameOver = false;
    private PlayerControls playerControlsScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControlsScript = GameObject.Find("Cat").GetComponent<PlayerControls>();

    }

    //This method creates a spawn spot for the bin and the gecko
    void SpawnObstacle()
    {
        if(playerControlsScript.gameOver == false)
        {
            Instantiate(binPrefabs, spawnPos, binPrefabs.transform.rotation);
            Instantiate(gekkoPrefabs, spawnPos, gekkoPrefabs.transform.rotation);
        }
    }
}
