
using UnityEngine;

public class Lesson9_DelegateEvent : MonoBehaviour
{
    public void AddTen(int Number)
    {
        int n = Number += 10;
        print("數字累加10:" + name);
    }

    public int number1 = 1;

    private void Awake()
    {
        AddTen(9);
        AddTen(number1);
    }

    public void MethodA()
    {
        print("方法A");
    }
    public void MethodB()
    {
        print("方法B");
    }    public void MethodC(string msg)
    {
        print("方法C");
    }

    //定義委派
    //可以儲存 無傳回、無參數的任何方法
    public delegate void DelegateTest();

    //可以儲存 無傳回 一個字串參數的任何方法
    public delegate void DelegateTest2(string s);

    //定義委派欄位
    public DelegateTest dA;
    public DelegateTest dB;
    public DelegateTest dC;

    public DelegateTest2 d2C;

    private void Start()
    {
        //dA欄位儲存方法A
        dA = MethodA;
        dA();

        dB = MethodB;
        dB();

        d2C = MethodC;
        d2C("委派");
    }
}
