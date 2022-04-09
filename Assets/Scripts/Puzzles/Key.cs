using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Key : MonoBehaviour
{
    public AudioSource source;
    public GameObject toolTip2;
    public GameObject keyHolder;
    public static bool obtainedKey;
    public static bool usedKey;
    private bool inRange;

    void Start()
    {
        inRange = false; 
        obtainedKey = false;
        usedKey = false;
        toolTip2.SetActive(false); 
        keyHolder.SetActive(false); 
    }


    void Update()
    {
        // Rotate key
        gameObject.transform.Rotate(-90f * Time.deltaTime, 0, 0);

        // Play some particle fx

        // Picked up key 
        if (inRange && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Key in range!");
            obtainedKey = true; 
            this.gameObject.SetActive(false); 
            toolTip2.SetActive(false); 
        }

        if (obtainedKey)
        {
            // show key icon on player UI 
            keyHolder.SetActive(true); 
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = true;
            toolTip2.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = false;
            toolTip2.SetActive(false);
        }
    }
}
