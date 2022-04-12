using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PresurePlateUnlock : MonoBehaviour
{
    public GameObject lastDoor; 
    bool isStandingOnPlate; 
    bool isOpen; 
    void Start()
    {
        isStandingOnPlate = false; 
        isOpen = false; 
    }
    void OnTriggerEnter(Collider other)
    {
        
        if (isStandingOnPlate == false && other.gameObject.CompareTag("Player"))
        {
            // Trigger switch ON -> start Countdown Timer 
            // Door stays open during time duration & close after timer ends
            isOpen = true; 
            //print("pressureplate entered!");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isStandingOnPlate = false;

            StartCoroutine(UnlockDoor()); 
            StartCoroutine(LockDoor());
        }
    }

    IEnumerator UnlockDoor()
    {
        if(isOpen) 
        { 
            lastDoor.SetActive(false); 
        }
        //print("Door to Exit Unlocked!");  

        // Play ticking time sfx 
        //udioManager.instance.PlaySFX(0);
        yield return new WaitForSeconds(10f);

        //close door after time up
        isOpen = false; 
    }

    IEnumerator LockDoor()
    {
        yield return new WaitUntil(() => isOpen == false);
        // close door
        lastDoor.SetActive(true);  
    }
}
