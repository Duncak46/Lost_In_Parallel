using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishBoss2 : MonoBehaviour
{
    public GameObject hracVeSvete;
    public GameObject hra;
    public GameObject Kamera;
    public GameObject Ikony;
    public GameObject PohybKamera;
    public GameObject Orb;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<movementPlayer2>();
        if (player != null)
        {
            Destroy(PohybKamera);
            Kamera.transform.position = new Vector3(hracVeSvete.transform.position.x, hracVeSvete.transform.position.y, -7F);
            movement.povoleno = true;
            Orb.SetActive(true);
            Ikony.SetActive(true);
            hra.SetActive(false);
        }
    }
}
