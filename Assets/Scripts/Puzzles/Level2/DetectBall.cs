using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBall : MonoBehaviour
{
    public GameObject CorrectBall;
    public GameObject WrongBall1;
    public GameObject WrongBall2;

    public GameObject Door;
    public GameObject goal;

    public static bool wrongDmg = false;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == CorrectBall)
        {
            Door.SetActive(false);
            goal.SetActive(true);
        }

        if (other.gameObject == WrongBall1 || other.gameObject == WrongBall2)
        {
            wrongDmg = true;
        }
    }
}
