using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestHudText : MonoBehaviour {

    public HUDText text;
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            text.Add(-10, Color.red, 1f);
        } else if (Input.GetMouseButtonDown(1))
        {
            text.Add(10, Color.green, 1f); 
        }
	}
}
