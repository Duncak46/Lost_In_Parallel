using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnWaves : MonoBehaviour
{
    public GameObject hracVenku;
    public static bool dohranoBoss1 = false;

    public GameObject orb;
    public GameObject Ikony;
    public GameObject pavouk1Prefab;
    public GameObject pavouk2Prefab;
    public GameObject pavoukBossPrefab;
    public Transform kamera;

    public static int WhichWave = 0;
    public static bool zapnoutbossstrileni = true;

    public static int zabitoEnemy;

    public static bool stop = false;

    void Start()
    {
        stop = false;
    }
    void Update()
    {
        if (zapnoutbossstrileni == true && WhichWave == 0)
        {
            WhichWave = 1;
        }
        if (WhichWave == 1 && stop == false)
        {
            StartCoroutine(SpawnEnemy(30, pavouk1Prefab));
            stop = true;
        }
        else if(WhichWave == 2 && stop == false)
        {
            StartCoroutine(SpawnEnemy(20, pavouk2Prefab));
            stop = true;
        }
        else if (WhichWave == 3 && stop == false)
        {
            StartCoroutine(SpawnEnemy(1, pavoukBossPrefab));
            stop = true;
        }
        if (zabitoEnemy >= 51)
        {
            kamera.position = new Vector3(-4.32999992f, 0.200000003f, -7);
            movement.povoleno = true;
            Ikony.SetActive(true);
            zapnoutbossstrileni = false;
            hracVenku.transform.position = new Vector3(56.7799988f, 7.05000019f, 0);
            kamera.transform.position = new Vector3(56.7799988f, 7.05000019f, -10f);
            dohranoBoss1 = true;
            ListUkolu.kolikUkolu--;
            ListUkolu.promenaDoIf = ListUkolu.jakejtext_ukolZverokruh;
            ListUkolu.ukoltexty[ListUkolu.jakejtext_ukolZverokruh].text = "";
            orb.SetActive(true);
            ListUkolu.ukoltexty[ListUkolu.jakejtext_ukolorby].text = "Posbírej a vlož orby do monumentu" + ListUkolu.pocet_orbu + "/3";
            ListUkolu.UpravitUkoly();
            gameObject.SetActive(false);
        }
    }

    IEnumerator SpawnEnemy(int kolikEnemy, GameObject jakyEnemy)
    {
        
        if (WhichWave == 1 || WhichWave == 2)
        {
            for (int i = 0; i < kolikEnemy/2; i++)
            {
                yield return new WaitForSeconds(1.5f);
                //90 nebo 70 X a -65 až -75 Y
                int random = Random.Range(1, 2);
                float posYspawn = Random.Range(-65, -75);
                float posXspawn = 90;
                Vector2 poziceNaSpawn = new Vector2(posXspawn, posYspawn);
                GameObject spawnedPrefab = Instantiate(jakyEnemy, poziceNaSpawn, Quaternion.identity);

                //druhej
                
                posYspawn = Random.Range(-65, -75);
                posXspawn = 70;
                Vector2 poziceNaSpawn2 = new Vector2(posXspawn, posYspawn);
                GameObject spawnedPrefab2 = Instantiate(jakyEnemy, poziceNaSpawn2, Quaternion.identity);
            }
        }
        if (WhichWave == 3)
        {
            GameObject Boss = Instantiate(jakyEnemy, new Vector2(70.62f, -63.09f), Quaternion.identity);
        }
        yield return new WaitForSeconds(7f);
        WhichWave++;
        stop = false;
    }
}
