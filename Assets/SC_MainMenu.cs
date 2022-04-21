using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SC_MainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject CreditsMenu;
    public AudioClip[] Sfx; 

    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
    }

    public void StartGameButton()
    {
        AudioManager.instance.PlaySound( Sfx[Random.Range(0, Sfx.Length)] );
        // Play Now Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
        SceneManager.LoadScene("LvlSelectMenu");
    }

    public void OptionButton()
    {
        AudioManager.instance.PlaySound( Sfx[Random.Range(0, Sfx.Length)] );
        SceneManager.LoadScene("Options-menu");
    }

    public void CreditsButton()
    {
        AudioManager.instance.PlaySound( Sfx[Random.Range(0, Sfx.Length)] );

        // Show Credits Menu
        MainMenu.SetActive(false);
        CreditsMenu.SetActive(true);
    }

    public void CloseCreditMenu()
    {
        MainMenu.SetActive(true);
        CreditsMenu.SetActive(false);
    }

    public void MainMenuButton()
    {
        
        // Show Main Menu
        MainMenu.SetActive(true);
        CreditsMenu.SetActive(false);
    }

    public void QuitButton()
    {
        AudioManager.instance.PlaySound( Sfx[Random.Range(0, Sfx.Length)] );

        // Quit Game
        Application.Quit();
    }
}