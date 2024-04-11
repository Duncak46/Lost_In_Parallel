using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minihraRyby : MonoBehaviour
{
    
    public static int ryby = 0;
    [SerializeField]
    private GameObject hra;
    bool vyhra = false;
    public static bool zapnutoRyby = false;
    public RectTransform imageRectTransform; // Pøiøaï RectTransform svého obrázku pomocí editoru Unity
    public RectTransform pointA; // Pøiøaï RectTransform bod A
    public RectTransform pointB; // Pøiøaï RectTransform bod B


    public float speed; // Rychlost pohybu

    private Vector2 targetPosition; // Cílová pozice

    void Start()
    {
        speed = Random.Range(500f,1000f);
        SetTarget(pointB.anchoredPosition); // Nastav poèáteèní cílovou pozici na bod B
    }

    void Update()
    {
        if (zapnutoRyby == true)
        {
            movement.povoleno = false;
            zapnutoRyby = false;
        }
        if (ryby >= 10 && vyhra == false)
        {
            vyhra = true;
            DialogSkriptP2.mam_ryby = true;
            movement.povoleno = true;
            hra.SetActive(false);
        }
        MoveImage(); // Zavolej metodu pro pohyb obrázku
    }

    void MoveImage()
    {
        // Pohyb obrázku smìrem k cílové pozici
        imageRectTransform.anchoredPosition = Vector2.MoveTowards(imageRectTransform.anchoredPosition, targetPosition, speed * Time.deltaTime);

        // Pokud obrázek dorazil na cílovou pozici, zmìò cílovou pozici na opaèný bod
        if ((Vector2)imageRectTransform.anchoredPosition == targetPosition)
        {
            if (targetPosition == pointA.anchoredPosition)
                SetTarget(pointB.anchoredPosition);
            else
                SetTarget(pointA.anchoredPosition);
        }
    }

    void SetTarget(Vector2 target)
    {
        targetPosition = target;
    }


}
