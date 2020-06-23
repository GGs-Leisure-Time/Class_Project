using UnityEngine;
using System.Collections;

namespace KID.Class8
{
    public class Prop : MonoBehaviour, ICanUse
    {
        public Data data;

        public void Use()
        {
            print("撿到道具" + data.name);

            //啟動協同程序(協程方法)
            StartCoroutine(Big());
        }


        private IEnumerator Big()
        {
            Transform player = FindObjectOfType<Player>().transform;

            while (player.lossyScale.x < 3)
            {
                player.localScale += Vector3.one * 0.5f;
                yield return new WaitForSeconds(0.1f);
            }

            Destroy(gameObject);
        }
    }
}
