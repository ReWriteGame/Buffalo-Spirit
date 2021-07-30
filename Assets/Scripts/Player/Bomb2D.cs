using UnityEngine;
using UnityEngine.Events;
using System.Collections;

[RequireComponent(typeof(Collider2D))]
public class Bomb2D : MonoBehaviour
{
    public UnityEvent onExplosion;

    private Collider2D coll;

    private void Start()
    {
        coll = GetComponent<Collider2D>();
        //coll.isTrigger = true;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Destroyable>())
        {
            onExplosion.Invoke();
            collision.gameObject.GetComponent<Destroyable>().destroy(0.2f);
        }
    }
    public void actionsAfterGetting()
    {
        print("Get Coin.");
    }
}
