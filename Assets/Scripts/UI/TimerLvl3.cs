using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerLvl3 : MonoBehaviour
{
    public float timeValue;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI DisplayMarkLvl3;
    public static int Lvl3Score;

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
            
            if (timeValue < 120)
            {
                Lvl3Score = (int)timeValue * 900;
            }
            else if (timeValue >= 120 && timeValue < 240)
            {
                Lvl3Score = (int)timeValue * 450;
            }
            else if (timeValue >= 240)
            {
                Lvl3Score = (int)timeValue * 150;
            }

            DisplayMarkLvl3.text = Lvl3Score.ToString();
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
