using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BombHero2D : MonoBehaviour
{
    public UnityEvent onExplosion;

    private Collider2D coll;

    private void Start()
    {
        coll = GetComponent<Collider2D>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Hero>())
            onExplosion.Invoke();
    }
    public void actionsAfterGetting()
    {
        print("Get Coin.");
    }
}
