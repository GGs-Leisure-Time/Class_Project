using UnityEngine;

public class Lesson6_Practice : MonoBehaviour
{
    public SpriteRenderer GG;

    public Rigidbody ball;
    private void Start()
    {
        Time.timeScale = 5;

        GG.flipX = true;

        print(Mathf.Floor(1.23456f));

        ball.AddForce(0, 800, 1200);
    }
}
