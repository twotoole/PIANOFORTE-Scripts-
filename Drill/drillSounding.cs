using UnityEngine;
using System.Collections;

public class drillSounding : MonoBehaviour {
    float counter = 0;
    public AudioSource drillSound;
    public float interval;


    //this was going to be used, so that when you play keys it spins up the drill bit. But playing keys very fast sounds really bad
    // so I decided not t use it for the final game. 


    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("h"))
        {
            counter = counter + interval;
        }
        if (Input.GetKeyDown("j"))
        {
            counter = counter + interval;
        }
        if (Input.GetKeyDown("k"))
        {
            counter = counter + interval;
        }
        if (Input.GetKeyDown("l"))
        {
            counter = counter + interval;
        }



        if (counter > 3f)
        {
            counter = counter - Time.deltaTime;
        }
        else if (counter <= 0)
        {

            counter = 0;
        }

      //  Debug.Log(counter);
            }
  }
