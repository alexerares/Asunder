using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spring : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 10f;
    public float jumpSpeed = 1000;
    public Animator animator;
    public bool has_velocity = false;
    public bool reset = false;
    public GameObject shady;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (has_velocity)
        {
            shady.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 20, 0);
        }
        if (reset)
        {
            animator.SetBool("Jump", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Shady")
        {
            animator.SetBool("Jump", true);
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
