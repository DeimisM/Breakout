using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField]public int hp = 1;

    public void Damage()
    {
        hp--;

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
