using UnityEngine;
using System.Collections;

public class hoseControl : MonoBehaviour {

    private ArrayList waterArray = new ArrayList();
    public GameObject water;
    public Rigidbody2D waterRB;
    public GameObject hose;
    public Transform shootFrom;

    private float power = 200;
    void Start () {

    }

    void Update()
    {
        if (Input.GetKey("s") || Input.GetKey("joystick button 1") || Input.GetKey("f") || Input.GetKey("joystick button 3"))
        {
            hose.transform.eulerAngles += new Vector3(0f, 0f, 1f);
        }
        if (Input.GetKey("d") || Input.GetKey("joystick button 2") || Input.GetKey("a") || Input.GetKey("joystick button 0"))
        {
            hose.transform.eulerAngles -= new Vector3(0f, 0f, 1f);
        }

        if (Input.GetKey("h") || Input.GetKey("joystick button 4") || Input.GetKey("k") || Input.GetKey("joystick button 6"))
        {
            if (power < 700)
            {
                power += 10;
            }
        }
        if (Input.GetKey("j") || Input.GetKey("joystick button 5") || Input.GetKey("l") || Input.GetKey("joystick button 7"))
        {
            if (power > 0)
            {
                power -= 10;
            }
        }
    }

    void FixedUpdate()
    {
        //calculates force that should be applied to water based on position of hose
        Vector2 force = new Vector2(Mathf.Sin(Mathf.PI / 180 * hose.transform.rotation.eulerAngles.z * -1), Mathf.Cos(Mathf.PI / 180 * hose.transform.rotation.eulerAngles.z));


        //if (Input.GetKey("a") || Input.GetKey("joystick button 0"))
        //{
        //    //instantiates water drops and applies force
        //    Rigidbody2D waterDrop = Instantiate(waterRB, shootFrom.position + new Vector3(Random.Range(0, 0.3f), Random.Range(0, 0.3f),0), Quaternion.identity)as Rigidbody2D;
        //    waterDrop.AddForce(force * power);
        //    Debug.Log(power);
        //}
        Rigidbody2D waterDrop = Instantiate(waterRB, shootFrom.position + new Vector3(Random.Range(0, 0.3f), Random.Range(0, 0.3f), 0), Quaternion.identity) as Rigidbody2D;
        waterDrop.AddForce(force * power);


    }

}
