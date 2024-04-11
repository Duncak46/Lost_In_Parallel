using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spustitRyby : MonoBehaviour
{
    private bool muzu = true;
    [SerializeField]
    GameObject hra;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<movement>();
        if (player != null && loveniRyb.prut == true && muzu == true)
        {
            muzu = false;
            minihraRyby.zapnutoRyby = true;
            hra.SetActive(true);
        }
    }
}
