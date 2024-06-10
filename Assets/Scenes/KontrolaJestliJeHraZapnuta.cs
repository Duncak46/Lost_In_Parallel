using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontrolaJestliJeHraZapnuta : MonoBehaviour
{
    public static bool ZapnutaHra = false;
    public Camera Camera;
    public GameObject hlavniHra;
    public GameObject hra1;
    public GameObject hra2;
    public GameObject hra3;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ZapnutaHra == true)
        {
            ZapnutaHra = false;
            movement.povoleno = false;
            Camera.transform.position = new Vector3(66.2f, 152.5f, -5.375148f);
            hlavniHra.SetActive(true);
            hra1.SetActive(true);
            hra2.SetActive(false);
            hra3.SetActive(false);
        }
    }
}
