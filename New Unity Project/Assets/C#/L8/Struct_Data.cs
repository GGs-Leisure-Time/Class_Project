﻿using UnityEngine;

//序列化：讓類別顯示在屬性面板
[System.Serializable]
public struct Struct_Data
{
    public string name;
    public int coin;
    public float hp;

    //結構內不能有無參數的建構子

    /*
    public Struct_Data()
    {
        Debug.Log("空白建構子");
    }
    */

    public Struct_Data(string n, int c, float h)
    {
        name = n;
        coin = c;
        hp = h;
    }

}
