using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Game : MonoBehaviour
{
    public GameObject option;
    public bool openOption = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && openOption == false)
        {
            option.SetActive(true);
            openOption = true;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            Time.timeScale = 0f;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && openOption == true)
        {
            option.SetActive(false);
            openOption = false;

            Cursor.visible = false;

            Time.timeScale = 1f;
        }
    }
}
