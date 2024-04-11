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
    public RectTransform imageRectTransform; // P�i�a� RectTransform sv�ho obr�zku pomoc� editoru Unity
    public RectTransform pointA; // P�i�a� RectTransform bod A
    public RectTransform pointB; // P�i�a� RectTransform bod B


    public float speed; // Rychlost pohybu

    private Vector2 targetPosition; // C�lov� pozice

    void Start()
    {
        speed = Random.Range(500f,1000f);
        SetTarget(pointB.anchoredPosition); // Nastav po��te�n� c�lovou pozici na bod B
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
        MoveImage(); // Zavolej metodu pro pohyb obr�zku
    }

    void MoveImage()
    {
        // Pohyb obr�zku sm�rem k c�lov� pozici
        imageRectTransform.anchoredPosition = Vector2.MoveTowards(imageRectTransform.anchoredPosition, targetPosition, speed * Time.deltaTime);

        // Pokud obr�zek dorazil na c�lovou pozici, zm�� c�lovou pozici na opa�n� bod
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
