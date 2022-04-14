using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerLvl2 : MonoBehaviour
{
    public float timeValue;
    public static TextMeshProUGUI timeText;
    public static TextMeshProUGUI DisplayOnLvl2;
    public static float Lvl2Score;

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
            DisplayOnLvl2.text = timeText.text;

            if (timeValue < 90)
            {
                Lvl2Score = timeValue * 100;
            }
            else if (timeValue >= 90 && timeValue < 180)
            {
                Lvl2Score = timeValue * 45;
            }
            else if (timeValue >= 180)
            {
                Lvl2Score = timeValue * 15;
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
