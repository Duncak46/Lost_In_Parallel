using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SipkyMove : MonoBehaviour
{
    public static bool move = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float rychlost = 1.0f;

    void Update()
    {
        if (move == true)
        {
            // Získání aktuální pozice Gameobjectu
            Vector3 pozice = transform.position;

            // Zvýšení nebo snížení Y souøadnice o rychlost * èasový krok
            pozice.y -= rychlost * Time.deltaTime;

            // Nastavení nové pozice Gameobjectu
            transform.position = pozice;
        }
        
    }
}
