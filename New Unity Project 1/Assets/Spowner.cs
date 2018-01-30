using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spowner : MonoBehaviour {

   public GameObject cube;
   public Transform SpawnPoint;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame

	void Update () {
		if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(cube, SpawnPoint);
        }
	}
}
