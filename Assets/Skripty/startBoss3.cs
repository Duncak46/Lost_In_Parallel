using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startBoss3 : MonoBehaviour
{
    public GameObject hra;
    static bool uzzapnuto = false;
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
        var player = collision.gameObject.GetComponent<movement>();
        if (player != null && uzzapnuto == false)
        {
            uzzapnuto = true;
            hra.SetActive(true);
        }
    }
}
