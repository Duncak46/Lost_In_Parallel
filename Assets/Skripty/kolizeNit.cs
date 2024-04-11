using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kolizeNit : MonoBehaviour
{
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<movement>();
        if (player != null)
        {
            loveniRyb.SvazekNaPrut = true;
            Destroy(gameObject);
        }
    }
}
