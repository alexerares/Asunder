using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginTp : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Shady" || collision.tag == "Sparky")
        {
            Teleportation.on = 1;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Shady" || collision.tag == "Sparky")
        {
            Teleportation.on = 0;
        }
    }
}
