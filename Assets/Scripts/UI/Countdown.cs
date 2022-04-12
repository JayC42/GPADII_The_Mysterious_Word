using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
    public float timeValue;
    public static TextMeshProUGUI timeText;
    public static TextMeshProUGUI DisplayOnLvl1;
    public static float Lvl1Score; 


    // Update is called once per frame

    void Start()
    {
        timeValue = 0;
    }

    void Update()
    {       
        timeValue += Time.deltaTime;        

        DisplayTime(timeValue);      

        if(TouchEndPoint.touchEndPoint)
        {
            DisplayOnLvl1.text = timeText.text;

            if(timeValue < 90)
            {
                Lvl1Score = timeValue * 100;
            }
            else if(timeValue >= 90 && timeValue < 180)
            {
                Lvl1Score = timeValue * 45;
            }
            else if (timeValue >= 180)
            {
                Lvl1Score = timeValue * 15;
            }
        }

    }

    void DisplayTime(float time)
    {
        if(time < 0)
        {
            time = 0;
        }

        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
