using UnityEngine;
using System.Collections;

public class fireColliderControl : MonoBehaviour {

    public GameObject window;
    public GameObject fire;

    private int counter = 0;

	
	void Awake () {

        //destroys random amount of windows with fire
        float rand = Random.Range(0, 100f);
        if(rand < 35f)
        {
            Destroy(window.gameObject);
        }

	}
	
	void Update () {
	
	}

    //after certain amount of wter hits fire, it is destroyed
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "water")
        {
            Destroy(col.gameObject);
            counter += 1;
        }
        if(counter >= 30)
        {
            Destroy(window.gameObject);
        }

    }

}
