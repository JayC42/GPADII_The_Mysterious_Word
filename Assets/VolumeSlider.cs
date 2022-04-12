using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public Slider slider; 
    void Start()
    {
        AudioManager.instance.MasterVolume(slider.value);
        slider.onValueChanged.AddListener(value => AudioManager.instance.MasterVolume(value));
    }

}
