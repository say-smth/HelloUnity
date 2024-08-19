using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //멤버 변수 정의
    public string itemName;
    public int damage;
    public float attackSpeed;
    public bool isBroken;

    private void Awake()
    {
        Debug.Log("Awake 메서드 호출됨!");

        //공격력: damage(0)
        Debug.Log($"이름: {this.itemName}");
        Debug.Log($"공격력: {this.damage}");
        Debug.Log($"공격 속도: {this.attackSpeed}");
        Debug.Log($"파괴여부: {this.isBroken}");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start 메서드 호출됨!");
    }

    // Update is called once per frame
    void Update()
    {
        //컨트롤+k+c
        //컨트롤+k+u
        //Debug.Log("Update");
    }
}
