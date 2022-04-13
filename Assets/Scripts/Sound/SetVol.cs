using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetVol : MonoBehaviour
{
    //UI
    //public AudioSource BookOpen, BookClose;

    //Player
    //public AudioSource hurt;
    //public AudioSource jump;
    public AudioClip[] sfx; 
    

    // Update is called once per frame
    void Update()
    {
        if (PlayerHP.hurt == true)
        {
            //hurt.Play();
            AudioManager.instance.PlaySound(sfx[Random.Range(0, 2)]); 

            PlayerHP.hurt = false;
        }
        
        if (Movement.walkSound == true)
        {
            //walk.Play();
            AudioManager.instance.PlaySound(sfx[3]);
            Movement.walkSound = false;
        }

        if (Movement.jumpSound == true)
        {
            //jump.Play();
            AudioManager.instance.PlaySound(sfx[2]);
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
