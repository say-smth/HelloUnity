using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //��� ���� ����
    public string itemName;
    public int damage;
    public float attackSpeed;
    public bool isBroken;

    private void Awake()
    {
        Debug.Log("Awake �޼��� ȣ���!");

        //���ݷ�: damage(0)
        Debug.Log($"�̸�: {this.itemName}");
        Debug.Log($"���ݷ�: {this.damage}");
        Debug.Log($"���� �ӵ�: {this.attackSpeed}");
        Debug.Log($"�ı�����: {this.isBroken}");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start �޼��� ȣ���!");
    }

    // Update is called once per frame
    void Update()
    {
        //��Ʈ��+k+c
        //��Ʈ��+k+u
        //Debug.Log("Update");
    }
}
