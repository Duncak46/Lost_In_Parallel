using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startBoss3 : MonoBehaviour
{
    public GameObject hra;
    public GameObject hraCanvas;
    static bool uzzapnuto = false;
    public GameObject kamera;
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
            movement.povoleno = false;
            kamera.transform.position = new Vector3(-98.49f, 51.79f, -5.375148f);
            uzzapnuto = true;
            hra.SetActive(true);
            hraCanvas.SetActive(true);
        }
    }
}
