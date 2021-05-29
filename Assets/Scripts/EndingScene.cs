using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingScene : MonoBehaviour
{
    // Start is called before the first frame update
    public bool change = false;
    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (change)
            animator.SetBool("New Bool", true);
    }
}
