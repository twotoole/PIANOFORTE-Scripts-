using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleContinue : MonoBehaviour
{
    int level;
    string key;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            key = Input.inputString;
            int.TryParse(key, out level);

            if(level == 0)
            {
                Application.LoadLevel(1);
            }
            else
            {
                Application.LoadLevel(level);
            }
        }
    }
}


