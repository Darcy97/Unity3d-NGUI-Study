using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test: MonoBehaviour
{


    private UITextList list;
    private int lineNumber = 1;

    // Use this for initialization
    void Start()
    {
        list = this.GetComponent<UITextList>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            list.Add("If you want it, work for it. line:" + lineNumber++);
        }
    }
}

