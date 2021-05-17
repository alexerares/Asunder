using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WInLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public bool unlock1 = false;
    public bool unlock2 = false;
    public int nextSceneLoad;
    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.GetChild(0).GetComponent<Elevator_exit>().shady && transform.GetChild(1).GetComponent<pipe_exit>().sparky && unlock1 && unlock2)
        {
            transform.GetChild(0).GetComponent<Elevator_exit>().animator.SetBool("win", true);
            transform.GetChild(1).transform.GetChild(2).GetComponent<Jesus>().animator.SetBool("Jesus", true);
        }

        if (transform.GetChild(0).GetComponent<Elevator_exit>().nextlevel)
        {
            if (SceneManager.GetActiveScene().buildIndex == 5) 
            {
                Debug.Log("You Completed ALL Levels");

            }
            else
            {
                SceneManager.LoadScene(nextSceneLoad);

                if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
                {
                    PlayerPrefs.SetInt("levelAt", nextSceneLoad);
                }
            }

        }    
    }

}
