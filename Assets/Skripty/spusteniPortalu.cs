using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spusteniPortalu : MonoBehaviour
{
    public GameObject orb1;
    public GameObject orb2;
    public GameObject orb3;
    public GameObject brana;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (orb1.activeSelf)
        {
            if (orb2.activeSelf)
            {
                if (orb3.activeSelf)
                {
                    brana.SetActive(true);
                }
            }
        }
    }
}
