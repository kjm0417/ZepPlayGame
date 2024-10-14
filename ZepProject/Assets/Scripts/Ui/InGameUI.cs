using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{
    public Text timeText;
   

    // Update is called once per frame
    void Update()
    {
        CurrentDate();
    }

    public void CurrentDate()
    {
        string currentTime = DateTime.Now.ToString("HH : mm");
        timeText.text = currentTime;
    }
}
