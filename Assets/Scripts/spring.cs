using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spring : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 10f;
    public float jumpSpeed = 1000;
    public Animator animator;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Shady")
        {
            animator.SetBool("Jump", true);
            collision.collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 35, 0);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Shady")
        {
            // animator.SetBool("Jump", false);
        }
    }
}
