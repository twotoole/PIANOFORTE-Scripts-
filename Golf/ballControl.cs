using UnityEngine;
using System.Collections;

public class ballControl : MonoBehaviour {

    public Rigidbody2D ballRB;

    public GameObject ball;
    public GameObject club;
    public GameObject hole;

    public Vector3 force = new Vector3(0, 0, 0);

    private bool isMoving = false;
    public float Hitforce = 40f;

    private float counter = 0;
	void Start () {
	
	}

    void Update()
    {
        //count roughly keeps track of when the ball is moveing. 
        counter += Time.deltaTime;
        if(counter > 4)
        {
            isMoving = false;
        }

        // if the ball is small, it has 'fallen' down the hole, and move on to next level
        if (ball.transform.localScale.x < 0.0001)
        {
            Debug.Log("You Putted the ball!!");
            Application.LoadLevel(5);
        }

    }

    public void shrinkBall()
    {
        ball.transform.localScale = ball.transform.localScale * 1 / 2;
    }

    void FixedUpdate () {
        //adds spin force on ball. but decided it was uneccessary.
        if (isMoving == true)
        {
            //    if (Input.GetKeyDown("k") || Input.GetKey("joystick button 6"))
            //    {
            //        ballRB.AddForce(new Vector3(0, 0.5f, 0));
            //    }
            //    if (Input.GetKeyDown("l") || Input.GetKey("joystick button 7"))
            //    {
            //        ballRB.AddForce(new Vector3(0, -0.5f, 0));
            //    }
        }

    }

    //if the ball hits the club, tagged club, adds force relative to the position of the club.
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "club")
        {
            force = (ball.transform.position - club.transform.position) * Hitforce;
            ballRB.AddForce(force);
            counter = 0;
            isMoving = true;
        }
       
    }
    //if the ball hits the hole, tagged hole, it shrinks (appears to be falling down hole) 
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "hole")
        {
            InvokeRepeating("shrinkBall", 0f, 0.1f);
        }
    }
}
