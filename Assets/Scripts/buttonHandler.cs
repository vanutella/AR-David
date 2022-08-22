using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonHandler : MonoBehaviour {
    public Material[] myMats; // this will contain 3 mats: normal, painted, chrome, wood, 
    public GameObject David; // this is the David model

    public RectTransform Panel;
    private bool menuOpen = false;
    private Vector3 desiredPos;

    public AudioSource[] AudioClips;

    void Update()
    {
        Panel.anchoredPosition3D = Vector3.Lerp(Panel.anchoredPosition3D, desiredPos, 0.1f);
    }

    // Button functions
    public void Button1(){
        David.GetComponent<Renderer>().material = myMats[0];
        AudioClips[0].Play();
    }

    public void Button2(){
        David.GetComponent<Renderer>().material = myMats[1];
        AudioClips[1].Play();
    }
    public void Button3(){
        David.GetComponent<Renderer>().material = myMats[2];
        AudioClips[2].Play();
    }
    public void Button4(){
        David.GetComponent<Renderer>().material = myMats[3];
        AudioClips[3].Play();
    }
    public void Button5(){
        David.GetComponent<Renderer>().material = myMats[4];
        AudioClips[4].Play();
    }
    public void Button6()
    {
        David.GetComponent<Renderer>().material = myMats[5];
        AudioClips[5].Play();
    }
    public void ButtonMenu(){
        Debug.Log("Menu Button");
       if(menuOpen == false)
        {
            // open menu
            NavigateTo(1);
            Debug.Log("false");
            menuOpen = true;
        }
        else if(menuOpen == true)
        {
            // close menu
            NavigateTo(0);
            Debug.Log("true");
            menuOpen = false;
        }
    }

    // function for open/close the menu with lerped vals
    private void NavigateTo(int Index)
    {
        switch (Index)
        {
            default:
            case 0:
                desiredPos = Vector3.zero;
                break;
            case 1:
                desiredPos = Vector3.left * 240;
                break;
        }
    }
}
