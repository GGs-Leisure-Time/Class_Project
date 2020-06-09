using UnityEngine;

public class Enemy : MonoBehaviour
{
    //一般欄位(非靜態)-->屬於物件：可個別調整數值
    public float hp;
    //靜態欄位-->屬於類別：所有物件共用
    public static float speed = 3;

    public void Walk()
    {
        //一般方法-->非靜態欄位適用
        print(name + "走路中");
    }

    public static void Stop()
    {
        //靜態方法-->只能存取靜態欄位成員
        speed = 0;
        print("所有怪物的速度：" + speed);
    }
}
