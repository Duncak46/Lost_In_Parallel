using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pohybOhne : MonoBehaviour
{
    public float speed = 5f; // Rychlost pohybu
    private GameObject player; // Reference na hráèe
    private Vector3 target; // Bod, ke kterému se bude pohybovat

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("PlayerFinalBoss");
        
        target = player.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position == target)
        {
            StartCoroutine(znicit()); 
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
            Debug.Log("odebralo se ti HP!");
            Destroy(gameObject);
        }
    }
}
