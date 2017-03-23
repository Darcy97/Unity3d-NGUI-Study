using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnSliderValueChanged()
    {
        UILabel label = GameObject.Find("ShowLabel").GetComponent<UILabel>();
        UISlider slider = GameObject.Find("Slider").GetComponent<UISlider>();
        label.text = (int)(slider.value * 100) + "%";
        
    }
}
