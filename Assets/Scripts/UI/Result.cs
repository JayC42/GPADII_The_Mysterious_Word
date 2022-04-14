using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Result : MonoBehaviour
{
    public TextMeshProUGUI Lvl1TimeTaken, Lvl2TimeTaken, Lvl3TimeTaken;
    public TextMeshProUGUI Lvl1Score, Lvl2Score, Lvl3Score, TotalScore;
    private float Lvl1, Lvl2, Lvl3, TS;

    // Update is called once per frame
    void Update()
    {
        Lvl1 = Countdown.Lvl1Score;
        Lvl2 = TimerLvl2.Lvl2Score;
        Lvl3 = TimerLvl3.Lvl3Score;

        TS = Lvl1 + Lvl2 + Lvl3;

        Lvl1TimeTaken.text = Countdown.DisplayOnLvl1.text;
        Lvl2TimeTaken.text = TimerLvl2.DisplayOnLvl2.text;
        Lvl3TimeTaken.text = TimerLvl3.DisplayOnLvl3.text;


        Lvl1Score.text = Countdown.Lvl1Score.ToString();
        Lvl2Score.text = TimerLvl2.Lvl2Score.ToString();
        Lvl3Score.text = TimerLvl3.Lvl3Score.ToString();
        TotalScore.text = TS.ToString();   
    }

    public void GoHome()
    {
        SceneManager.LoadScene("Main-menu");
    }
}
