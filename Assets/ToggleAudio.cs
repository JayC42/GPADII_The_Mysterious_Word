using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAudio : MonoBehaviour
{
    [SerializeField] private bool _toggleMusic, _toggleSfx; 
    public void Toggle()
    {
        if (_toggleSfx) AudioManager.instance.ToggleSFX(); 
        if (_toggleMusic) AudioManager.instance.ToggleMusic(); 

    }

}
