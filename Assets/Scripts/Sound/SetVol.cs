using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetVol : MonoBehaviour
{
    //UI
    //public AudioSource BookOpen, BookClose;

    //Player
    public AudioSource hurt, jump;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHP.hurt == true)
        {
            hurt.Play();
            PlayerHP.hurt = false;
        }

        if (Movement.jumpSound == true)
        {
            jump.Play();
            Movement.jumpSound = false;
        }

        //if(OpenBook.openBook == false)
        //{
        //    BookOpen.Play();
        //}
        //else if(OpenBook.openBook == true)
        //{
        //    BookClose.Play();
        //}
    }
}
