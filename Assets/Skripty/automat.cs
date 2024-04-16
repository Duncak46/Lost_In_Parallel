using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automat : MonoBehaviour
{


    [SerializeField]
    private RectTransform stena;
    private float speed = 30f;
    private float pointAY = 353.0f;
    private float pointBY = 117.0f;

    private Vector2 targetPosition;

    private void Start()
    {
        // Za��n�me na pozici A
        targetPosition = new Vector2(stena.anchoredPosition.x, pointAY);
    }

    private void Update()
    {
        // Pohybujeme se sm�rem k c�lov� pozici
        stena.anchoredPosition = Vector2.MoveTowards(stena.anchoredPosition, targetPosition, speed * Time.deltaTime);

        // Kontrolujeme, zda jsme dos�hli c�lov� pozice
        if (Vector2.Distance(stena.anchoredPosition, targetPosition) < 0.1f)
        {
            // Pokud jsme na pozici A, p�esuneme se na pozici B, a naopak
            if (targetPosition.y == pointAY)
            {
                targetPosition = new Vector2(stena.anchoredPosition.x, pointBY);
            }
            else
            {
                targetPosition = new Vector2(stena.anchoredPosition.x, pointAY);
            }
        }
    }
}
