using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBulb : MonoBehaviour
{
    public bool isOpen = false;
    public Animator animator;
    public Platform matching_platform = null;

    public void OpenChest()
    {
        if (!isOpen)
        {
            isOpen = true;
            animator.SetBool("isOpen", isOpen);
            matching_platform.button = true;
            SoundMangerScript.PlaySound("buttonPress");
        }
    }

    public void CloseChest()
    {
        if (isOpen)
        {
            isOpen = false;
            animator.SetBool("isOpen", isOpen);
            matching_platform.button = false;
        }
    }
}
