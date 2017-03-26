using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour {



    public TweenPosition optionViewAnimation;
    public TweenPosition startViewAnimation;

    public void OnFinishButtonClick()
    {
        print("finish");
        optionViewAnimation.PlayReverse();
        startViewAnimation.PlayReverse();
    }

    public void OnOptionButtonClick()
    {
        print("option");
        optionViewAnimation.PlayForward();
        startViewAnimation.PlayForward();
    }
}
