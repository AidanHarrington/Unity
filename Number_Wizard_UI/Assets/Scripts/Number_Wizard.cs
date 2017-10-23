using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Number_Wizard : MonoBehaviour {

    //Creates 2 integer values
    int min;
    int max;
    int guess;
    int maxNumberOfGuesses = 10;

    public Text guessText;

    void NextGuess()
    {
        //guess = (max + min) / 2;
        guess = Random.Range(min, max + 1);
        //Converts guess string to text
        guessText.text = guess.ToString();
        maxNumberOfGuesses--;

        if(maxNumberOfGuesses == 0)
        {
            SceneManager.LoadScene("Win");
        }
    }

    void StartGame()
    {
       
        NextGuess();
       
    }

    public void GuessHigher() {
        min = guess;
        NextGuess();
    }

    public void GuessLower() {
        max = guess;
        NextGuess();
    }

    // Use this for initialization
    void Start ()
    {
        NextGuess();
    }

	
}
