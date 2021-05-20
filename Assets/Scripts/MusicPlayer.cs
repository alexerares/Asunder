using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource AudioSource;
    public Slider slider;
    private float musicVolume = 0.25f;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.volume = PlayerPrefs.GetFloat("musicVolume", 0.25f);
        slider.value = PlayerPrefs.GetFloat("slider", slider.value);
    }

    public void updateVolume(float volume)
    {
        PlayerPrefs.SetFloat("musicVolume", volume / 4);
        PlayerPrefs.SetFloat("slider", slider.value);
    }
}