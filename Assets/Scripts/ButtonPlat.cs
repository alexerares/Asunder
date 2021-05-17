using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlat : MonoBehaviour
{
    public Platform matching_platform;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "BoxShady")
        {
            matching_platform.button = true;
            animator.SetBool("Pressed", true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "BoxShady")
        {
            matching_platform.button = false;
            animator.SetBool("Pressed", false);
        }
    }
}
