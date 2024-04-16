using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SipkyMove : MonoBehaviour
{
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = gameObject.transform.position;
    }

    public float rychlost = 1.0f;

    void Update()
    {
        // Získání aktuální pozice Gameobjectu
        Vector3 pozice = transform.position;

        // Zvýšení nebo snížení Y souøadnice o rychlost * èasový krok
        pozice.y -= rychlost * Time.deltaTime;

        // Nastavení nové pozice Gameobjectu
        transform.position = pozice;
    }
}
