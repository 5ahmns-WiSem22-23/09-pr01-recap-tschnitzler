using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Present : MonoBehaviour
{
    public int value;
    private PresentCounter presentCounter;
    private PresentSpawner presentSpawner;

    // Start is called before the first frame update
    void Start()
    {
        presentCounter = FindObjectOfType<PresentCounter>();
        presentSpawner = FindObjectOfType<PresentSpawner>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            transform.SetParent(other.transform);
        }

        if (other.gameObject.CompareTag("Sleigh"))
        {
            presentCounter.IncreasePresents(value);
            presentSpawner.SpawnSprite();
            Destroy(gameObject);
        }
    }

}