using UnityEngine;

public class Lesson3_Method : MonoBehaviour
{
    //prefab-->預製物:預先製作好的物品
    public Person person1;
    public Person person2;

    private void Start()
    {
        //呼叫person1方法Talk
        person1.Talk();
        person2.Talk();
        //傳回方法可以直接當作傳回類型使用
        print("HongKongAssHole BMI" + person1.BMI());
        print("Free HongKong BMI" + person2.BMI());
        //使用有參數的方法必須填入對應的引數
        person1.Walk(1, sound:"pongpong");
        person2.Walk(100,"左邊");

        person1.Attack();
        person2.Attack("棍棒");
    }

}
