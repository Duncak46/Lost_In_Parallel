using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kolizeCoin : MonoBehaviour
{
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
        if (player != null)
        {
            DialogSkriptP4.coiny++;
            Destroy(gameObject);
        }
    }
}