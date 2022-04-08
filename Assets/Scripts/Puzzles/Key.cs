using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Key : MonoBehaviour
{
    bool keySpawned;
    void Start()
    {
        keySpawned = true; 
    }

 
    void Update()
    {
        if (keySpawned)
        {
            gameObject.transform.Rotate(0, 0, -90f); 
        }
        // Picked up key & reflect on UI holder 
        if(Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject); 
        }
    }
}
