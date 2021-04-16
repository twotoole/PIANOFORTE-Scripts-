using UnityEngine;
using System.Collections;

public class cycleScaling : MonoBehaviour {

    public GameObject cycle;
    private float size = 0;
    // Use this for initialization
    void Start () {
	
	}

    void Update()
    {
        size += 0.0002f;
        //walker gets bigger closer it gets
        if (cycle.transform.localScale.x < 11)
        {
            cycle.transform.localScale += new Vector3((size * size), (size * size), 0);
        }
    }
}
