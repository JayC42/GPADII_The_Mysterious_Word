using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    private AudioSource bgm;

    // Start is called before the first frame update
    void Start()
    {
        bgm = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        bgm.volume = BGMController.volume;
    }
}
