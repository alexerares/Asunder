using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenWheelActivate : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isInRange;
    public bool on;
    public KeyCode interactKeyShady;
    public GameObject pipe;
    public Animator animator;
    void Start()
    {
        if (on)
        {
            animator.SetBool("Activate", on);
            pipe.GetComponent<GasPipeGreen>().animator.SetBool("Active", on);
            pipe.transform.GetChild(0).GetComponent<BoxCollider2D>().enabled = on;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKeyShady))
            {
                if (!on)
                {
                    on = true;
                    animator.SetBool("Activate", on);
                    pipe.GetComponent<GasPipeGreen>().animator.SetBool("Active", on);
                    pipe.transform.GetChild(0).GetComponent<BoxCollider2D>().enabled = on;
                }
                else
                {
                    on = false;
                    animator.SetBool("Activate", on);
                    pipe.GetComponent<GasPipeGreen>().animator.SetBool("Active", on);
                    pipe.transform.GetChild(0).GetComponent<BoxCollider2D>().enabled = on;
                }
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Shady"))
        {
            isInRange = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Shady"))
        {
            isInRange = false;
        }

    }
}
