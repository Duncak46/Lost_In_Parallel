using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kolizeAutomat : MonoBehaviour
{
    [SerializeField]
    private GameObject automat;
    bool idk = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<movement>();
        if (player != null && DialogSkriptP4.maPaku == true && idk == false)
        {
            posouvaniSten.HraZapnuto = true;
            posouvaniSten.Nevypnuto = true;
            idk = true;
            automat.SetActive(true);
        }
        
    }
}
