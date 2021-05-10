using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportKey : MonoBehaviour
{
    public bool turnontele = false;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Shady" || collision.tag == "Sparky")
        {
            turnontele = true;
        }
    }

}
