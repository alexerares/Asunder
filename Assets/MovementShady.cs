using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementShady : MonoBehaviour
{
    // Start is called before the first frame update
    public float JumpForce2 = 20;

    public Animator animator;

    GameObject shady;

    private Rigidbody2D _rigidbody2;
    float translate2 = 0;

    bool facingRight2;

    void Start()
    {
        _rigidbody2 = GetComponent<Rigidbody2D>();
        shady = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            translate2 = 0;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.right = new Vector3(-1, 0, 0);
            facingRight2 = false;
            translate2 = -1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.right = new Vector3(1, 0, 0);
            facingRight2 = true;
            translate2 = 1;
        }

        if (!facingRight2)
        {
            transform.Translate(Vector3.right * -translate2 * 20 * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.right * translate2 * 20 * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && Mathf.Abs(_rigidbody2.velocity.y) < 0.001f)
        {
            _rigidbody2.AddForce(new Vector2(0, JumpForce2), ForceMode2D.Impulse);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Coin" || collision.gameObject.tag == "BoxShady")
            animator.SetBool("HitCoin", true);

        if (collision.gameObject.tag == "BoxShady")
            collision.collider.gameObject.GetComponent<Rigidbody2D>().mass = 2.5f;

    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin" || collision.gameObject.tag == "BoxShady")
            animator.SetBool("HitCoin", false);

        if (collision.gameObject.tag == "BoxShady")
            collision.collider.gameObject.GetComponent<Rigidbody2D>().mass = 1000;
    }
}
