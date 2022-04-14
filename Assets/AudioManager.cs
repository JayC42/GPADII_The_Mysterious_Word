using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource musicSource, sfxSource;

    private void Awake()
    {
        //if we dont have audio manager in scene then transfer the audio manager to next scene
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else//but if we have one in scene just destroy it to avoid have 2 audio manager in scene
        {
            Destroy(gameObject);
        }
        
    }


    public void PlayMusic(AudioClip clip)
    {
        musicSource.Play();
    }

    public void PlaySound(AudioClip clip)
    {
        if (sfxSource.isPlaying == false)
        {
            sfxSource.PlayOneShot(clip); 
        }
    }

    public void MasterVolume(float value)
    {
        AudioListener.volume = value;
    }

    public void ToggleSFX()
    {
        sfxSource.mute = !sfxSource.mute; 
    }
    public void ToggleMusic()
    {
        musicSource.mute = !musicSource.mute; 
    }

    public void GoHome()
    {
        SceneManager.LoadScene("Main-menu");
    }

}
