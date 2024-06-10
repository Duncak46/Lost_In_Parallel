using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class odemknutiFinal : MonoBehaviour
{
    public GameObject orb1;
    public GameObject orb2;
    public GameObject orb3;

    public GameObject branaKbossovoi;

    // Update is called once per frame
    void Update()
    {
        if (orb1.activeSelf && orb2.activeSelf && orb3.activeSelf)
        {
            branaKbossovoi.SetActive(true);
        }
    }
}
