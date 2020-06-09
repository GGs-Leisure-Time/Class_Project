using UnityEngine;

public class Far : Monster
{
    [Header("停止距離"), Range(0,10)]
    public float stopDistance;
    [Header("物品")]
    public GameObject prop;
    [Header("丟擲間隔時間")]
    public float cd;
    [Header("死亡時間"), Range(3,7)]
    public float deadTime;

    /// <summary>
    /// 目標物件
    /// </summary>
    private Transform target;

    /// <summary>
    /// 計時器
    /// </summary>
    private float timer;

    /// <summary>
    /// 繪製圖示事件：在Scene繪製圖示，遊戲內不會顯示
    /// </summary>
    private void OnDrawGizmos()
    {
        //圖示.顏色 = 顏色(紅,綠,藍,透明)
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        //圖示.繪製標籤(起點,終點)
        Gizmos.DrawLine(transform.position, transform.position + transform.right * stopDistance);
    }

    private void Start()
    {
        //遊戲物件.尋找("物件名稱").變形元件
        target = GameObject.Find("house").transform;
    }

    protected override void Update()
    {
        base.Update();
        Throw();
    }

    /// <summary>
    /// 丟擲
    /// </summary>
    private void Throw()
    {
        //距離 = 三維向量.距離(此物件座標,目標座標)
        float dis = Vector3.Distance(transform.position, target.position);

        if (dis <= stopDistance)
        {
            speed = 0;

            timer += Time.deltaTime;
            //如果 計時器>=cd
            if (timer >= cd)
            {
                timer = 0;
                GameObject temp = Instantiate(prop, transform.position + transform.right + transform.up, Quaternion.identity);
                temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(300, 150));
                //將遠距離傷害值賦予丟擲物品
                temp.GetComponent<ThrowObject>().damage = damage;
            }

            //延遲呼叫方法("方法名稱",延遲時間)
            Invoke("Explosion", deadTime);
        }
    }
}
