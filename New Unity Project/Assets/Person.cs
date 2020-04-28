using UnityEngine;

public class Person : MonoBehaviour
{
    [Header("身高")]
    public float height;
    [Header("體重")]
    public float weight;

    //定義方法語法：修飾詞　傳回類型　方法名稱　（參數）｛陳述式｝
    // void 無傳回：當使用此方法時不會得到任何回傳資料   
    public void Talk()
    {
        //gameObject 套用腳本物件
        //gameObject.name 套用此腳本的物件名稱
        print("Hi! I'm Talking, I'm" + gameObject.name);
    }
    //回傳方法
    /// <summary>
    /// 計算BMI
    /// </summary>>
    /// <returns>計算完的BMI</returns>
    public float BMI()
    {
        //BMI
        float result = weight / ((height / 100) * (height / 100));
        //傳回 return
        return result;
    }
    //參數語法: 類型 名稱 指定 預設值
    //有預設值的參數為[選填式參數] - 可不填，值為預設值
    //選填式參數必須定義在最右邊
    /// <summary>
    /// 走路方法
    /// </summary>
    /// <param name="speed"></param>
    public void Walk(int speed, string direction = "前方", string sound = "DODO")
    {
        print(gameObject.name + "時速" + speed + "公里/小時");
        print("走路聲音：" + sound);
        print("走路方向：" + direction);

    }
    //多載Overload，適用情況
    //1.相同名稱的方法
    //2.參數數量不同 或者 參數類型不同
    /// <summary>
    /// 徒手攻擊
    /// </summary>
    public void Attack()
    {
        print(gameObject.name + "徒手攻擊!");
    }
    /// <summary>
    /// 使用武器攻擊
    /// </summary>
    /// <param name="weapon"></param>
    public void Attack(string weapon)
    {
        print(gameObject.name + "用武器：" + weapon + "攻擊");
        print("Attack Sound");

    }

    //讓UNITY 按鈕Button 使用方法條件：
    //1.修飾詞為公開public
    //2.參數數量小於等於1
    public void Skill()
    {
        print(gameObject.name + "施放技能!");
    }
}
