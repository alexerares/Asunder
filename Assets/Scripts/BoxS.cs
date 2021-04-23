using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxS : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "BoxS")
        {
            _rigidbody.isKinematic = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BoxS")
        {
            _rigidbody.isKinematic = false;
        }
    }
}
