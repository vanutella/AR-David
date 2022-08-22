using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class posFix : MonoBehaviour {
    public GameObject[] LeButtons;
    public GameObject David;
    public Text _UIPos;

    private string myPos;
    private bool UIactive = true;
	// Use this for initialization
	void Start () {
        myPos = "";
	}
	
	// Update is called once per frame
	void Update () {
		
            myPos = David.gameObject.transform.position.ToString("G4");
        Debug.Log(David.gameObject.transform.position);
            _UIPos.text = myPos;

        
        if (UIactive == true)
        {
            for (int i = 0; i < 6; i++)
            {
                LeButtons[i].gameObject.SetActive(false);
            }
            _UIPos.gameObject.SetActive(false);
        }
        else if (UIactive == false)
        {
            for (int i = 0; i < 6; i++)
            {
                LeButtons[i].gameObject.SetActive(true);
            }
            _UIPos.gameObject.SetActive(true);
        }
    }

    public void buttonW()
    {
        David.transform.Translate(-3f * Time.deltaTime, 0f, 0f);
    }
    public void buttonS()
    {
        David.transform.Translate(3f * Time.deltaTime, 0f, 0f);
    }
    public void buttonA()
    {
        David.transform.Translate(0f, 0f, -3f * Time.deltaTime);

    }
    public void buttonD()
    {
        David.transform.Translate(0f, 0f, 3f * Time.deltaTime);

    }
    public void buttonUP()
    {
        David.transform.Translate(0f, 3f * Time.deltaTime, 0f);

    }
    public void buttonDOWN()
    {
        David.transform.Translate(0f, -3f * Time.deltaTime, 0f);

    }
    public void buttonONOFF()
    {
        if(UIactive == true)
        {
            UIactive = false;
        }
        else 
        {
            UIactive = true;
        }
    }
}
