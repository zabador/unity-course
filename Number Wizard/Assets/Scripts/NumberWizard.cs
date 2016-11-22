using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

    // Use this for initialization
    void Start() {
        print("Welcome to number wizard");
        print("Pick a number in your head but don't tell me");

        int min = 1;
        int max = 1000;

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is your number higher or lower that " + max / 2);
        print("Enter 'Up' for higher 'down' for lower and 'enter' for equals");
    }
	
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            print("Up arrow pressed");
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            print("down arrow pressed");
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            print("Return key pressed");
        }
	
    }
}
