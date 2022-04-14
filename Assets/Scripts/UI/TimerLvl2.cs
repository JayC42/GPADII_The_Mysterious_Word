﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerLvl2 : MonoBehaviour
{
    public float timeValue;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI DisplayMarkLvl2;
    public static int Lvl2Score;

    // Update is called once per frame

    void Start()
    {
        timeValue = 0;
    }

    void Update()
    {
        timeValue += Time.deltaTime;

        DisplayTime(timeValue);

        if (TouchEndPoint.touchEndPoint)
        {
            
            if (timeValue < 90)
            {
                Lvl2Score = (int)timeValue * 900;
            }
            else if (timeValue >= 90 && timeValue < 180)
            {
                Lvl2Score = (int)timeValue * 450;
            }
            else if (timeValue >= 180)
            {
                Lvl2Score = (int)timeValue * 150;
            }

            DisplayMarkLvl2.text = Lvl2Score.ToString();
        }

    }

    void DisplayTime(float time)
    {
        if (time < 0)
        {
            time = 0;
        }

        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
