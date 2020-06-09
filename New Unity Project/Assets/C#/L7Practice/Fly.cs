using UnityEngine;

public class Fly : Monster
{
    [Header("飛行範圍"), Range (1,10)]
    public float range;

    /// <summary>
    /// 飛行
    /// </summary>
    private void Flying()
    {
        transform.Translate(0, range*Time.deltaTime*Mathf.Sin(Time.timeSinceLevelLoad*4), 0);
    }

    protected override void Update()
    {
        //保留父類別內容
        base.Update();
        Flying();
    }
}
