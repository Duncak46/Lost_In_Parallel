using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loveniRyb : MonoBehaviour
{
    public static bool SvazekNaPrut = false;
    public static bool Klacek = false;

    public static bool prut = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SvazekNaPrut == true && Klacek == true)
        {
            prut = true;
        }
    }

    
}
