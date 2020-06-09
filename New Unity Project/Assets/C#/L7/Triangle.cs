using UnityEngine;

/// <summary>
/// 三角形 繼承 形狀
/// 三角形體積需要覆寫
/// </summary>
public class Triangle : Shapes
{
    public override float GetVolume()
    {
        volume = length * width * height / 2;
        return volume;
    }
    private void Start()
    {
        print(gameObject + "體積" + GetVolume());
    }

}
