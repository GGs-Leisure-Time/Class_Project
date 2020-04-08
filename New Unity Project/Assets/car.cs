using UnityEngine;

//摘要：描述此內容，會在其他腳本內看到
//新增的C#放在專案內為藍圖
//放在場景物件上為實體物件
/// <summary>
/// 定義汽車物件
/// </summary>
public class car : MonoBehaviour
{
    //欄位field - 儲存物件資料
    //cc數 - 2000     - 整數int
    //重量 - 100.9    - 浮點數float
    //品牌 - BMW      - 字串string
    //煞車 - 是否開啟 - 布林值bool

    //定義欄位語法
    //修飾詞 資料類型 欄位名稱 (指定 值);
    //公開 public 允許其他類別存取-顯示在屬性面板(Inspector)
    //私人 private (預設) 不允許、不顯示
    //預設值 int、float=>0
    //string=>""
    //bool=>false
    //欄位屬性 Attribute：Unity用於輔助欄位的功能
    //語法：[屬性名稱(值)]
    //標題 [Header("字串")]
    //提示 [Tooltip("字串")]
    //範圍 [Range(最小值,最大值)]

    /// <summary>
    /// 汽車的CC數
    /// </summary>
    [Header("汽車CC數"), Range(500,5000)]
    public int cc = 2000;
    /// <summary>
    /// 汽車的重量
    /// </summary>
    [Header("汽車重量"), Tooltip("汽車的總重量"), Range(50,350)]
    public float weight = 100.9f;
    /// <summary>
    /// 汽車的品牌
    /// </summary>
    [Header("品牌")]
    public string brand = "BMW";
    /// <summary>
    /// 是否煞車
    /// </summary>
    [Header("剎車"), Tooltip("汽車目前是否處於剎車狀態")]
    public bool brake = false;
}
