using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strileniOhne : MonoBehaviour
{
    //PRVNI
    public GameObject warningPrefab; // Prefab pro warning symbol
    public GameObject stonkPrefab; // Prefab pro stonk
    public Transform player; // Reference na hráèe

    //DRUHA
    public GameObject strelaPrefab;
    public GameObject bossLeft;
    public GameObject bossRight;
    public GameObject bossUp;

    //TRETI
    public GameObject Noze;

    //CTVRTA
    public GameObject strelaPrefabDobra;

    public float stonkSpeed = 5f; // Rychlost stonku
    public float warningDuration = 0.75f; // Doba zobrazení warning symbolu
    public float stonkDuration = 2f; // Doba existence stonku
    private bool spusteno = true;
    public static int HP = 5;
    void Update()
    {
        if (HP <=0)
        {
            Debug.Log("Win");
            //Nastavit na scenu s koncem
        }
        if (StartFase2.naMisteUp == true && spusteno)
        {
            StartCoroutine(ShootStonks());
            spusteno = false;
        }
    }

    //PRVNI FAZE
    private IEnumerator ShootStonks()
    {
        for (int a = 0; a < 9; a++)
        {
                for (int i = 0; i < 8; i++)
                {
                    StartCoroutine(strela());
                    yield return new WaitForSeconds(0.20f);
                }
                yield return new WaitForSeconds(Random.Range(1f, 3f));
        }
        StartFase2.faze1 = false;
        StartFase2.faze2 = true;
        yield return new WaitForSeconds(3f);
        StartCoroutine(Shootohen());
    }
    private IEnumerator strela()
    {
        GameObject warning = Instantiate(warningPrefab, player.position, Quaternion.identity);
        yield return new WaitForSeconds(warningDuration);
        GameObject stonk = Instantiate(stonkPrefab, warning.transform.position, Quaternion.identity);
        Destroy(warning);
        yield return new WaitForSeconds(stonkDuration);
        Destroy(stonk);
    }
    //DRUHA FAZE
    private IEnumerator Shootohen()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(strelaPrefab, bossLeft.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.35f);
            Instantiate(strelaPrefab, bossRight.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.45f);
        }
        StartFase2.faze2 = false;
        StartFase2.faze3 = true;
        yield return new WaitForSeconds(3f);
        StartCoroutine(Nozicky());
    }
    private IEnumerator Nozicky()
    {
        for (int i = 0; i < 8; i++)
        {
            Instantiate(Noze, player.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2.5f);
        }
        StartFase2.faze4 = true;
        yield return new WaitForSeconds(3f);
        StartCoroutine(DobrySpatny());
    }
    private IEnumerator DobrySpatny()
    {
        for (int i = 0; i < 20; i++)
        {
            int x = Random.Range(1, 4);
            GameObject ohen;
            if (x == 1)
            {
                ohen = strelaPrefabDobra;
            }
            else
            {
                ohen = strelaPrefab;
            }
            Instantiate(ohen, bossUp.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
        StartFase2.faze3 = false;
        StartFase2.faze4 = false;
        StartFase2.faze1 = true;
        yield return new WaitForSeconds(3f);
        spusteno = true;
    }
}

