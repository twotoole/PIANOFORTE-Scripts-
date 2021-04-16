using UnityEngine;
using System.Collections;

public class FIN : MonoBehaviour {
   public float timer = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer += 0.01f;
        if (Input.anyKeyDown && timer >= 3f)
        {
            Application.LoadLevel(0);
        }

    }
}
