﻿using UnityEngine;  //using表引用UNITY API(函式庫:Unity屬性、功能)

//class 類別
//語法：class 類別名稱
// MonoBehaviour 可以將此腳本掛在Unity物件上
public class Class1 : MonoBehaviour
{
    //定義類別成員
    //C#
    //1.大小寫
    //2.括號成對出現()[]{}''""<>

    [Header("CAR01")]
    public car car1;
    [Header("Car02")]
    public car car2;


    //Event：在特定時間會以指定次數執行的方法、功能(藍色名稱)
    //開始事件：播放遊戲時執行一次－初始設定
    private void Start()
    {
        print("Hello World");

        //取得 get
        print("CAR01的CC數" + car1.cc);
        print("CAR02的重量" + car2.weight);
        //設定 set
        car1.cc = 400;
        car1.weight = 180;
        car1.brand = "Nisson";
        car1.brake = true;

    }
}
