using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> itemsGos;

    private void Awake()
    {
        //itemGos를 순회하면서 아이템들의 이름을 출력하고 싶다. 

        //장검
        //단검
        //활

        Debug.Log($"<color=yellow>{itemsGos.Count}</color>");
        
        for (int i = 0; i < itemsGos.Count; i++)
        {
            //Debug.Log($"{i} -> {this.itemsGos[i]}");

            GameObject itemGo = this.itemsGos[i];
            Item item=itemGo.GetComponent<Item>();
            Debug.Log($"{item.itemName}");
        }
    }

}
