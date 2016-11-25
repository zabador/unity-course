using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

    int min = 1;
    int max = 1000;
    int guess;

    // Use this for initialization
    void Start() {
        
        print("Welcome to number wizard");
        print("Pick a number in your head but don't tell me");



        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);
        guess = max / 2;
        max = max + 1;

        print("Is your number higher or lower that " + guess);
        print("Enter 'Up' for higher 'down' for lower and 'enter' for equals");
    }
	
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            guess = (max + min) / 2;
            print("Is the number higher or lower than " + guess);
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            guess = (max + min) / 2;
            print("Is the number higher or lower than " + guess);
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            print("I won");
        }
    }
}
