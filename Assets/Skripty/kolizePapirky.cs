using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kolizePapirky : MonoBehaviour
{
    private bool PapirekOpen = false;

    [SerializeField]
    private GameObject kod;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PapirekOpen == true)
        {
            kod.SetActive(true);
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.W))
            {
                PapirekOpen = false;
            }
        }
        if (PapirekOpen == false)
        {
            kod.SetActive(false);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<movement>();
        if (player != null)
        {
            PapirekOpen = true;
        }
    }
}
