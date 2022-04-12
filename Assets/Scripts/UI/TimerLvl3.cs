using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerLvl3 : MonoBehaviour
{
    public float timeValue;
    public static TextMeshProUGUI timeText;
    public static TextMeshProUGUI DisplayOnLvl3;
    public static float Lvl3Score;

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
            DisplayOnLvl3.text = timeText.text;

            if (timeValue < 180)
            {
                Lvl3Score = timeValue * 100;
            }
            else if (timeValue >= 180 && timeValue < 300)
            {
                Lvl3Score = timeValue * 45;
            }
            else if (timeValue >= 300)
            {
                Lvl3Score = timeValue * 15;
            }
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
