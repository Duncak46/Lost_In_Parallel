using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortyLes : MonoBehaviour
{
    private bool JeVtemnymLese = false;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<movement>();
        if (player != null && JeVtemnymLese == true)
        {
            JeVtemnymLese = false;
            player.transform.position = new Vector3(69.5f, 50.9f, 0f);
        }
        else if (player != null && JeVtemnymLese == false)
        {
            JeVtemnymLese = true;
            player.transform.position = new Vector3(97.35f, 31.28f, 0f);
        }
    }   
}
