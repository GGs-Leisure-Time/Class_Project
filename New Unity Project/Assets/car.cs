using UnityEngine;

//摘要：描述此內容，會在其他腳本內看到
/// <summary>
///
/// </summary>
public class car : MonoBehaviour
{
    //欄位field - 儲存物件資料
    //cc數 - 2000     - 整數int
    //重量 - 100.9    - 浮點數float
    //品牌 - BMW      - 字串string
    //煞車 - 是否開啟 - 布林值bool

    //定義欄位語法
    //資料類型 欄位名稱 (指定 值);
    //預設值 int、float=>0
    //string=>""
    //bool=>false
    int cc = 2000;
    float weight = 100.9f;
    string brand = "BMW";
    bool brake = false;
}
