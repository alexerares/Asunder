using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BreakebleBox : MonoBehaviour
{
    public bool isInRangeShady;
    public bool isInRangeSparky;
    public KeyCode interactKeyShady;
    public KeyCode interactKeySparky;
    public UnityEvent interactActionShady;
    public UnityEvent interactActionSparky;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRangeShady)
        {
            if (Input.GetKeyDown(interactKeyShady))
            {
                interactActionShady.Invoke();
            }
        }

        if (isInRangeSparky)
        {
            if (Input.GetKeyDown(interactKeySparky))
            {
                interactActionSparky.Invoke();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Shady"))
        {
            isInRangeShady = true;
        }

        if (collision.gameObject.CompareTag("Sparky"))
        {
            isInRangeSparky = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Shady"))
        {
            isInRangeShady = false;
        }

        if (collision.gameObject.CompareTag("Sparky"))
        {
            isInRangeSparky = false;
        }
    }
}
