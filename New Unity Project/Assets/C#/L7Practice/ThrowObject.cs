using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    [Header("傷害"), Range(10, 500)]
    public float damage;
    [Header("爆炸效果")]
    public GameObject explosion;

    private void Explosion()
    {
        GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
        //2.5秒後刪除爆炸效果
        Destroy(exp, 0.6f);
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
