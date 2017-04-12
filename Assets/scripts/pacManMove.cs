using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacManMove : MonoBehaviour {
    public float velocity = 0.3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Moviment();	
	}
    void Moviment ()
    {
        if (Input.GetKey(KeyCode.UpArrow) )
        {
            transform.Translate(Vector3.up * velocity, Space.World);
            transform.rotation = Quaternion.Euler(0, 0,90);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * velocity, Space.World);
            transform.rotation = Quaternion.Euler(0, 0,-90);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * velocity, Space.World);
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * velocity, Space.World);
            transform.rotation = Quaternion.Euler(0, 0, -180);

        }
    }
}

   