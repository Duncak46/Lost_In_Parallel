using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class kliknutiRyba : MonoBehaviour
{
    

    [SerializeField]
    TMP_Text skore;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Kliknout()
    {
        minihraRyby.ryby++;
        skore.text = minihraRyby.ryby + "/10";
        Destroy(gameObject);
    }
}
