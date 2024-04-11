using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sekaniStromu : MonoBehaviour
{
    public static bool mamSekeru = false;
    private bool zacnehra = false;
    private bool znovu = false;

    [SerializeField]
    private GameObject hra;

    // Update is called once per frame
    void Update()
    {
        if (zacnehra == true)
        {
            movement.povoleno = false;
            hra.SetActive(true);
            zacnehra = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<movement>();
        if (player != null && mamSekeru == true && znovu == false)
        {
            zacnehra = true;
            znovu = true;
        }
    }
}
