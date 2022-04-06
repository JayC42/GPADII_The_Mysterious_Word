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
    private int damage = 5;
    public static bool hurt = false;

    void Start()
    {
        
    }
    void Update()
    {
        slider.value = health;
        hpText.text = "Health : " + health; 

        if(DetectBall.wrongDmg == true)
        {
            Debug.Log("Wrong");
            health = health - damage;
            DetectBall.wrongDmg = false;
            hurt = true;
        }
    }


    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Hazard")
        {
            health = health - damage;
            hurt = true;
        }
    }

}
