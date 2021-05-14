using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 7;
    public float JumpForce = 7;

    public bool canMove = true;
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
            if(canMove)
                transform.Translate(Vector3.right * -translate * moveSpeed * Time.deltaTime);
        }
        else
        {
            if(canMove)
                transform.Translate(Vector3.right * translate * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.W) && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
        

        if(this.GetComponent<Rigidbody2D>().velocity.y > 0)
        {
            animator.SetBool("SparkyJump", true);
        }
        else if(this.GetComponent<Rigidbody2D>().velocity.y < 0)
        {
                animator.SetBool("SparkyFall", true);
        }
        else
        {
            animator.SetBool("SparkyJump", false);
            animator.SetBool("SparkyFall", false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        /*if (collision.gameObject.tag == "Floor" || collision.gameObject.tag == "BoxShady")
        {
            animator.SetBool("SparkyJump", false);
        }*/
        if (collision.collider.tag == "Platform")
        {
            transform.SetParent(collision.collider.transform);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {

        /*if (collision.gameObject.tag == "Floor" || collision.gameObject.tag == "BoxShady")
        {
            animator.SetBool("SparkyJump", true);
        }*/
        if (collision.collider.tag == "Platform")
        {
            transform.SetParent(null);
        }

    }


}
