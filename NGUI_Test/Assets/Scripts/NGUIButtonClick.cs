using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NGUIButtonClick : MonoBehaviour
{

    // Use this for initialization
    public void OnLabelButtonClick()
    {
        GameObject.Find("Label").GetComponent<UIButton>().enabled = false;
        print("label button is clicked"); 
    }

    public void OnSpriteButtonClick()
    {
        GameObject.Find("Label").GetComponent<UIButton>().enabled = true;
        print("sprite button is clicked");
    }
}
