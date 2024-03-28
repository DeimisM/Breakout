using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int hp = 1;

    public void Damage()
    {
        hp--;

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var brick = collision.gameObject.GetComponent<Brick>();

        if (brick != null)
        {
            brick.Damage();
        }
    }
}
