using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenBook : MonoBehaviour
{
    public GameObject book;
    public static bool openBook = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && openBook == false)
        {
            book.SetActive(true);
            openBook = true;
        }
        else if (Input.GetKeyDown(KeyCode.Q) && openBook == true)
        {
            book.SetActive(false);
            openBook = false;
        }
    }
}
