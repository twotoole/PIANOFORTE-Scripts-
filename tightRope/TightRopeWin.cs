using UnityEngine;
using System.Collections;

public class TightRopeWin : MonoBehaviour {
    public GameObject cycle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //if the cycle gets to the end of the rope
        if (cycle.transform.position.x > 13)
        {
            Debug.Log("YOU WLAKED THE TIGHTROPE");
            Application.LoadLevel(3);
        }
        //if you fall or fly off the rope
        if (cycle.transform.position.y < -6.5 || cycle.transform.position.y > 6.5)
        {
            Debug.Log("YOU DIDN'T WLAKED THE TIGHTROPE");
            Application.LoadLevel(3);
        }
    }
}
