using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

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

        Debug.Log("Welcome to Number Wizard! It's time to pick a number (don't tell me!)");
        Debug.Log("The highest number you can choose is: " + max);
        Debug.Log("The lowest number you can choose is: " + min);
        Debug.Log("Got it? Ok. Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        // print would work here but D.L is more flexible
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            Debug.Log("Ok, higher. Got it.");
            NextGuess();
            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            Debug.Log("Lower, alright then.");
            NextGuess();
            
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Nice, nailed it! Thanks for playing!");
            StartGame();
        }
        if (max == min)
        {
            Debug.Log("I got it, just accept it! New game!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than " + guess + "?");
    }
}
