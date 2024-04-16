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
        // Z�sk�n� aktu�ln� pozice Gameobjectu
        Vector3 pozice = transform.position;

        // Zv��en� nebo sn�en� Y sou�adnice o rychlost * �asov� krok
        pozice.y -= rychlost * Time.deltaTime;

        // Nastaven� nov� pozice Gameobjectu
        transform.position = pozice;
    }
}
