using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed = 2;
    public Transform startPos;
    public static bool button = false;
    public bool first = false;

    Vector3 nextpos;
    
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
            first = true;
            nextpos = pos2.position;
        }

        if (transform.position == pos2.position)
        {
            first = true;
            nextpos = pos1.position;
        }

        if(button && first)
            transform.position = Vector3.MoveTowards(transform.position, nextpos, speed * Time.deltaTime);

        if (button && !first)
            transform.position = Vector3.MoveTowards(transform.position, nextpos, 25 * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}
