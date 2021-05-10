using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTeleport : MonoBehaviour
{
    public GameObject player;
    public GameObject player2;
    bool ver;
    bool ver1;
    bool ver2;
    bool ver3;
    bool ver4;
    bool ver5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ver = transform.GetChild(0).GetComponent<InRangeOfTeleportation>().isInRange;
        ver1 = transform.GetChild(1).GetComponent<InRangeOfTeleportation>().isInRange;
        ver2 = transform.GetChild(0).transform.GetChild(0).GetComponent<TeleportKey>().turnontele;
        ver3 = transform.GetChild(0).transform.GetChild(1).GetComponent<TeleportKey>().turnontele;
        ver4 = transform.GetChild(1).transform.GetChild(0).GetComponent<TeleportKey>().turnontele;
        ver5 = transform.GetChild(1).transform.GetChild(1).GetComponent<TeleportKey>().turnontele;
        SomeoneIsOntp();
    }
    public void SomeoneIsOntp()
    {
        if(ver || ver1)
        {
            transform.GetChild(0).GetComponent<InRangeOfTeleportation>().animator.SetBool("OnTp", true);
            transform.GetChild(1).GetComponent<InRangeOfTeleportation>().animator.SetBool("OnTp", true);
        }
        
        if(!ver && !ver1)
        {
            transform.GetChild(0).GetComponent<InRangeOfTeleportation>().animator.SetBool("OnTp", false);
            transform.GetChild(1).GetComponent<InRangeOfTeleportation>().animator.SetBool("OnTp", false);
        }

        if(ver && ver1 && (ver2 || ver3) && (ver4 || ver5))
        {
            transform.GetChild(0).transform.GetChild(0).GetComponent<TeleportKey>().turnontele = false;
            transform.GetChild(0).transform.GetChild(1).GetComponent<TeleportKey>().turnontele = false;
            transform.GetChild(1).transform.GetChild(0).GetComponent<TeleportKey>().turnontele = false;
            transform.GetChild(1).transform.GetChild(1).GetComponent<TeleportKey>().turnontele = false;
            transform.GetChild(0).GetComponent<InRangeOfTeleportation>().animator.SetBool("TeleportOn", true);
            transform.GetChild(1).GetComponent<InRangeOfTeleportation>().animator.SetBool("TeleportOn", true);
            player.gameObject.GetComponent<MovementShady>().canMove = false;
            player2.gameObject.GetComponent<PlayerMovement>().canMove = false;
            StartCoroutine(Teleport1());
        }
    }

    IEnumerator Teleport1()
    {
        yield return new WaitForSeconds(3);
        float xpos = player.transform.position.x;
        float ypos = player.transform.position.y;
        transform.GetChild(0).GetComponent<InRangeOfTeleportation>().animator.SetBool("TeleportOn", false);
        transform.GetChild(1).GetComponent<InRangeOfTeleportation>().animator.SetBool("TeleportOn", false);
        player.transform.position = new Vector2(player2.transform.position.x, player2.transform.position.y);
        player2.transform.position = new Vector2(xpos, ypos);
        player.gameObject.GetComponent<MovementShady>().canMove = true;
        player2.gameObject.GetComponent<PlayerMovement>().canMove = true;
    }
}
