using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnapsackItem : UIDragDropItem {

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
