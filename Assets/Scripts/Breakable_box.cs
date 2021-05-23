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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Platform")
        {
            transform.SetParent(collision.collider.transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Platform")
        {
            transform.SetParent(null);
        }
    }
}
