using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource muzika;
    public GameObject hra;
    public GameObject hra1;
    public GameObject hra2;
    public GameObject hra3;
    public GameObject hra4;
    public GameObject hra5;
    public GameObject hra6;
    public GameObject hra7;
    bool ok = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hra.activeSelf == false && hra1.activeSelf == false && hra2.activeSelf == false && hra3.activeSelf == false && hra4.activeSelf == false && hra5.activeSelf == false && hra6.activeSelf == false && hra7.activeSelf == false)
        {
            if (ok) 
            {
                
                ok = false;
                muzika.Play(); 
            }
        }
        if (hra.activeSelf || hra1.activeSelf || hra2.activeSelf || hra3.activeSelf || hra4.activeSelf || hra5.activeSelf || hra6.activeSelf || hra7.activeSelf)
        {
            if (ok == false)
            {
                ok  =   true;
                muzika.Pause();
            }
            
        }
    }
}
