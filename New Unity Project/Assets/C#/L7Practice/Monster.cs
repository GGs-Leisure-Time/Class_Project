using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("移動速度"),Range(0,100)]
    public float speed;
    [Header("傷害"),Range(10,500)]
    public float damage;
    [Header("爆炸效果")]
    public GameObject explosion;

    /// <summary>
    /// 移動
    /// </summary>
    protected void Move()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    protected void Explosion()
    {
        GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
        //2.5秒後刪除爆炸效果
        Destroy(exp, 0.6f);
    }

    private void Awake()
    {
        //物理2D忽略碰撞(async,base)ab之間忽略碰撞
        Physics2D.IgnoreLayerCollision(8, 8);
    }

    protected virtual void Update()
    {
        Move();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "house")
        {
            collision.gameObject.GetComponent<House>().Damage(damage);
            Explosion();
        }
    }
}
