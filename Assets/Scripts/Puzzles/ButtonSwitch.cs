using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ButtonSwitch : MonoBehaviour
{
    public GameObject userTxt; 
    public GameObject pressSwitch; 
    public GameObject keyPrefab; 
    public Transform keySpawnLoc; 
    public UnityEvent OnPress;
    //public UnityEvent OnRelease;
    public static bool wrongBtn = false;
    private bool inRange; 

    // Tick in inspector if u want this button to be the correct one
    [SerializeField] private bool correctBtn;
    //GameObject presser;
    public AudioSource source;
    public AudioClip[] sfx;
    

    void Start()
    {
        source = GetComponent<AudioSource>();
        inRange = false; 
        userTxt.SetActive(false); 
    }

    void Update()
    {
        // if (inRange && Input.GetMouseButtonDown(0))
        // {
        //     StartCoroutine(SpawnKey()); 
        // }
        
    }
  
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("is Range");

        if (other.gameObject.CompareTag("Player"))
        {
            userTxt.SetActive(true); 
            inRange = true;

            if (Input.GetMouseButtonDown(0))
            {
                StartButtonPress();
                //OnPress.Invoke();
            }
            
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = false;
            userTxt.SetActive(false); 
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
        pressSwitch.transform.localPosition = new Vector3(0, -0.94f, 0); 
        yield return new WaitForSeconds(3f); 
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
        yield return new WaitForSeconds(3f); 
        //source.clip = sfx[];
        source.PlayOneShot(sfx[0]); 
        source.PlayOneShot(sfx[1]); 
        GameObject key = Instantiate(keyPrefab) as GameObject; 
        key.transform.position = keySpawnLoc.position; 
    }

    IEnumerator SendDamage()
    {
        yield return new WaitForSeconds(3f); 
        source.PlayOneShot(sfx[2]); 
        source.PlayOneShot(sfx[3]); 
        wrongBtn = true;
    }
}
