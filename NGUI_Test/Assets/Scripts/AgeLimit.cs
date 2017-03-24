using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgeLimit : MonoBehaviour {

    private UIInput input;

    private void Awake()
    {
        input = this.GetComponent<UIInput>();

    }
    public void OnCommited()
    {
        string inputStr = input.value;
        int intValue = int.Parse(inputStr);

        if (intValue < 18)
        {
            input.value = "18";
        } else if (intValue > 120)
        {
            input.value = "120";
        }
    }
}
