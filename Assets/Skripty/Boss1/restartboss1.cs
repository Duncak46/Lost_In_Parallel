using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restartboss1 : MonoBehaviour
{
    public GameObject hra;
    public void Restart()
    {
        SpawnWaves.zabitoEnemy = 0;
        SpawnWaves.WhichWave = 0;
        hra.SetActive(true);
        SpawnWaves.stop = false;
        gameObject.SetActive(false);
    }
}
