using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class kod : MonoBehaviour
{
    
    //Objekty
    [SerializeField]
    private TMP_Text cisla;
    //pomocný
    private int jakycislo;
    // Start is called before the first frame update
    void Start()
    {
        jakycislo = 0;
        cisla.text = jakycislo+"";

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Up()
    {
        jakycislo++;
        if (jakycislo > 9)
        {
            jakycislo = 0;
        }
        cisla.text = jakycislo + "";
    }
    public void Down()
    {
        jakycislo--;
        if (jakycislo<0)
        {
            jakycislo = 9;
        }
        cisla.text = jakycislo + "";
    }
}
