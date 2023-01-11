using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterSpawner : MonoBehaviour
{
    // Prefab of the first sprite to spawn
    public GameObject spritePrefab;

    // Boundaries of the area where the sprites can spawn
    public float xMin = -10f;
    public float xMax = 10f;
    public float yMin = -4f;
    public float yMax = 4f;

    // How often to spawn a new sprite, in seconds
    public float spawnInterval = 5f;

    void Start()
    {
        // Start spawning sprites at the specified interval
        InvokeRepeating("SpawnSprite", spawnInterval, spawnInterval);
    }

    void SpawnSprite()
    {
        // Choose a random position for the sprite
        float xPos = Random.Range(xMin, xMax);
        float yPos = Random.Range(yMin, yMax);

        GameObject sprite = Instantiate(spritePrefab, new Vector2(xPos, yPos), Quaternion.identity);
    }
}
