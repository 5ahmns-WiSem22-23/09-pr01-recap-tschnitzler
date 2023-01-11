using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowfallBackground : MonoBehaviour
{
    // Drag and drop the snow sprite into this field in the inspector
    public SpriteRenderer snowSprite;

    // The frequency at which snowflakes should be instantiated, in seconds
    public float snowfallFrequency = 0.5f;

    // The speed at which snowflakes should fall, in units per second
    public float snowfallSpeed = 5f;

    // The distance (in units) on the x-axis that the snowflakes should be instantiated within
    public float snowfallDistance = 5f;

    // The lifetime of the snow sprite instances, in seconds
    public float snowfallLifetime = 3f;

    // The time at which the last snowflake was instantiated
    private float lastSnowfallTime;

    // The y position at which the snowflakes should be instantiated
    private float yPos;

    void Start()
    {
        // Store the y position at which the snowflakes should be instantiated
        yPos = 6f;
    }

    void Update()
    {
        // Check if it's time to instantiate a new snowflake
        if (Time.time - lastSnowfallTime > snowfallFrequency)
        {
            // Update the time at which the last snowflake was instantiated
            lastSnowfallTime = Time.time;

            // Instantiate a new snowflake
            SpriteRenderer newSnowSprite = Instantiate(snowSprite, transform);

            // Set the position of the new snowflake
            newSnowSprite.transform.position = new Vector3(Random.Range(-snowfallDistance, snowfallDistance), yPos, 0);

            // Set the velocity of the new snowflake
            newSnowSprite.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -snowfallSpeed);

            // Destroy the new snowflake after the specified lifetime
            Destroy(newSnowSprite.gameObject, snowfallLifetime);
        }
    }
}