using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFase2 : MonoBehaviour
{
    //Horni lebka
    public GameObject SkullUp;
    public Transform posSUp;
    public Transform posFUp;
    //Leva Lebka
    public GameObject SkullLeft;
    public Transform posSLeft;
    public Transform posFLeft;
    //Prava Lebka
    public GameObject SkullRight;
    public Transform posSRight;
    public Transform posFRight;

    //OHNE A MECE
    public GameObject kruh;
    public GameObject OhenLong;
    public GameObject OhenGood;
    public GameObject OhenBad;
    public GameObject Warning;

    //pomocnyPromeny
    private float moveSpeed = 5f;
    private bool faze1 = false;
    private bool faze2 = false;
    private bool faze3 = false;
    private bool faze4 = false;
    // Start is called before the first frame update
    void Start()
    {
      
        StartCoroutine(FaZe1());
    }

    // Update is called once per frame
    void Update()
    {
        //Faze1
        if (faze1 || faze3)
        {
            SkullUp.transform.position = Vector3.MoveTowards(SkullUp.transform.position, posFUp.position, moveSpeed * Time.deltaTime);
        }
        else
        {
            SkullUp.transform.position = Vector3.MoveTowards(SkullUp.transform.position, posSUp.position, moveSpeed * Time.deltaTime);
        }
        //Faze2
        if (faze2 && SkullUp.transform.position == posSUp.position)
        {
            SkullLeft.transform.position = Vector3.MoveTowards(SkullLeft.transform.position, posFLeft.position, moveSpeed * Time.deltaTime);
            SkullRight.transform.position = Vector3.MoveTowards(SkullRight.transform.position, posFRight.position, moveSpeed * Time.deltaTime);
        }
        if (faze2 == false)
        {
            SkullLeft.transform.position = Vector3.MoveTowards(SkullLeft.transform.position, posSLeft.position, moveSpeed * Time.deltaTime);
            SkullRight.transform.position = Vector3.MoveTowards(SkullRight.transform.position, posSRight.position, moveSpeed * Time.deltaTime);
        }
        //faze3 a 4 se volá v první fázi

       
    }
    IEnumerator FaZe1()
    {
        yield return new WaitForSeconds(3f);
        faze1 = true;
    }
}
