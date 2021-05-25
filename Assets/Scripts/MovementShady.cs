using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementShady : MonoBehaviour
{
    // Start is called before the first frame update
    public float JumpForce2 = 7;
    public float moveSpeed2 = 7;
    public Animator animator;
    public bool canMove = true;

    GameObject shady;

    private Rigidbody2D _rigidbody2;
    float translate2 = 0;

    bool facingRight2;
    float mass;

    void Start()
    {
        _rigidbody2 = GetComponent<Rigidbody2D>();
        shady = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.J) || Input.GetKeyUp(KeyCode.L))
        {
            translate2 = 0;
            
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            transform.right = new Vector3(-1, 0, 0);
            facingRight2 = false;
            translate2 = -1;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            transform.right = new Vector3(1, 0, 0);
            facingRight2 = true;
            translate2 = 1;
        }

        if (!facingRight2)
        {
            if(canMove)
                transform.Translate(Vector3.right * -translate2 * moveSpeed2 * Time.deltaTime);
        }
        else
        {
            if (canMove)
                transform.Translate(Vector3.right * translate2 * moveSpeed2 * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.I) && Mathf.Abs(_rigidbody2.velocity.y) < 0.001f)
        {
            _rigidbody2.AddForce(new Vector2(0, JumpForce2), ForceMode2D.Impulse);
            SoundMangerScript.PlaySound("jumpShady");
        }

        if (this.GetComponent<Rigidbody2D>().velocity.y > 0)
        {
            animator.SetBool("ShadyJump", true);
        }
        else if (this.GetComponent<Rigidbody2D>().velocity.y < 0)
        {
            animator.SetBool("ShadyFall", true);
        }
        else
        {
            animator.SetBool("ShadyJump", false);
            animator.SetBool("ShadyFall", false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BoxShady")
        {
            animator.SetBool("ShadyPush", true);
            animator.SetBool("ShadyJump", false);
            animator.SetBool("ShadyFall", false);
        }

        if (collision.gameObject.tag == "BoxShady")
        {
            collision.collider.gameObject.GetComponent<Rigidbody2D>().mass = 2.5f;
        }

        if(collision.collider.tag == "Platform")
        {
            transform.SetParent(collision.collider.transform);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BoxShady")
        {
            animator.SetBool("ShadyPush", false);
            if (this.GetComponent<Rigidbody2D>().velocity.y > 0)
            {
                animator.SetBool("ShadyJump", true);
            }
            else if (this.GetComponent<Rigidbody2D>().velocity.y < 0)
            {
                animator.SetBool("ShadyFall", true);
            }
            else
            {
                animator.SetBool("ShadyJump", false);
                animator.SetBool("ShadyFall", false);
            }
        }

        if (collision.gameObject.tag == "BoxShady")
        {
            collision.collider.gameObject.GetComponent<Rigidbody2D>().mass = 1000;
        }

        if (collision.collider.tag == "Platform")
        {
            transform.SetParent(null);
        }
    }
}
