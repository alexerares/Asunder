using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator_exit : MonoBehaviour
{
    // Start is called before the first frame update
    public bool shady = false;
    public Animator animator;
    public bool nextlevel = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Shady")
        {
            shady = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Shady")
        {
            shady = false;
        }
    }
}
