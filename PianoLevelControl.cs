using UnityEngine;
using System.Collections;

public class PianoLevelControl : MonoBehaviour {
    public Rigidbody2D Lhand;
    public Rigidbody2D Rhand;

    private float counter = 0;
	// Use this for initialization
	void Start () {
	
	}

    void Update()
    {
        counter += Time.deltaTime;
        if(counter > 9)
        {
            Application.LoadLevel(6);
        }
    }

	void FixedUpdate () {


        if (Input.GetKeyDown("a") ||
            Input.GetKeyDown("s") ||
            Input.GetKeyDown("d") ||
            Input.GetKeyDown("f") ||
            Input.GetKey("joystick button 0") ||
            Input.GetKey("joystick button 1") ||
            Input.GetKey("joystick button 2") ||
            Input.GetKey("joystick button 3")
            )
        {
            Lhand.AddForce(new Vector3(Random.Range(-1000f, 1000f), 0, 0));
        }
        if (Input.GetKeyDown("h") ||
            Input.GetKeyDown("j") ||
            Input.GetKeyDown("k") ||
            Input.GetKeyDown("l") ||
            Input.GetKey("joystick button 4") ||
            Input.GetKey("joystick button 5") ||
            Input.GetKey("joystick button 6") ||
            Input.GetKey("joystick button 7")
            )
        {
            //Rhand.AddForce(new Vector3(Random.Range(-2f, 2f), 0, 0));
            Rhand.AddForce(new Vector3(Random.Range(-1000f, 1000f), 0, 0));
        }
    }
}

