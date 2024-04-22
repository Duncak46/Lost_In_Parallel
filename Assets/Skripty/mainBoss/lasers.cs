using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lasers : MonoBehaviour
{
    public static bool movement;
    public static int kolikatyLaser = 0;
    //UI
    [SerializeField]
    private GameObject resetUI;

    //hrac
    [SerializeField]
    private GameObject player;
    public static int pozice = 5;

    //Destièky pro hráèe
    [SerializeField]
    private GameObject deska1;
    [SerializeField]
    private GameObject deska2;
    [SerializeField]
    private GameObject deska3;
    [SerializeField]
    private GameObject deska4;
    [SerializeField]
    private GameObject deska5;
    [SerializeField]
    private GameObject deska6;
    [SerializeField]
    private GameObject deska7;
    [SerializeField]
    private GameObject deska8;
    [SerializeField]
    private GameObject deska9;

    //Warningy
    [SerializeField]
    private GameObject warning1;
    [SerializeField]
    private GameObject warning2;
    [SerializeField]
    private GameObject warning3;
    [SerializeField]
    private GameObject warning4;
    [SerializeField]
    private GameObject warning5;
    [SerializeField]
    private GameObject warning6;

    //Lasery
    [SerializeField]
    private GameObject laser1;
    [SerializeField]
    private GameObject laser2;
    [SerializeField]
    private GameObject laser3;
    [SerializeField]
    private GameObject laser4;
    [SerializeField]
    private GameObject laser5;
    [SerializeField]
    private GameObject laser6;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpustitLasery());
        pozice = 5;
        kolikatyLaser = 0;
        laser1.SetActive(false);
        laser2.SetActive(false);
        laser3.SetActive(false);
        laser4.SetActive(false);
        laser5.SetActive(false);
        laser6.SetActive(false);
        movement = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (resetUI.activeSelf)
        {
            StopAllCoroutines();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (pozice != 3 && pozice < 10 && pozice > 0 || pozice != 6 && pozice < 10 && pozice > 0 || pozice != 9 && pozice < 10 && pozice > 0)
            {
                if (pozice != 9 && movement == true)
                {
                    pozice++;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (pozice != 1 && pozice < 10 && pozice > 0 || pozice != 2 && pozice < 10 && pozice > 0 || pozice != 3 && pozice < 10 && pozice > 0)
            {
                if (pozice > 3 && movement == true)
                {
                    pozice -= 3;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (pozice != 1 && pozice < 10 && pozice > 0 || pozice != 4 && pozice < 10 && pozice > 0 || pozice != 7 && pozice < 10 && pozice > 0)
            {
                if (pozice !=1 && movement == true)
                {
                    pozice--;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (pozice != 7 && pozice < 10 && pozice > 0 || pozice != 8 && pozice < 10 && pozice > 0 || pozice != 9 && pozice < 10 && pozice > 0)
            {
                if (pozice < 7 && movement == true)
                {
                    pozice += 3;
                }
            }
        }
        if (pozice == 1)
        {
            player.transform.position = deska1.transform.position;
        }
        if (pozice == 2)
        {
            player.transform.position = deska2.transform.position;
        }
        if (pozice == 3)
        {
            player.transform.position = deska3.transform.position;
        }
        if (pozice == 4)
        {
            player.transform.position = deska4.transform.position;
        }
        if (pozice == 5)
        {
            player.transform.position = deska5.transform.position;
        }
        if (pozice == 6)
        {
            player.transform.position = deska6.transform.position;
        }
        if (pozice == 7)
        {
            player.transform.position = deska7.transform.position;
        }
        if (pozice == 8)
        {
            player.transform.position = deska8.transform.position;
        }
        if (pozice == 9)
        {
            player.transform.position = deska9.transform.position;
        }
    }
    
    IEnumerator SpustitLasery()
    {
        yield return new WaitForSeconds(3f);
        //LASER1
        warning1.SetActive(true);
        warning2.SetActive(true);
        yield return new WaitForSeconds(2f);
        warning1.SetActive(false);
        warning2.SetActive(false);
        kolikatyLaser++;
        laser1.SetActive(true);
        laser2.SetActive(true);
        yield return new WaitForSeconds(2f);
        laser1.SetActive(false);
        laser2.SetActive(false);
        //LASER2
        warning4.SetActive(true);
        warning5.SetActive(true);
        yield return new WaitForSeconds(2f);
        warning4.SetActive(false);
        warning5.SetActive(false);
        kolikatyLaser++;
        laser4.SetActive(true);
        laser5.SetActive(true);
        yield return new WaitForSeconds(2f);
        laser4.SetActive(false);
        laser5.SetActive(false);
        //LASER3
        warning1.SetActive(true);
        warning3.SetActive(true);
        warning4.SetActive(true);
        warning6.SetActive(true);
        yield return new WaitForSeconds(2f);
        warning1.SetActive(false);
        warning3.SetActive(false);
        warning4.SetActive(false);
        warning6.SetActive(false);
        kolikatyLaser++;
        laser1.SetActive(true);
        laser3.SetActive(true);
        laser4.SetActive(true);
        laser6.SetActive(true);
        yield return new WaitForSeconds(2f);
        laser1.SetActive(false);
        laser3.SetActive(false);
        laser4.SetActive(false);
        laser6.SetActive(false);
        //LASER4
        warning2.SetActive(true);
        warning3.SetActive(true);
        warning5.SetActive(true);
        warning6.SetActive(true);
        yield return new WaitForSeconds(2f);
        warning2.SetActive(false);
        warning3.SetActive(false);
        warning5.SetActive(false);
        warning6.SetActive(false);
        kolikatyLaser++;
        laser2.SetActive(true);
        laser3.SetActive(true);
        laser5.SetActive(true);
        laser6.SetActive(true);
        yield return new WaitForSeconds(2f);
        laser2.SetActive(false);
        laser3.SetActive(false);
        laser5.SetActive(false);
        laser6.SetActive(false);
        //LASER5
        warning1.SetActive(true);
        warning2.SetActive(true);
        warning4.SetActive(true);
        warning6.SetActive(true);
        yield return new WaitForSeconds(2f);
        warning1.SetActive(false);
        warning2.SetActive(false);
        warning4.SetActive(false);
        warning6.SetActive(false);
        kolikatyLaser++;
        laser1.SetActive(true);
        laser2.SetActive(true);
        laser4.SetActive(true);
        laser6.SetActive(true);
        yield return new WaitForSeconds(2f);
        laser1.SetActive(false);
        laser2.SetActive(false);
        laser4.SetActive(false);
        laser6.SetActive(false);
        //LASER6
        warning1.SetActive(true);
        warning3.SetActive(true);
        warning4.SetActive(true);
        warning5.SetActive(true);
        yield return new WaitForSeconds(2f);
        warning1.SetActive(false);
        warning3.SetActive(false);
        warning4.SetActive(false);
        warning5.SetActive(false);
        kolikatyLaser++;
        laser1.SetActive(true);
        laser3.SetActive(true);
        laser4.SetActive(true);
        laser5.SetActive(true);
        yield return new WaitForSeconds(2f);
        laser1.SetActive(false);
        laser3.SetActive(false);
        laser4.SetActive(false);
        laser5.SetActive(false);
    }
    
    public void restart()
    {
        resetUI.SetActive(false);
        Start();
    }
}
