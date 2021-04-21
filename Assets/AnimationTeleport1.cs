using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTeleport1 : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Teleportation.anim == 1)
        {
            animator.SetBool("TeleportOn", true);
        }
        else
        {
            animator.SetBool("TeleportOn", false);
        }

    }
}
