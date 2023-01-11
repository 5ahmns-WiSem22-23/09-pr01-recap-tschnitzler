using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    private PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerMovement.speed = 8;
            GetComponent<SpriteRenderer>().sprite = null;
            StartCoroutine(ResetSpeed());
        }
    }

    IEnumerator ResetSpeed()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(3);

        // Change the player's speed back to 5
        playerMovement.speed = 5f;
        print("Bullshit");

        // Wait until the end of the frame before destroying the game object
        yield return null;

        Destroy(gameObject);
    }
}
