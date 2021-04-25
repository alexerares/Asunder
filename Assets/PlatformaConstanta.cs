using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformaConstanta : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform pos1, pos2;
    public float speed = 2;
    public Transform startPos;
    private bool first = true;
    Vector3 nextpos;

    // Start is called before the first frame update
    void Start()
    {
        nextpos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == pos1.position)
        {
            nextpos = pos2.position;
            first = false;
        }

        if (transform.position == pos2.position)
        {
            nextpos = pos1.position;
            first = false;
        }

        if(!first)
            transform.position = Vector3.MoveTowards(transform.position, nextpos, speed * Time.deltaTime);
        if(first)
            transform.position = Vector3.MoveTowards(transform.position, nextpos, 25 * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}
