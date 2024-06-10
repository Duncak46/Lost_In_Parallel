using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stonkNaKolizi : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<pohybmainboss>();
        if (player != null)
        {
            HPSystem.HPplayer--;
            Destroy(gameObject);
        }
    }
}
