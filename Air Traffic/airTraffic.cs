using UnityEngine;
using System.Collections;

public class airTraffic : MonoBehaviour {

    public GameObject prefab;
    private GameObject plane;

    public float speed;

    private float z;
    private float RAD;
    private Vector3 movement;

    void Start () {
        //set random angle and position
        z = Random.Range(-70f, 70f);
        plane = Instantiate(prefab, new Vector3(Random.Range(-10f, 10f), 4f, 0), Quaternion.Euler(0f, 0f, z)) as GameObject;
    }
	

	void Update () {
        Vector2 centre = new Vector2(0, 0);


            //convert angle to radians
            RAD = Mathf.PI / 180 * z;
            //set relative forward movement
            movement = new Vector3(Mathf.Sin(RAD), Mathf.Cos(RAD) * -1, 0);
            plane.transform.position += movement * speed;


            //rotate clockwise
            if (Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("joystick button 0") || Input.GetKey("joystick button 1"))
            {
                plane.transform.eulerAngles += new Vector3(0f, 0f, 1f);
                z += 1;
            }
            //rotate antiClock
            if (Input.GetKey("d")|| Input.GetKey("f") || Input.GetKey("joystick button 2") || Input.GetKey("joystick button 3"))
            {
                plane.transform.eulerAngles += new Vector3(0f, 0f, -1f);
                z -= 1;
            }
            //move closer to ground
            if (Input.GetKey("j") || Input.GetKey("joystick button 5"))
            {
                if (plane.transform.localScale.x > 0.2 && plane.transform.localScale.x > 0.2)
                {
                    plane.transform.localScale -= new Vector3(0.01f, 0.01f, 0);
                }
            }
            //move furter from ground
            if (Input.GetKey("h") || Input.GetKey("joystick button 4") && plane.transform.localScale.x < 2)
            {
                if (plane.transform.localScale.x < 2 && plane.transform.localScale.x < 2)
                {
                    plane.transform.localScale += new Vector3(0.01f, 0.01f, 0);
                }
            }
            //speed up movemet
            if (Input.GetKey("k") || Input.GetKey("joystick button 6"))
            {
                if (speed > 0)
                {
                    speed -= 0.0001f;
                }
            }
            //slow down movemet
            if (Input.GetKey("l") || Input.GetKey("joystick button 7"))
                {
                    if (speed < 0.2f)
                    {
                        speed += 0.0001f;
                    }
                }


            //win condition
            if(plane.transform.position.x > -6.35
            && plane.transform.position.x < -5.8
            && plane.transform.position.y > -4.5
            && plane.transform.position.y < 5
            && plane.transform.localScale.x <= 0.35
            )
        {
            Debug.Log("YOU LANDED THE PLANE");
            Application.LoadLevel(4);
        }

            //lose condition
            if(Vector2.Distance(plane.transform.position, centre) > 18)
        {
            Application.LoadLevel(4);
        }
        //Debug.Log(speed);
        //Debug.Log(Vector2.Distance(plane.transform.position, centre));
        //plane.transform.position.x > 20
        //    && plane.transform.position.x < -20
        //    && plane.transform.position.y > -13
        //    && plane.transform.position.y < 13
    }
}
