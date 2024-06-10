using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingGood : MonoBehaviour
{
    public float speed = 5f; // Rychlost pohybu
    private GameObject player; // Reference na hráèe
    private Vector3 target; // Bod, ke kterému se bude pohybovat
    private bool dotkloSe = false;
    private GameObject boss;
    private bool dobry = true;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("PlayerFinalBoss");
        boss = GameObject.FindGameObjectWithTag("bossUp");
        target = player.transform.position;
    }

    void Update()
    {
        
        if (!dotkloSe)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            if (transform.position == target)
            {
                StartCoroutine(znicit());
            }
        }
        if (dotkloSe)
        {
            transform.position = Vector3.MoveTowards(transform.position, boss.transform.position, speed * Time.deltaTime);
            if (transform.position == boss.transform.position && dobry)
            {
                dobry = false;
                strileniOhne.HP--;
                Debug.Log(strileniOhne.HP);
                StartCoroutine(znicit());
            }
        }
    }
    private IEnumerator znicit()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<pohybmainboss>();
        if (player != null)
        {
            dotkloSe = true;
        }
    }
}
