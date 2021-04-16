using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {


    // Update is called once per frame
    public void ChangeToScene(int LevelToChangeTo)
    {
        Application.LoadLevel(LevelToChangeTo);

    }
}
