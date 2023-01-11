using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 180f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.forward, -rotationSpeed * horizontal * Time.deltaTime);

        Vector3 movement = transform.up * vertical * speed * Time.deltaTime;
        transform.position = transform.position + movement;
    }
}