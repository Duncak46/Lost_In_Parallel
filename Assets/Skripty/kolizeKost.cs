using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kolizeKost : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<movement>();
        if (player != null)
        {
            PesMoving.MaKost = true;
            Destroy(gameObject);
        }
    }
}
