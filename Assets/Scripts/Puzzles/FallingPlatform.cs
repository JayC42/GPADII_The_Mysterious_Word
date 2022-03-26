using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody))]
public class FallingPlatform : MonoBehaviour
{
    [SerializeField] float fallSpeed = 1f; 
    Vector3 origPosition;
    float respawnTime = 3f; 
    bool isFalling = false; 
    
    void Start()
    {
        origPosition = transform.position;
    }

    void Update()
    {
        Fall(); 

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            isFalling = true; 
            StartCoroutine("RespawnPlatform");
        }
    }

    void Fall()
    {
        if(isFalling)
        {
            //gameObject.SetActive(false); 
            fallSpeed += Time.deltaTime / 10;
            transform.position = new Vector3(transform.position.x, transform.position.y-fallSpeed, transform.position.z);
        }
        
    }

    IEnumerator RespawnPlatform()
    {
        yield return new WaitForSeconds(respawnTime);

        print("Respawn called!");
        //gameObject.SetActive(true); 
        transform.position = origPosition; 
        
        isFalling = false; 
    }

}