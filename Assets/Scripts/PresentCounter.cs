using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PresentCounter : MonoBehaviour
{
    public static PresentCounter instance;

    public TMP_Text presentText;
    public int currentPresents = 0;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        presentText.text = "PRESENTS: " + currentPresents.ToString();
    }


     
    public void IncreasePresents(int v)
    {
        currentPresents += v;
        presentText.text = "PRESENTS: " + currentPresents.ToString();
    }
}