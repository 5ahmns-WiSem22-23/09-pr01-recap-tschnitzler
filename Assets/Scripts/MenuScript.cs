using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public GameObject boosterSpawner;
    public GameObject timeManager;
    private void Start()
    {
        playerMovement.enabled = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        playerMovement.enabled = true;
        gameObject.SetActive(false);

        boosterSpawner.SetActive(true);
        timeManager.SetActive(true);

    }

}