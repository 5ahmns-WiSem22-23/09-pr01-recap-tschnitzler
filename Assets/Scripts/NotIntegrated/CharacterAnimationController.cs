using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowfall : MonoBehaviour
{
    public GameObject snowflakePrefab;
    public float snowflakeFrequency = 0.5f;
    public float snowflakeSpeed = 5f;

    private float lastSnowflakeTime;

    void Update()
    {
        if (Time.time - lastSnowflakeTime > snowflakeFrequency)
        {
            lastSnowflakeTime = Time.time;

            GameObject snowflake = Instantiate(snowflakePrefab, transform.position, Quaternion.identity);
            Rigidbody2D rb = snowflake.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(0, -snowflakeSpeed);
        }
    }
}