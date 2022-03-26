using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    public Transform player;
    public Transform respawnPoint; 

    void OnTriggerEnter(Collider other) 
    {
        // Also need to add condition to check if player is still alive!
        if(other.gameObject.name == "Player")
        {
            player.position = respawnPoint.position; 
            Physics.SyncTransforms(); 
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
