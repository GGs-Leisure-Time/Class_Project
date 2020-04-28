using UnityEngine;
using UnityEngine.UI;
using System;
//引用 Unity 介面 命名空間
//引用 系統 命名空間(系統 API 字串轉整數)
public class Practice_Lesson2and3 : MonoBehaviour
{
    //儲存兩筆數字
    public string number1;
    public string number2;

    [Header("文字：輸出結果")]
    public Text result;

    /// <summary>
    ///給第一個欄位使用 
    /// </summary>
    /// <param name="number">第一個欄位數值</param>
    public void InputNumber1(string number)
    {
        number1 = number;
    }
    /// <summary>
    ///給第二個欄位使用 
    /// </summary>
    /// <param name="number">第二個欄位數值</param>
    public void InputNumber2(string number)
    {
        number2 = number;
    }

    /// <summary>
    /// 加法
    /// </summary>
    public void Add()
    {
        //Int32.Parse(字串) - 將字串轉為整數
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        print("結果：" + ( n1 + n2 ));

        //輸出結果.文字內容 =
        result.text = "結果：" + (n1 + n2);
    }

    public void Sub()
    {
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        print("結果：" + (n1 - n2));

        //輸出結果.文字內容 =
        result.text = "結果：" + (n1 - n2);
    }

    public void Mul()
    {
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        print("結果：" + (n1 * n2));

        //輸出結果.文字內容 =
        result.text = "結果：" + (n1 * n2);
    }
        public void Div()
    {
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        print("結果：" + (n1 / n2));

        //輸出結果.文字內容 =
        result.text = "結果：" + (n1 / n2);
    }
    public void Rem()
    {
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        print("結果：" + (n1 % n2));

        //輸出結果.文字內容 =
        result.text = "結果：" + (n1 % n2);
    }

}
