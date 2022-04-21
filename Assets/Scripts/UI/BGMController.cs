using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour
{
    public static BGMController instance;
    private AudioSource audiosource;

    public static float volume = 1f;


    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        audiosource.volume = volume;

    }

    public void SetVolume(float vol)
    {
        volume = vol;
    }

    public void ToggleMusic()
    {
        audiosource.mute = !audiosource.mute;
    }
}
