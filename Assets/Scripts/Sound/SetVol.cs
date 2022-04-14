using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetVol : MonoBehaviour
{
    //UI
    //public AudioSource BookOpen, BookClose;

    //Player
<<<<<<< Updated upstream
    public AudioSource hurt, jump;

    // Start is called before the first frame update
    void Start()
    {
      
    }
=======
    //public AudioSource hurt;
    //public AudioSource jump;
    public AudioClip[] sfx; 
    
>>>>>>> Stashed changes

    // Update is called once per frame
    void Update()
    {
        if (PlayerHP.hurt == true)
        {
            //hurt.Play();
            AudioManager.instance.PlaySound(sfx[Random.Range(0, 2)]); 

            PlayerHP.hurt = false;
        }
<<<<<<< Updated upstream
=======
        
        if (Movement.walkSound == true)
        {
            //walk.Play();
            AudioManager.instance.PlaySound(sfx[3]);
            Movement.walkSound = false;
        }
>>>>>>> Stashed changes

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
