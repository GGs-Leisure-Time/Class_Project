using UnityEngine;

public class Lesson6_PropArrayEnum : MonoBehaviour
{
    public Enemy zombie01, zombie02;

    //修飾詞 非靜態成員類別 物件名稱
    public GameObject obj1;
    public Light myLight;
    public Transform tran1;

    private void Start()
    {
        //一般欄位-->取得方式：物件.欄位
        print(zombie01.name + "血量" + zombie01.hp);
        print(zombie02.name + "血量" + zombie02.hp);
        //靜態欄位-->取得方式：類別.靜態欄位
        print("僵屍的速度：" + Enemy.speed);

        //無法透過物件取得靜態欄位(常見錯誤)
        //   print(zombie01.speed); (錯誤)  print(Enemy.speed); (正確)

        //使用一般方法-->物件.方法
        zombie01.Walk();
        zombie02.Walk();

        //使用靜態方法-->類別.靜態方法
        Enemy.Stop();

        //存放 靜態屬性 -->類別.靜態屬性= 值
        //Cursor.visible 隱藏鼠標 (布林值)
        Cursor.visible = false;

        //取得靜態屬性
        print(Mathf.PI);

        //取得隨機.值
        print(Random.value);

        //使用靜態方法-->類別.靜態方法(對應的引數)
        print("絕對值：" + Mathf.Abs(-1.05f));

        print("隨機範圍：" + Random.Range(1f, 100f));

        //回傳整數時不會回傳最大值
        print("隨機範圍：" + Random.Range(1, 3));

        //靜態屬性與非靜態屬性區別
        //靜態屬性不須新增欄位 Random.value
        //非靜態屬性須新增欄位 public GameObject obj1; obj1.layer;
        
        //非靜態屬性 --> 物件名稱.非靜態屬性
        print("物件圖層：" + obj1.layer);
        //非靜態 需要有實體物件 存在遊戲場景內的物件
        print("燈光顏色" + myLight.color);

        //tran1.localScale = new Vector3(5, 5, 5,);
        tran1.localScale = Vector3.one * 5;

        
    }

    private void Update()
    {
        print("玩家是否按空白鍵：" + Input.GetKeyDown("space"));
        print("玩家是否按右鍵：" + Input.GetKeyDown(KeyCode.Mouse1));

        tran1.Rotate(0, 0, 10* Time.deltaTime);
    }

}
