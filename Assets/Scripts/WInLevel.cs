using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WInLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.GetChild(0).GetComponent<Elevator_exit>().shady && transform.GetChild(1).GetComponent<pipe_exit>().sparky)
        {
            transform.GetChild(0).GetComponent<Elevator_exit>().animator.SetBool("win", true);
            transform.GetChild(1).transform.GetChild(2).GetComponent<Jesus>().animator.SetBool("Jesus", true);
            //SceneManager.LoadScene(2);
        }

        if(transform.GetChild(0).GetComponent<Elevator_exit>().nextlevel)
            SceneManager.LoadScene(2);
    }

}
