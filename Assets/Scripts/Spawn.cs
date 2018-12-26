using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{


    public GameObject[] platforms;
    public float feildSize;
    int waitTime = 0;
    public float SpawnFrequency;
    float SpawnTime;

    private void Start()
    {
        SpawnTime = SpawnFrequency;
    }

    void Update()
    {
        waitTime++;
        if (waitTime > SpawnTime)
        {
            waitTime = 0;
            SpawnTime = Random.Range((SpawnFrequency - SpawnFrequency * 0.1f), (SpawnFrequency + SpawnFrequency * 0.1f));
            Instantiate(platforms[Random.Range(0, platforms.Length)], new Vector2(transform.position.x + Random.Range(-feildSize, feildSize), transform.position.y), Quaternion.identity);
        }
    }
}
