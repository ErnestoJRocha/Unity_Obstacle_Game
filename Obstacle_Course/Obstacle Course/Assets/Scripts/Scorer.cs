using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorer : MonoBehaviour
{
    int hits = 0;

private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hits++;

            if(hits >= 3)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(2);
            }
        }
        if (other.gameObject.tag == "Finish")
        {
            gameObject.tag = "Finish";
            SceneManager.LoadScene(2);
        }
        Debug.Log("You´ve bumped into a thing this many times: " + hits);
       
    }

    
}
