using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class POSTAVA6UKOL : MonoBehaviour
{
    
    public static int nasbiranoKvetin = 0;
    public static string nasbiranokvetintext;
    // Start is called before the first frame update
    void Start()
    {
        nasbiranokvetintext = nasbiranoKvetin + "/6";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        var flower = collision.gameObject.GetComponent<kytky>();

        if (flower != null && DialogSkriptP6.ukolONkvetiny == true)
        {
            Destroy(flower.gameObject);
            nasbiranoKvetin++;
            nasbiranokvetintext = nasbiranoKvetin + "/6";
        }
    }

}
