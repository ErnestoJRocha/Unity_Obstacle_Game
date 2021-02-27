using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10.0f;
    public TextMeshProUGUI countDownDisplay;
    

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
      
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Begin()); 
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don´t hit the walls");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);       
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }

    IEnumerator Begin()
    {      
        yield return new WaitForSeconds(3f);
        
        MovePlayer();

        countDownDisplay.text = "Ahaha! Gotcha! Now you can play...";
       
    }


}
