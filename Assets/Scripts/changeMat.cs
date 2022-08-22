using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMat : MonoBehaviour {
    public Material[] myMats; // this will contain 3 mats: normal, painted, chrome, wood, 
    public GameObject David; // this is the David model
	// Use this for initialization
	void Start () {
        David.GetComponent<Renderer>().material = myMats[0];
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            Debug.Log("Pressed 1");
            David.GetComponent<Renderer>().material = myMats[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Pressed 2");
            David.GetComponent<Renderer>().material = myMats[2];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("Pressed 3");
            David.GetComponent<Renderer>().material = myMats[3];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Debug.Log("Pressed 4");
            David.GetComponent<Renderer>().material = myMats[4];
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Pressed Space");
            David.GetComponent<Renderer>().material = myMats[0];
        }
	}
}
