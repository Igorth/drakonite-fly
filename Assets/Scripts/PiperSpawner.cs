using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiperSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2f;
    private float timer = 0f;
    public float heightOffset = 10f;

    private void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float lowestPosition = transform.position.y - heightOffset;
        float highestPosition = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x,
            Random.Range(lowestPosition, highestPosition), 0), transform.rotation);
    }
}
