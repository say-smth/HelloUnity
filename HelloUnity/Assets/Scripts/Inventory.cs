using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> itemsGos;

    private void Awake()
    {
        //itemGos�� ��ȸ�ϸ鼭 �����۵��� �̸��� ����ϰ� �ʹ�. 

        //���
        //�ܰ�
        //Ȱ

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
