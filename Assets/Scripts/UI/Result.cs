using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Result : MonoBehaviour
{
    public TextMeshProUGUI Lvl1TimeTakenText, Lvl2TimeTakenText, Lvl3TimeTakenText, Lvl1ScoreText, Lvl2ScoreText, Lvl3ScoreText, TotalScoreText;
    private float Lvl1Score, Lvl2Score, Lvl3Score, TotalScore;


    // Update is called once per frame
    private void Start()
    {
        //Lvl1TimeTakenText.text = Countdown.DisplayOnLvl1.text;
        //Lvl2TimeTakenText.text = TimerLvl2.DisplayOnLvl2.text;
        //Lvl3TimeTakenText.text = TimerLvl3.DisplayOnLvl3.text;

        TotalScore = Countdown.Lvl1Score + TimerLvl2.Lvl2Score + TimerLvl3.Lvl3Score;

        Lvl1ScoreText.text = Countdown.Lvl1Score.ToString();
        Lvl2ScoreText.text = TimerLvl2.Lvl2Score.ToString();
        Lvl3ScoreText.text = TimerLvl3.Lvl3Score.ToString();
        TotalScoreText.text = TotalScore.ToString();

    }

    public void GoHome()
    {
        SceneManager.LoadScene("Main-menu");
    }
}
