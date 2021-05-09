using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBulb : MonoBehaviour
{
    public bool isOpen = false;
    public Animator animator;

    public void OpenChest()
    {
        if (!isOpen)
        {
            isOpen = true;
            animator.SetBool("isOpen", isOpen);
        }
    }

    public void CloseChest()
    {
        if (isOpen)
        {
            isOpen = false;
            animator.SetBool("isOpen", isOpen);
        }
    }
}
