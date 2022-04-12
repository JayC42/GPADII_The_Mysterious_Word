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
    private bool isCorrect; 
    private bool canPress => inRange && Input.GetMouseButtonDown(0);

    // Convert to use AudioManager
    [SerializeField] private AudioClip[] sfx;

    void Start()
    {
        inRange = false; 
        isCorrect = false; 
        ToolTip1.SetActive(false); 
        key.SetActive(false); 

    }

    void Update()
    {
        if (canPress)
        {
            Debug.Log("Mouse click");
            if(!isCorrect)
                StartButtonPress();
        }
        
    }
  
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("is Range");

        if (other.gameObject.CompareTag("Player"))
        {
            if(!isCorrect)
            {
                inRange = true;
                ToolTip1.SetActive(true); 
            }
        
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(!isCorrect)
            {
                inRange = false;
                ToolTip1.SetActive(false); 
            }
             
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
        
        AudioManager.instance.PlaySound(sfx[0]);
        pressSwitch.transform.localPosition = new Vector3(0, 0.7f, 0); 
        yield return new WaitForSeconds(2f); 
        pressSwitch.transform.localPosition = new Vector3(0, 1.5f, 0); 

        if (correctBtn == true)
        {
            StartSpawnKey();   
            isCorrect = true; 
        }
        else 
        {
            StartSendDamage();
        }
    }
    IEnumerator SpawnKey()
    {
        AudioManager.instance.PlaySound(sfx[4]); 
        yield return new WaitForSeconds(2f); 
        AudioManager.instance.PlaySound(sfx[1]); 

        // Key appears 
        key.SetActive(true); 
    }

    IEnumerator SendDamage()
    {
        AudioManager.instance.PlaySound(sfx[2]); 
        yield return new WaitForSeconds(1f); 
        AudioManager.instance.PlaySound(sfx[3]); 
        wrongBtn = true;
    }
}
