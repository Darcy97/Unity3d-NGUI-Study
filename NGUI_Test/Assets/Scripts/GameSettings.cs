using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public enum GameMode
{
    EASY, 
    NORMAL, 
    DIFFCULT
}

public enum ControlMode
{
    TOUCH, 
    MOUSE,
    KEYBOARD
}

public class GameSettings : MonoBehaviour {

    public  ControlMode controlMode = ControlMode.KEYBOARD;
    public  GameMode gameMode = GameMode.NORMAL;
    public  bool isFullScreen = false;
    public  float volume = 1;



    public void OnVolumeChanged()
    {
        Debug.Log("volume changed");
        UIProgressBar bar = UIProgressBar.current;
        volume = bar.value;
    }

    public void OnControlmodeChanged()
    {
        Debug.Log("control mode changed");
        UIPopupList popList = UIPopupList.current;
        switch (popList.value)
        {
            case "TOUCH":
                controlMode = ControlMode.TOUCH;
                break;
            case "MOUSE":
                controlMode = ControlMode.MOUSE;
                break;
            case "KEYBOARD":
                controlMode = ControlMode.KEYBOARD;
                break;
        }
        
    }

    public void OnGamemodeChanged()
    {
        Debug.Log("game mode changed");
        UIPopupList popList = UIPopupList.current;
        switch (popList.value)
        {
            case "EASY":
                gameMode = GameMode.EASY;
                break;
            case "NORMAL":
                gameMode = GameMode.NORMAL;
                break;
            case "DIFFCULT":
                gameMode = GameMode.DIFFCULT;
                break;
        }
    }

    public void OnIsFullscreenChanged()
    {
        Debug.Log("full screen changed");
        UIToggle toggle = UIToggle.current;
        if (toggle.value)
        {
            isFullScreen = true;
        } else
        {
            isFullScreen = false;
        }

    }

    public TweenPosition showOptionView;
    public TweenPosition hideStartView;

    public void OnFinishButtonClick()
    {

        showOptionView.PlayReverse();
        hideStartView.PlayReverse();
    }

    public void OnOptionButtonClick()
    {
        showOptionView.PlayForward();
        hideStartView.PlayForward();
    }
}

