using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {

        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to number wizard padwon");
        Debug.Log("Pick a number for the wizard to guess ");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than... " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            min = guess;
            NextGuess();


        }

        //Detect when the down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {

            max = guess;
            NextGuess();
           
        }

        //Detect when the Return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("YAAAAAAAAAAAAAAAYYYYY PAAANCAKEES. Your number was: " + guess);
            Debug.Log("It's time to play again!");
            StartGame();
            

    

        }
    }
    void NextGuess()
    {
     guess = (max + min) / 2;
            Debug.Log("Is the number higher or lower than..." + guess);
            Debug.Log("I think your number is.. " + guess);
    }
}
