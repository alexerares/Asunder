using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacteble : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Shady")
            animator.SetBool("Destroyed", true);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Shady")
            animator.SetBool("Destroyed", false);
    }
}
