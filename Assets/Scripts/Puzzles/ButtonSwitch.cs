using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ButtonSwitch : MonoBehaviour
{
    // Tick in inspector if u want this button to be the correct one
    [Header("Button Bool Option")]
    public bool correctBtn;
    public GameObject ToolTip1; 
    public GameObject pressSwitch; 
    public GameObject key; 
    public Transform keySpawnLoc; 
    public static bool wrongBtn = false;
    private bool inRange; 
    public AudioSource source;
    public AudioClip[] sfx;
    

    void Start()
    {
        source = GetComponent<AudioSource>();
        inRange = false; 
        ToolTip1.SetActive(false); 
        key.SetActive(false); 

    }

    void Update()
    {
        if (inRange && Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse click");
            StartButtonPress();
        }
        
    }
  
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("is Range");

        if (other.gameObject.CompareTag("Player"))
        {
            inRange = true;
            ToolTip1.SetActive(true); 
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = false;
            ToolTip1.SetActive(false); 
        }
    }
    public void StartButtonPress()
    {
        StartCoroutine(ButtonPress()); 
    }
    public void StartSpawnKey()
    {
        StartCoroutine(SpawnKey()); 
    }
    public void StartSendDamage()
    {
        StartCoroutine(SendDamage()); 
    }
    IEnumerator ButtonPress()
    {
        source.PlayOneShot(sfx[0]);
        pressSwitch.transform.localPosition = new Vector3(0, 0.7f, 0); 
        yield return new WaitForSeconds(2f); 
        pressSwitch.transform.localPosition = new Vector3(0, 1.5f, 0); 

        if (correctBtn == true)
        {
            StartSpawnKey();    
        }
        else 
        {
            StartSendDamage();
        }
    }
    IEnumerator SpawnKey()
    {
        source.PlayOneShot(sfx[4]); 
        yield return new WaitForSeconds(2f); 
        source.PlayOneShot(sfx[1]); 

        // Key appears 
        key.SetActive(true); 
    }

    IEnumerator SendDamage()
    {
        source.PlayOneShot(sfx[2]); 
        yield return new WaitForSeconds(1f); 
        source.PlayOneShot(sfx[3]); 
        wrongBtn = true;
    }
}
