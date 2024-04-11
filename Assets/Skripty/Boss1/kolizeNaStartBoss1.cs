using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kolizeNaStartBoss1 : MonoBehaviour
{
    public GameObject player;
    public Transform kamera;
    public GameObject hra;
    public GameObject ikona1;

    public static int pocet_zverokruhu = 0;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (player != null && SpawnWaves.dohranoBoss1 == false && pocet_zverokruhu >= 3)
        {
            movement.povoleno = false;
            kamera.position = new Vector3(81.9939957f, -69.5830002f, -7);
            ikona1.SetActive(false);
            hra.SetActive(true);
        }
    }
}
