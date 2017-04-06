using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnapsackItem : UIDragDropItem {

    public UISprite sprite;
    public UILabel label;

    private int count = 1;

    public void AddCount(int number)
    {
        count += number;
        label.text = count.ToString();
    }

    protected override void OnDragDropRelease(GameObject surface)
    {
        

        base.OnDragDropRelease(surface);
        //print(surface);

        if(surface.tag == "cell")
        {
            this.transform.parent = surface.transform;
            this.transform.localPosition = Vector3.zero;
        } else if (surface.tag == "knapsack_item")
        {
            Transform tempTransform = this.transform.parent;
            this.transform.parent = surface.transform.parent;
            this.transform.localPosition = Vector3.zero;
            surface.transform.parent = tempTransform;
            surface.transform.localPosition = Vector3.zero;
        }
     
        
    }

}
