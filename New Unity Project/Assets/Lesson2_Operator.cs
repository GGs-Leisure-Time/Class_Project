using UnityEngine;

public class Lesson2_Operator : MonoBehaviour
{
    public float a = 10;
    public float b = 3;

    public string c = "7";
    public int d = 3;

    public int e = 99;
    public int f = 9;

    public bool g = true;
    public bool h = false;

    public int key;
    public int result;

    public int hp = 100;
    private void Start()
    {
        #region 運算子

        #region 數學運算子
        //數學運算子：加減乘除餘+-*/%
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);

        //加法：串接字串與其他資料 - 結果為字串
        print("分數:" + 99.9f);
        //將字串與數值類型串接後不會進行運算 - 其結果為字串
        print(c + d);
        #endregion

        #region 比較運算子
        //比較運算子：結果為布林值，成立時true，不成立時false
        //大於、小於、大於等於、小於等於、等於、不等於
        // > < >= <= == !=
        print(e > f);
        print(e < f);
        print(e >= f);
        print(e <= f);
        print(e == f);
        print(e != f);
        #endregion

        #region 邏輯運算子
        //邏輯運算子：結果為布林值 - 比較兩個布林值
        //並且：&& 只要有一個false 結果為 false
        print("並且：" + (g && h));
        //或者 || 只要有一個true 結果為 true (SHIFT+\)
        print("或者：" + (g || h));

        print(true && true);
        print(true && false);
        print(false && true);
        print(false && false);

        print(true || true);
        print(true || false);
        print(false || true);
        print(false || false);
        #endregion

        #region 顛倒運算子
        //顛倒運算子!：加在布林值前 - 將布林值的結果改為顛倒的結果
        print(!true);
        print(!false);
        #endregion

        #region 指定運算子
        //指定運算子 - 右邊先運算在指定給左邊
        result = 2 + 3;
        print(result);

        key = key + 1;
        print("鑰匙：" + key);
        #endregion

        #region 遞增遞減運算子
        //後置遞增x++：先輸出後遞增
        print("鑰匙數量：" + key++);
        //前置遞增++x：先遞增後輸出
        print("鑰匙數量：" + ++key);
        //前後置遞減同遞增--
        #endregion

        #region 複合指派運算子
        //複合指派運算子：只適用於數學運算子，省略數學運算
        //+=、-=、*=、/=、%=
        //原運算：hp = hp + 20 結果為120
        hp += 20;
        print("血量：" + hp);
        #endregion

        #endregion
    }
}
