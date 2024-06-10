using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportFinalBoss : MonoBehaviour
{
    public GameObject finalGame;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent <movement>();
        if (player != null) {
            movement.povoleno = false;
            KontrolaJestliJeHraZapnuta.ZapnutaHra = true;
            finalGame.SetActive(true);
            Destroy(player);
        }
    }
}
