using UnityEngine;
using System.Collections;

public class clubControl : MonoBehaviour {

    public GameObject club;

    void Start () {
	
	}
	
	void rotate(float _z)
    {
        club.transform.eulerAngles += new Vector3(0, 0, _z);
    }

    void movement(float _x, float _y)
    {
        club.transform.position += new Vector3(_x, _y, 0);
    }

	void Update () {
        //rotate clockwise
        if (Input.GetKey("h") || Input.GetKey("k") || Input.GetKey("joystick button 4") || Input.GetKey("joystick button 6"))
        {
            rotate(1f);
        }
        //rotate antiClock
        if (Input.GetKey("j") || Input.GetKey("l") || Input.GetKey("joystick button 5") || Input.GetKey("joystick button 7"))
        {
            rotate(-1f);
        }
        //move left
        if (club.transform.position.x > -12)
        {
            if (Input.GetKey("a") || Input.GetKey("joystick button 0") && club.transform.position.x > -12)
            {
                movement(-0.05f, 0);
            }
        }
        //move right
        if (club.transform.position.x < 12)
        {
            if (Input.GetKey("s") || Input.GetKey("joystick button 1") && club.transform.position.x < 12)
            {
                movement(0.05f, 0);
            }
        }
        //move up
        if (club.transform.position.y < 5.5)
        {
            if (Input.GetKey("d") || Input.GetKey("joystick button 2"))
            {
                movement(0, 0.05f);
            }
        }
        //move down
        if (club.transform.position.y > -4.5)
        {
            if (Input.GetKey("f") || Input.GetKey("joystick button 3"))
            {
                movement(0, -0.05f);
            }
        }

//        if (club)
//        {
//            Debug.Log("You Putted the ball!!");
//            Application.LoadLevel(5);
//        }
    }
}
