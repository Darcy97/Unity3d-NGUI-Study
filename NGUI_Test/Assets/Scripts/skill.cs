using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill : MonoBehaviour {

    private float coldTime = 2;
    private bool isColding;
    private UISprite sprite;


    private void Awake()
    {
        sprite = transform.Find("slider360").GetComponent<UISprite>();
    }
    // Update is called once per frame
    void Update () {
		if(Input.GetKeyDown(KeyCode.A) && !isColding)
        {
            //释放技能
            isColding = true;
            sprite.fillAmount = 1;
        }

        if (isColding)
        {
            sprite.fillAmount -= (1f / coldTime) * Time.deltaTime;
            if (sprite.fillAmount < 0.05f)
            {
                isColding = false;
                sprite.fillAmount = 0;
            }
        }
	}
}
