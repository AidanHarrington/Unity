using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increment : MonoBehaviour {

	// Use this for initialization
	void Start () {
        num = 5;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            num++;
        }

        //inputting down arrow
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            num--;
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            num--10;
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            num++10;
        }
    }
}
