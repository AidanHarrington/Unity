using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number_Wizard : MonoBehaviour {

    //Creates 2 integer values
    int min;
    int max;
    int guess;
    //type/name/value

    void NextGuess()
    {
        print("Is number bigger or smaller than " + guess + " ?");
        print("UP: Bigger, DOWN: Smaller, RETURN: Equal");
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;//Prints these once
        //Debug.Log and print is the same thing
        print("Welcome to Number Wizard");
        Debug.Log("Please think of a number from " + min + " to " + max);
        NextGuess();
       
    }

    // Use this for initialization
    void Start ()
    {
        StartGame();
    }
	
	// Update is called once per frame
	void Update () {

        //We use Input when we need something from the user
        //inputting up arrow
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up Arrow pressed");
            min = guess;
            guess = (min + max) / 2;
            NextGuess();
        }

        //inputting down arrow
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down Arrow pressed");
            max = guess;
            guess = (min + max) / 2;
            NextGuess();
        }

        //inputting all the enters
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("YOU WIN!");
            print("Do you want to continue");
            print("If YES:P, No:Q");

            if (Input.GetKeyDown(KeyCode.P))
            {
                StartGame();
            }

            else if (Input.GetKeyDown(KeyCode.Q))
            {
                UnityEditor.EditorApplication.isPlaying = false;
            }
        }
    }
}
