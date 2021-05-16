using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMangerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip playerSound, jumpShady, pushBox;
    static AudioSource audioSrc;
    void Start()
    {
        playerSound = Resources.Load<AudioClip>("mixkit-evil-dwarf-laugh-421");
        jumpShady = Resources.Load<AudioClip>("look");
        pushBox = Resources.Load<AudioClip>("this bithes can't even spell prague");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "playerSound":
                audioSrc.PlayOneShot(playerSound);
                break;
            case "jumpShady":
                audioSrc.PlayOneShot(jumpShady);
                break;
            case "pushBox":
                audioSrc.PlayOneShot(pushBox);
                break;
        }
    }
}
