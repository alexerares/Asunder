using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed = 2;
    public Transform startPos;
    public bool button = false;

    Vector3 nextpos;
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        nextpos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position == pos1.position)
        {
            nextpos = pos2.position;
        }

        if (transform.position == pos2.position)
        {
            nextpos = pos1.position;
        }

        //if(button && first)
        //transform.position = Vector3.MoveTowards(transform.position, nextpos, speed * Time.deltaTime);

        if (button)
        {
            animator.SetBool("Open", true);
            transform.position = Vector3.MoveTowards(transform.position, nextpos, speed * Time.deltaTime);
        }
        if (!button)
        {
            animator.SetBool("Open", false);
        }
    }


}
