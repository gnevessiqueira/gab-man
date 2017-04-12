﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMove : MonoBehaviour {
    public GameObject target;
    public float velocity = 0.1f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        chase();
	}
    void chase()
    {
        if(transform.position.x > target.transform.position.x)
        {

            transform.Translate(Vector3.left * velocity);



        }

        if (transform.position.x < target.transform.position.x)
        {

            transform.Translate(Vector3.right * velocity);



        }

        if (transform.position.y < target.transform.position.y)
        {

            transform.Translate(Vector3.up * velocity);



        }

        if (transform.position.y > target.transform.position.y)
        {

            transform.Translate(Vector3.down * velocity);



        }

    }
}
