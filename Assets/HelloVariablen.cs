/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloVariablen : MonoBehaviour
{
    //Value Types: Wert wird im Speicher direkt hinterlegt
    int myInt = 0;
    bool mybool =true;


    int[] myArray = new int[3] {0,0,0};
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(sizeof(int));
        Debug.Log(sizeof(bool));

        //Value type
        int tmp = myInt;
        myInt = myInt++;
        Debug.Log("myInt: " + myInt + " tmp " + tmp);
            
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(sizeof(int));
        Debug.Log(sizeof(bool));
    }
}
*/