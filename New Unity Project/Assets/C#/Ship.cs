﻿
using UnityEngine;

public class Ship : MonoBehaviour
{
    //公開欄位：給任何人存取
    //從其他類別取得或存放資料
    public float speed = 20;

    //私人欄位：僅限於此類別存取
    //從其他類別無法取得或存放資料
    private float weight = 50;

    //假設需要取得但是不能修改 - 屬性(權限)
    //屬性語法：修飾詞 類型 名稱{存取權限}
    //get可以取得 set可以存放
    //讀寫權限屬性
    //屬性不會顯示在屬性面板上(ODIN) - UnutyEditor
    public float lengh { get; set; }

    //企劃：寬度固定30不變
    //封裝欄位：
    //1.私人欄位 2.唯讀屬性(return私人欄位)
    private float _width = 30;
    //唯讀屬性：不能設定值
    public float width { get { return _width; } }


    //企劃：寬度固定10.5不變
    private float _height = 10.5f;

    //=> (黏巴達 Lambda)
    //C# 6 版以上 -->Unity 2017開始用 C# 7版
    //get => _height; 等同 { get; { return _hidth; } }
    public float height { get => _height; }


    private float lv = 3;

    //企劃：攻擊力=攻擊基值*等級
    //1.私人欄位 2.透過屬性存取(return 私人欄位) { 私人欄位 = value}
    //value 設定屬性時給予的值
    private float _atk;
    public float atk { get { return _atk; } set { _atk = value * lv; } }

    //使用快速完成的黏巴達
    private float _def;
    public float def { get => _def; set => _def = value*lv; }

}
