using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPauseMenu : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {

            openPauseMenu();


        }
	}

    void openPauseMenu()
    {

        Application.LoadLevel("pause-menu");

    }
}
