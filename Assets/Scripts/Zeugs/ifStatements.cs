using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifStatements : MonoBehaviour
{

    int tasksDone = 2;
    // Start is called before the first frame update
    void Start()
    {
        if(5>4)
        {
            Debug.Log("5 ist tatsächlich größer als 4");
        }

        if (3 > 3)
        {
            if(10*2 == 20)
            {
                Debug.Log("beide richtig");
            }
        }
        else
        {
            Debug.Log("Nothing really");
        }
    switch(tasksDone)
        {
            case 0:
                Debug.Log("Bullshit");
                break;
            case 1:
                Debug.Log("mhm");
                break;
            case 2:
                Debug.Log("Good");
                break;
  //          default:
  //              Debug.Log("everything shit");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
