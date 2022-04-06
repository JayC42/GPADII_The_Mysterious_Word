using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TouchEndPoint : MonoBehaviour
{
    public GameObject Passpanel;
    public static bool touchEndPoint;

    private void Start()
    {
        touchEndPoint = false;
        Passpanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            touchEndPoint = true;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            Time.timeScale = 0f;
            int currentlevel = SceneManager.GetActiveScene().buildIndex;

            if (currentlevel >= PlayerPrefs.GetInt("levelUnlocked"))
            {
                PlayerPrefs.SetInt("levelUnlocked", currentlevel);
            }

            Passpanel.SetActive(true);
        }
    }
}
