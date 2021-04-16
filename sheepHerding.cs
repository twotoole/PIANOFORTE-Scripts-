using UnityEngine;
using System.Collections;

public class sheepHerding : MonoBehaviour {

    public GameObject sheepPrefab;
    private ArrayList sheeps = new ArrayList();
    
	void Start () {
        //Instntiates sheep and adds them to sheep arrayList
        for (int i = 0; i < 9; i++)
        {
            Vector3 position = new Vector3(Random.Range(-12f, 12f), Random.Range(0, 2f), 2);
            sheeps.Add(Instantiate(sheepPrefab, position, Quaternion.identity));
        }
    }

    //function for movement for sheepPrefabs in shee
    void movement(float _min, float _max)
    {
        foreach (GameObject sheepPrefab in sheeps)
        {
            if (sheepPrefab.transform.position.x > 12)
            {
                sheepPrefab.transform.position += new Vector3(Random.Range(_max * -1, _min + 0.01f), 0, 0);
            }
            else
            {
                sheepPrefab.transform.position += new Vector3(Random.Range(_min, _max), 0, 0);
            }

        }
    }

    void Update () {
        if (Input.GetKey("a") || Input.GetKey("joystick button 1")) {
            movement(0.1f, -0.05f);
        }

        if (Input.GetKey("s") || Input.GetKey("joystick button 1"))
        {
            movement(-0.05f, 0.1f);
        }
    }
}
