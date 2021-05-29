using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPipeOrizontal : MonoBehaviour
{
    public bool direction = false;
    int velocity;

    // Start is called before the first frame update
    void Start()
    {
        velocity = direction ? 10 : -10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Sparky")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(velocity, 0, 0);
        }
    }
}
