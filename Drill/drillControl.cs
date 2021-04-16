using UnityEngine;
using System.Collections;

public class drillControl : MonoBehaviour
{

    // public Rigidbody2D drill;
    public Transform drill;
    public Transform bit;
    public float speed;

    public GameObject hole;

    //public AudioSource drillSound;
    //public float counter = 0;

    //public bool isSpinning = false;

    //public void drillSpin()
    //{

    //    if (   Input.GetKey("h") || Input.GetKey("joystick button 0")
    //        || Input.GetKey("j") || Input.GetKey("joystick button 0")
    //        || Input.GetKey("k") || Input.GetKey("joystick button 0")
    //        || Input.GetKey("l") || Input.GetKey("joystick button 0"))
    //    {
    //        counter += 1f;
    //    }
    //    if(counter > 0)
    //    {
    //        isSpinning = true;
    //        counter -= 0.5f;
    //    }
    //    if (counter < 0)
    //    {
    //        counter = 0;
    //    }
    //    if (counter == 0)
    //    {
    //        isSpinning = false;
    //    }
    //    Debug.Log(counter);
    //}

    public void makeHole()
    {
        Instantiate(hole, new Vector3(Random.Range(-0.01f, 0.01f) + 6.925f, Random.Range(-0.01f, 0.01f) + drill.position.y + 1.862f, 1.65f), Quaternion.identity);
    }

    public void drillMovement()
    {
        if (drill.position.x >= 5.3 && drill.position.y < -1.2 && drill.position.y > -1.3)
        {
            Debug.Log("You've Drilled A Hole!!!!!");

            Application.LoadLevel(2);
        }

        //DOWN
        if (Input.GetKey("a") || Input.GetKey("h") || Input.GetKey("joystick button 0") || Input.GetKey("joystick button 4"))
        {
            if (drill.position.x > 4)
            {
                makeHole();
            }
            drill.position = drill.position + Vector3.down * Time.deltaTime;
        }
        //UP
        if (Input.GetKey("s") || Input.GetKey("j") || Input.GetKey("joystick button 1") || Input.GetKey("joystick button 5"))
        {
            if (drill.position.x > 4)
            {
                makeHole();
            }
            drill.position = drill.position + Vector3.up * Time.deltaTime;
        }
        //RIGHT
        if (Input.GetKey("d") || Input.GetKey("k") || Input.GetKey("joystick button 2") || Input.GetKey("joystick button 6"))
        {
                if (drill.position.x < 5.4538)
                {
                    drill.position = drill.position + Vector3.right * Time.deltaTime;
                }

                if (drill.position.x > 4 && drill.position.x < 5.45)
                {
                    bit.position = bit.position - Vector3.right * Time.deltaTime;
                    makeHole();
                }
        }
        //LEFT
        if (Input.GetKey("f") || Input.GetKey("l") || Input.GetKey("joystick button 3") || Input.GetKey("joystick button 7"))
        {
            drill.position = drill.position + Vector3.left * Time.deltaTime;
            if (drill.position.x > 4)
            {
                bit.position = bit.position - Vector3.left * Time.deltaTime;
            }

        }
    }

    void Update()
    {
        drillMovement();
        //drillSpin();
    }
}
