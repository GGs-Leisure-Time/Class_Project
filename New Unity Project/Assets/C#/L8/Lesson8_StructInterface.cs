using UnityEngine;

public class Lesson8_StructInterface : MonoBehaviour
{
    //Unity 定義的結構 struct
    public Vector3 pos;

    //使用結構
    public Direction myDire1;

    public Direction myDire2 = new Direction(4);

    private void Start()
    {
        //使用結構成員
        //三維向量結構 方法成員
        pos.Set(1, 2, 3);

        //三維向量結構 欄位成員
        print("X座標：" + pos.x);

        //指定結構成員
        myDire1.direction = 1;

        //常數與靜態取得用法相同
        print("方向右邊的值：" + Direction.right);

        //常數無法變更
        //Direction.left = 5;
    }

    //類別一定要使用new 新增物件
    //結構可用可不用
    public Class_Data c_data1 = new Class_Data();
    public Struct_Data s_data1;

    //類別：參考型別 - 傳址
    public Class_Data c2 = new Class_Data("50", 99999, 100);
    public Class_Data c3 = new Class_Data("亮亮", 999999, 50);

    //類別：實質型別 - 傳址
    public Struct_Data s2 = new Struct_Data("50", 99999, 100);
    public Struct_Data s3 = new Struct_Data("亮亮", 99999, 50);

    private void Awake()
    {
        c_data1.name = "50大大";
        print(c_data1.name);        
        s_data1.name = "KID";
        print(s_data1.name);

        //c2=c3 兩筆資料 地址 相同
        //修改c2等於修改c3
        c2 = c3;
        c2.name = "50";

        //s2=s3 兩筆資料 數值 相同
        //修改s2不會修改s3
        s2 = s3;
        s2.name = "50";

    }


}
