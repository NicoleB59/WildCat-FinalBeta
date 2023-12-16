using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject coinPrefabs;
    private Vector3 spawnPos = new Vector3(270, 35.3f, -10);
    private float startDelay = 2;
    private float repeatRate = 8;
    public bool gameOver = false;
    private PlayerControls playerControlsScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCoin", startDelay, repeatRate);
        playerControlsScript = GameObject.Find("Cat").GetComponent<PlayerControls>();

    }

    //Fish coin spawns on the provided co-ordinates
    void SpawnCoin()
    {
        if (playerControlsScript.gameOver == false)
        {
            Instantiate(coinPrefabs, spawnPos, coinPrefabs.transform.rotation);
        }
    }
}
