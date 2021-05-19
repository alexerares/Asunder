using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMangerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip jumpSparky, jumpShady, pushBox, gasPipe, spring, buttonPress, teleport;
    static AudioSource audioSrc;
    void Start()
    {
        jumpSparky = Resources.Load<AudioClip>("JumpSparky");
        jumpShady = Resources.Load<AudioClip>("JumpShady");
        gasPipe = Resources.Load<AudioClip>("GasPipe");
        spring = Resources.Load<AudioClip>("Spring");
        buttonPress = Resources.Load<AudioClip>("ButtonPress");
        teleport = Resources.Load<AudioClip>("Teleport");
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
            case "jumpSparky":
                audioSrc.PlayOneShot(jumpSparky);
                break;
            case "jumpShady":
                audioSrc.PlayOneShot(jumpShady);
                break;
            case "gasPipe":
                audioSrc.PlayOneShot(gasPipe);
                break;
            case "spring":
                audioSrc.PlayOneShot(spring);
                break;
            case "buttonPress":
                audioSrc.PlayOneShot(buttonPress);
                break;
            case "teleport":
                audioSrc.PlayOneShot(teleport);
                break;
        }
    }
}
