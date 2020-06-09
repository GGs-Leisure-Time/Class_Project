using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    [Header("怪物陣列 0狐狸 1 老鷹 2 老鼠 3青蛙")]
    public GameObject[] monsters;

    /// <summary>
    ///生成怪物 
    /// </summary>
    /// <param name="index"></param>
    public void CreateMonster(int index)
    {
        Instantiate(monsters[index], new Vector3(-10, 2, 0), Quaternion.identity);
    }
}
