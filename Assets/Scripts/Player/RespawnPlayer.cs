using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    [SerializeField] public Transform player;
    [SerializeField] public Transform respawnPoint; 
    
    void OnTriggerEnter(Collider other) 
    {
        // Also need to add condition to check if player is still alive!
        if(other.CompareTag ("Player"))
        {
            player.transform.position = respawnPoint.transform.position; 
            Physics.SyncTransforms();
            Debug.Log("Respawn");
        }
    }

    // Might need to send damage to player too
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
