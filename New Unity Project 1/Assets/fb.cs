using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fb : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("デバッグログ");
        FizzBuzzOut();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void FizzBuzzOut()
    {
        
        for (int i = 1; i <= 20; i++)
        { 
            if (i % 15 == 0)
            {
                Debug.Log("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Debug.Log("Fizz");
            }

            else if (i % 5 == 0)
            {
                Debug.Log("Buzz");
            }

            

            else Debug.Log(i);
        }

    }
}
