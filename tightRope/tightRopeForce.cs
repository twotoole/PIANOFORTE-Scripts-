using UnityEngine;
using System.Collections;

public class tightRopeForce : MonoBehaviour {

    public Rigidbody2D walkerRB;
    public GameObject walker;
    public float torque;




	void FixedUpdate () {
        float turn = Input.GetAxis("Horizontal");


        if (Input.anyKeyDown)
        {
            //adds turning force, to keep walker poright
            Vector2 v = new Vector2(turn, 1) * 2;
            walkerRB.AddForce(v * torque, ForceMode2D.Impulse);
            Debug.Log(v);
        }

        
    }
}
