using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_exit : MonoBehaviour
{
    // Start is called before the first frame update
    public bool sparky = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Sparky")
        {
            //SoundMangerScript.PlaySound("gasPipe");
            sparky = true;
        }   
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Sparky")
        {
            sparky = false;
        }
    }
}
