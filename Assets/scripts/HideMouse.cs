using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMouse : MonoBehaviour {
    public bool Visible = false;
    // Use this for initialization
    void Start () {
        Cursor.visible = Visible ;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
