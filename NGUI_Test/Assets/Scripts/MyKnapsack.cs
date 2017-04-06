using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyKnapsack : MonoBehaviour {

    
    public GameObject[] cells;
    public GameObject item;
    public string[] equipmentNames;
    
    public void PickUp()
    {

        int index = Random.Range(0, equipmentNames.Length);
        string name = equipmentNames[index];
        bool isFind = false;

        foreach(GameObject cell in cells)
        {
            if (cell.transform.childCount != 0)
            {
                KnapsackItem currentItem = cell.GetComponentInChildren<KnapsackItem>();
                string currentName = currentItem.GetComponent<UISprite>().spriteName;
                if (currentName == name)
                {
                    isFind = true;
                    UILabel label = currentItem.GetComponentInChildren<UILabel>();
                    currentItem.AddCount(1);
                    return;
                }
            }
        }
        if(isFind == false)
        {
            foreach (GameObject item in cells)
            {
                if (item.transform.childCount == 0)
                {
                    GameObject go = NGUITools.AddChild(item, this.item);
                    go.GetComponent<UISprite>().spriteName = name;
                    go.transform.localPosition = Vector3.zero;
                    return;
                }
            }
        }
        
    }
}
