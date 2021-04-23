using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportKey : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Shady")
        {
            Teleportation.StartTeleporterSh = 1;
        }
        if (collision.tag == "Sparky")
        {
            Teleportation.StartTeleporterSp = 1;
        }
    }
}
