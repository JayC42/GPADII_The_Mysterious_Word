using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LosePanel : MonoBehaviour
{
    //public int indexNumber;

    //public void LosetheLevel()
    //{
    //    SceneManager.LoadScene(indexNumber);
    //}

    public void GoHome()
    {
        SceneManager.LoadScene("Main-menu");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("LvlSelectMenu");
    }
}
