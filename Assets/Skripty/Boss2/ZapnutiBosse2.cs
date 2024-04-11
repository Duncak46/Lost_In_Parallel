using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZapnutiBosse2 : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Hra;
    public static bool zapnutaBoss2 = false;
    public GameObject Ikony;
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
        if (player != null &&zapnutaBoss2 == false)
        {
            movement.povoleno = false;
            movementPlayer2.hraZapnuta2 = true;
            zapnutaBoss2 = true;
            Hra.SetActive(true);
            Ikony.SetActive(false);
            Camera.transform.position = new Vector3(0f, -109.2f, -7f);
        }
    }
}
