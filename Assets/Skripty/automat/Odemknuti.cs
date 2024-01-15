using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odemknuti : MonoBehaviour
{
    [SerializeField]
    private GameObject zamek;

    [SerializeField]
    private RectTransform klic;
    private float speed = 0.05f;
    
    
    // Start is called before the first frame update
    void Start()
    {
       
            
          
    }

    // Update is called once per frame
    void Update()
    {
        if (posouvaniSten.HraZapnuto == true)
        {
            
            Vector2 currentPosition = klic.anchoredPosition;
            currentPosition.x -= speed * Time.deltaTime;
            klic.anchoredPosition = currentPosition;
            
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        var player = collision.gameObject.GetComponent<raketaMovement>();
        if (player != null)
        {
            zamek.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
