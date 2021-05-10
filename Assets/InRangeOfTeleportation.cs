using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InRangeOfTeleportation : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isInRange;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Shady") || collision.gameObject.CompareTag("Sparky"))
        {
            isInRange = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Shady") || collision.gameObject.CompareTag("Sparky"))
        {
            isInRange = false;
        }

    }
}
