using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float time;


    private void Update()
    {
        time += Time.deltaTime;
        timerText.text = time.ToString("0.0");
    }
}