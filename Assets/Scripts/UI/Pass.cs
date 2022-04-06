using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pass : MonoBehaviour
{
    public int indexNumber;

    public void PasstheLevel()
    {
        SceneManager.LoadScene(indexNumber);
    }

    public void GoHome()
    {
        SceneManager.LoadScene("Main-menu");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("LvlSelectMenu");
    }
}
