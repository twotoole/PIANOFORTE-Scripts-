using UnityEngine;
using System.Collections;

public class pianoControl : MonoBehaviour {

    public AudioSource d;
    public AudioSource e;
    public AudioSource f;
    public AudioSource g;

    public AudioSource a;
    public AudioSource b;
    public AudioSource c;
    public AudioSource d1;

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown("a") || Input.GetKeyDown("joystick button 0"))
        {
            d.Play();
        }
        if (Input.GetKeyDown("s") || Input.GetKeyDown("joystick button 1"))
        {
            e.Play();
        }
        if (Input.GetKeyDown("d") || Input.GetKeyDown("joystick button 2"))
        {
            f.Play();
        }
        if (Input.GetKeyDown("f") || Input.GetKeyDown("joystick button 3"))
        {
            g.Play();
        }

        if (Input.GetKeyDown("h") || Input.GetKeyDown("joystick button 4"))
        {
            a.Play();
        }
        if (Input.GetKeyDown("j") || Input.GetKeyDown("joystick button 5"))
        {
            b.Play();
        }
        if (Input.GetKeyDown("k") || Input.GetKeyDown("joystick button 6"))
        {
            c.Play();
        }
        if (Input.GetKeyDown("l") || Input.GetKeyDown("joystick button 7"))
        {
            d1.Play();
        }

    }
}
