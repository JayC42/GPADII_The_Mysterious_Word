using System.Net.Mime;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerHP : MonoBehaviour
{
    public float health;
    public Slider slider;
    public TMP_Text hpText; 
    private int fall_damage = 10;
    private int wrongOrb_damage = 15;
    private int wrongBtn_damage = 25; 
    public static bool hurt = false;
    //public AudioClip[] sfx;

    public GameObject Losepanel;

    void Start()
    {
        
    }
    void Update()
    {
        slider.value = health;
        hpText.text = "Health : " + health; 

        /* Level 2: Damage punishment for incorrect Orb placed on altar */ 
        if(DetectBall.wrongDmg == true)
        {
            Debug.Log("Wrong");
            health = health - wrongOrb_damage;
            DetectBall.wrongDmg = false;
            hurt = true;
        }

        /* Level 3: Damage punishment for incorrect button pressed */
        if (ButtonSwitch.wrongBtn == true)
        {
            Debug.Log("Wrong");
            health = health - wrongBtn_damage;
            ButtonSwitch.wrongBtn = false;
            hurt = true;
        }

        if(health <= 0)
        {
            Losepanel.SetActive(true);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            Time.timeScale = 0f;
        }
    }

    /// <summary>
    /// When player fall into abyss 
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Hazard")
        {
            health = health - fall_damage;
            hurt = true;
        }

        if (other.gameObject.tag == "Enemy")
        {
            health = health - fall_damage;
            hurt = true;
        }
    }

}
