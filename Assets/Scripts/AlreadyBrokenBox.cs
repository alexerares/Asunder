using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlreadyBrokenBox : MonoBehaviour
{
    public bool isOpen= false;
    public Animator animator;

    public void OpenChest()
    {
        if (!isOpen)
        {
            isOpen = true;
            Debug.Log("Repairing");
            animator.SetBool("IsOpen", isOpen);
        }
    }

    public void CloseChest()
    {
        if (isOpen)
        {
            isOpen = false;
            Debug.Log("Destroying");
            animator.SetBool("IsOpen", isOpen);
        }
    }
}
