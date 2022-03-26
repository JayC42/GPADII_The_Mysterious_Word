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

    void Start()
    {
        
    }
    void Update()
    {
        slider.value = health;
        hpText.text = "Health : " + health; 
    }


    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Hazard")
        {
            health = health - damage; 
        }
    }

}
