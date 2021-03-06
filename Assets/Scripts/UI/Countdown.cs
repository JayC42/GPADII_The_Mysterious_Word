using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
    public float timeValue;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI DisplayMarkLvl1;
    public static int Lvl1Score;

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

            Lvl1Score = 1000000 / (int)timeValue;
            
            DisplayMarkLvl1.text = Lvl1Score.ToString();
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
