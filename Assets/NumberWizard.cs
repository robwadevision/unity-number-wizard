using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;

        Debug.Log("Welcome to Number Wizard");
        Debug.Log("It's time to pick a number!");
        Debug.Log("The highest number you can choose is: " + max);
        Debug.Log("The lowest number you can choose is: " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Up = Higher, Down = Lower, Enter = Correct");
        // print would work here but D.L is more flexible
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            Debug.Log("Up was pushed");
        if (Input.GetKeyDown(KeyCode.DownArrow))
            Debug.Log("Down was pushed");
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("Enter was pushed");
    }
}
