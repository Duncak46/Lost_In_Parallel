using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    public int HP;
    public float speed;
    private GameObject player;
    private Rigidbody2D rb;
    private GameObject hra;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player2");
        if (player != null)
        {
            // Získej smìr ke hráèi
            Vector2 direction = (player.transform.position - transform.position).normalized;

            // Pohybuj nepøítele v tomto smìru
            rb.MovePosition(rb.position + direction * speed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        

        //kolize Bullet
        var bullet = GameObject.FindGameObjectWithTag("bulletBoss");
        if (bullet != null)
        {
            Destroy(bullet);
            HP--;
            if (HP <= 0)
            {
                SpawnWaves.zabitoEnemy++;
                Destroy(gameObject);
            }
        }
    }
}
