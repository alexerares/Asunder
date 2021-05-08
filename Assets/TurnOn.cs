using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TurnOn : MonoBehaviour
{
    public bool isInRangeSparky;
    public KeyCode interactKeySparky;
    public UnityEvent interactActionSparky;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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

        if (collision.gameObject.CompareTag("Sparky"))
        {
            isInRangeSparky = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Sparky"))
        {
            isInRangeSparky = false;
        }
    }
}
