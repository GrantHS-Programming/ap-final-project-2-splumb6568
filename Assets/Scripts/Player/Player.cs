using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int startHp;
    int hp;
    public float bulletCooldown;
    float bulletTimer;

    public GameObject[] hearts;
    public int life;

    void Start()
    {
        hp = startHp;
    }
    void Update()
    {

        if (hp < 1)
        {
            Destroy(hearts[0].gameObject);
        }
        else if (hp < 2)
        {
            Destroy(hearts[1].gameObject);
        }
        else if (hp < 3)
        {
            Destroy(hearts[2].gameObject);
        }

        bulletTimer -= Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet" && bulletTimer <= 0)
        {
            hp -= 1;
            print(hp);
            bulletTimer = bulletCooldown;
        }
    }
}