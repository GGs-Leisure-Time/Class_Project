
using UnityEngine;

public class Class4_PropArrayEnum : MonoBehaviour
{
    public Ship ship;

    private void Start()
    {
        //設定屬性
        ship.lengh = 99.9f;
        //取得屬性
        print("船的長度：" + ship.lengh);

        //設定唯讀屬性
        //ship.width = 20.5f; -->錯誤，因為width是唯讀屬性
        //取得唯讀屬性
        print("船的寬度：" + ship.width);

        ship.atk = 50.3f;
        print("船的攻擊力：" + ship.atk);
    }

}
