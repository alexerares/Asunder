using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasPipe : MonoBehaviour
{
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
        if (collision.tag == "Sparky")
        {
            SoundMangerScript.PlaySound("gasPipe");
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 15, 0);
        }
    }
}
