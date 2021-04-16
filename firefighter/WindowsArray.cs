using UnityEngine;
using System.Collections;

public class WindowsArray : MonoBehaviour {
    //public ArrayList windows;

	// Use this for initialization
	void Start () {
	
	}
	
    // if there are no windows with fire, move on to next level
	void Update () {
        if (transform.childCount == 0)
        {
            Debug.Log("YOU HAVE WON");
            Application.LoadLevel(3);
        } 

    }
}

