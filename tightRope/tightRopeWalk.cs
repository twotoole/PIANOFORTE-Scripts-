using UnityEngine;
using System.Collections;

public class tightRopeWalk : MonoBehaviour {

    public GameObject centre;
    public Vector2 pos1;
    public Vector2 pos2;
    public float moveSpeed;
    private float dist =0;

    void Update()
    {
      
        dist += moveSpeed;

        //makes walker drop when it falls off tightrope
        if (centre.transform.eulerAngles.z < 240 && centre.transform.eulerAngles.z > 90)
        {
            this.enabled = !this.enabled;
        }
        else
        {
            //moves along tightrope, with public coordinates

            centre.transform.position = Vector2.Lerp(pos1, pos2, dist*dist);
        }

    }
    
    
}
