using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable_box : MonoBehaviour
{
    public bool isOpen;
    public Animator animator;

    public void OpenChest()
    {
        if (!isOpen)
        {
            isOpen = true;
            Debug.Log("Chest is now open...");
            animator.SetBool("isOpen", isOpen);
        }
    }

    public void CloseChest()
    {
        if (isOpen)
        {
            isOpen = false;
            Debug.Log("Chest is now open...");
            animator.SetBool("isOpen", isOpen);
        }
    }
}
