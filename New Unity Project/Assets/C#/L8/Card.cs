using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IBeginDragHandler, IDragHandler,IEndDragHandler,ISkill
{
    private Vector3 pos;

    public void OnBeginDrag(PointerEventData eventData)
    {
        print("開始拖拉");
        //紀錄原始座標
        pos = transform.position;   
    }
    public void OnDrag(PointerEventData eventData)
    {
        print("拖拉中");
        //座標 = 拖拉事件.座標
        transform.position = eventData.position;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        print("拖拉結束");
        //回到原始座標
        transform.position = pos;
    }

    public void SkillEffect()
    {
        print("技能特效");
    }

}
