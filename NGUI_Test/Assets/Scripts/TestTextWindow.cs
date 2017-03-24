using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTextWindow : MonoBehaviour
{


    private UITextList textList;
    private int lineNum = 1;

    // Use this for initialization
    void Start()
    {
        textList = this.GetComponent<UITextList>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("x"))
        {
            textList.Add("If you want it, work for it. line:" + lineNum++);
        }
    }
}
