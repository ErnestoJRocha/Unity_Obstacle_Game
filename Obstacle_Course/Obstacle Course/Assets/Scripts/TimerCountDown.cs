using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimerCountDown : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 30;
    public bool takingAway = false;
    public int countdownTime = 3;
    public TextMeshProUGUI countDownDisplay;

    private void Start()
    {
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
    }

    private void Update()
    {
        StartCoroutine(CountDownToStart());

    }
   
    IEnumerator CountDownToStart()
    {
       while(countdownTime > 0)
        {
            countdownTime--;
            
        }


        countDownDisplay.text = "Ahah, Gotcha";

        yield return new WaitForSeconds(3f);

    }

    }

    
