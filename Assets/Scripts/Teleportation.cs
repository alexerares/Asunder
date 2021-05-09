using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public GameObject player;
    public GameObject player2;
    public GameObject portal;
    public GameObject portal1;
    public GameObject trigger;
    public static int StartTeleporterSh = 0;
    public static int StartTeleporterSp = 0;
    public static int anim = 0;
    public static int on = 0;
    int i = 0;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i--;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.tag == "Shady" && Teleportation.StartTeleporterSh == 1 && Teleportation.on == 1)
        {
            Teleportation.StartTeleporterSh = 0;
            animator.SetBool("TeleportOn", true);
            portal.GetComponent<Animator>().SetBool("TeleportOn", true);
            Teleportation.anim = 1;
            StartCoroutine(Teleport());
            StartCoroutine(Teleport21());
            Teleportation.on = 0;
        }

        if (collision.gameObject.tag == "Sparky" && Teleportation.StartTeleporterSp == 1 && Teleportation.on == 1)
        {
            Teleportation.StartTeleporterSp = 0;
            animator.SetBool("TeleportOn", true);
            portal.GetComponent<Animator>().SetBool("TeleportOn", true);
            Teleportation.anim = 1;
            StartCoroutine(Teleport2());
            StartCoroutine(Teleport1());
            Teleportation.on = 0;
        }

    }


    IEnumerator Teleport()
    {
        yield return new WaitForSeconds(3);
        player.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
        animator.SetBool("TeleportOn", false);
        portal.GetComponent<Animator>().SetBool("TeleportOn", false);
        Teleportation.anim = 0;
    }

    IEnumerator Teleport1()
    {
        yield return new WaitForSeconds(3);
        player.transform.position = new Vector2(portal1.transform.position.x, portal1.transform.position.y);
    }

    IEnumerator Teleport2()
    {
        yield return new WaitForSeconds(3);
        player2.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
        animator.SetBool("TeleportOn", false);
        portal.GetComponent<Animator>().SetBool("TeleportOn", false);
        Teleportation.anim = 0;
    }

    IEnumerator Teleport21()
    {
        yield return new WaitForSeconds(3);
        player2.transform.position = new Vector2(portal1.transform.position.x, portal1.transform.position.y);
    }

}
