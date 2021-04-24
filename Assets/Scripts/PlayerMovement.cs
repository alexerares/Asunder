using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 7;
    public float JumpForce = 7;

    public bool isGrounded = false;
    public Animator animator;

    private Rigidbody2D _rigidbody;
    float translate = 0;

    bool facingRight;

    int i = 0;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            translate = 0;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.right = new Vector3(-1, 0, 0);
            facingRight = false;
            translate = -1;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.right = new Vector3(1, 0, 0);
            facingRight = true;
            translate = 1;
        }

        if (!facingRight)
        {
            transform.Translate(Vector3.right * -translate * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.right * translate * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.W) && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
        
        if(i < 1)
        {
            animator.SetBool("Coll_Sparky", false);
        }
        i--;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BoxSparky")
        {
            Destroy(collision.collider.gameObject);
            animator.SetBool("Coll_Sparky", true);
            i = 500;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BoxSparky")
        {
            Instantiate(collision.collider.gameObject);
            animator.SetBool("Coll_Sparky", false);
        }

    }


}
