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
            // Z�sk�n� aktu�ln� pozice Gameobjectu
            Vector3 pozice = transform.position;

            // Zv��en� nebo sn�en� Y sou�adnice o rychlost * �asov� krok
            pozice.y -= rychlost * Time.deltaTime;

            // Nastaven� nov� pozice Gameobjectu
            transform.position = pozice;
        }
        
    }
}
