using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WInLevel : MonoBehaviour
{
    bool Sparky = false;
    bool Shady = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Sparky && Shady)
            SceneManager.LoadScene(2);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Sparky")
            Sparky = true;

        if (collision.collider.tag == "Shady")
            Shady = true;
    }
}
