using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

    int min;
    int max;
    int guess;

    // Use this for initialization
    void Start() {
        startGame(); 
       
    }

    void startGame() {
        min = 1;
        max = 1000;
        print("Welcome to number wizard");
        print("Pick a number in your head but don't tell me");



        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);
        guess = max / 2;
        max++;

        print("Is your number higher or lower that " + guess);
        print("Enter 'Up' for higher 'down' for lower and 'enter' for equals");
    }

    void nextGuess() {
        guess = (max + min) / 2;
        print("Is the number higher or lower than " + guess); 
    }
	
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            nextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            nextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            print("I won");
            startGame();
        }
    }
}
