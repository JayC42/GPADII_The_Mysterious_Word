using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Attach this script to the door designed to be locked 
/// </summary>
public class UnlockDoor : MonoBehaviour
{
    public GameObject toolTip3;
    public GameObject toolTip4;
    public GameObject keyHolder;
    private bool inRange;
    bool canOpen => inRange && Key.obtainedKey == true && Input.GetKeyDown(KeyCode.E); 

    void Start()
    {
        inRange = false; 
        toolTip3.SetActive(false); 
        toolTip4.SetActive(false); 
    }


    void Update()
    {
        if (canOpen)
        {
            Key.usedKey = true; 
            this.gameObject.SetActive(false); 
            keyHolder.SetActive(false);
            toolTip3.SetActive(false);
            toolTip4.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = true;
            if (Key.obtainedKey == true)
                toolTip3.SetActive(true);
            else
                toolTip4.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = false;
            toolTip3.SetActive(false);
            toolTip4.SetActive(false);
        }
    }
}
