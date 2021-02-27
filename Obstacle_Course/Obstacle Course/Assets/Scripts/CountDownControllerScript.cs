using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class CountDownControllerScript : MonoBehaviour
{

    

   
    public GameObject textDisplay;
    public int secondsLeft = 16;
    public bool takingAway = false;





    private void Start()
    {
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        
    }
    private void Update()
    {
       
        if (takingAway == false && secondsLeft > 0)
        {       
            StartCoroutine(Time());
        }
    }


    IEnumerator Time()
    {
        takingAway = true;

        secondsLeft -= 1;
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;

        yield return new WaitForSeconds(1);

        takingAway = false;

        if (secondsLeft <= 0)
        {
            textDisplay.GetComponent<Text>().text = "Game Over!";
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(0);
        }
    }
    
}
