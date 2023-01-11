using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentSpawner : MonoBehaviour
{
    // Prefab of the first sprite to spawn
    public GameObject spritePrefab1;

    // Prefab of the second sprite to spawn
    public GameObject spritePrefab2;

    // Boundaries of the area where the sprites can spawn
    public float xMin = -10f;
    public float xMax = 10f;
    public float yMin = -4f;
    public float yMax = 4f;

    // How often to spawn a new sprite, in seconds
    public float spawnInterval = 1f;

    void Start()
    {
        SpawnSprite();
    }

    public void SpawnSprite()
    {
        // Choose a random position for the sprite
        float xPos = Random.Range(xMin, xMax);
        float yPos = Random.Range(yMin, yMax);

        // Flip a coin to decide which sprite to spawn
        if (Random.Range(0, 2) == 0)
        {
            // Spawn the first sprite
            GameObject sprite = Instantiate(spritePrefab1, new Vector2(xPos, yPos), Quaternion.identity);
        }
        else
        {
            // Spawn the second sprite
            GameObject sprite = Instantiate(spritePrefab2, new Vector2(xPos, yPos), Quaternion.identity);
        }
    }
}
