using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pohybNoziky : MonoBehaviour
{
    public float speed = 5f; // Rychlost pohybu
    private GameObject player; // Reference na hráèe
    private Vector3 targetb;
    private Vector3 target; // Bod, ke kterému se bude pohybovat
    private bool dopohybu=false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("PlayerFinalBoss");
        targetb = player.transform.position;
        target = player.transform.position;
        if (transform.position.x < targetb.x)
        {
            target.x += 10f;
        }
        if (transform.position.x > targetb.x)
        {
            target.x -= 10f;
        }
        if (transform.position.y < targetb.y)
        {
            target.y += 10f;
        }
        if (transform.position.y > targetb.y)
        {
            target.y -= 10f;
        }
        StartCoroutine(pockej());
    }

    void Update()
    {
        
        if (dopohybu)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            if (transform.position == target)
            {
                StartCoroutine(znicit());
            }
        }
        
    }
    private IEnumerator znicit()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }
    private IEnumerator pockej()
    {
        yield return new WaitForSeconds(2f);
        dopohybu = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<pohybmainboss>();
        if (player != null)
        {
            HPSystem.HPplayer--;
            Destroy(gameObject);
        }
    }
}
