using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup_Sparky : MonoBehaviour
{
    public GameObject text;
    public GameObject trigger;
    public bool Sparky = false;
    public bool Shady = false;
    public bool keep_text = true;
    private bool activate = true;

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
        if ((collision.tag == "Sparky" && Sparky) || (collision.tag == "Shady" && Shady))
        {
            if(activate)
                text.SetActive(true);
            else
                text.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if ((collision.tag == "Sparky" && Sparky) || (collision.tag == "Shady" && Shady))
        {
            text.SetActive(false);
            if(!keep_text)
                activate = false;
        }
    }

}
