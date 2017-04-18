using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	}
    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetMouseButton(0))
        {
            if (other.transform.tag == "ButtonContinue")
            {
                Application.LoadLevel("game");
            }
            if (other.transform.tag == "ButtonExit")
            {
                Application.Quit();
            }
        }

            
    }
}
