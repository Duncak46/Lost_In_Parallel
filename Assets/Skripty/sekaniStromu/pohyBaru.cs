using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class pohyBaru : MonoBehaviour
{
    [SerializeField]
    private GameObject strom;
    [SerializeField]
    private GameObject hra;
    [SerializeField]
    private Image bar;
    private float Max = 67f;
    private float min = 0f;

    private float deleno = 3.6f;
    private bool bezi = true;
    //Zivoty
    [SerializeField]
    private TMP_Text zivoty;
    private string zivotyString;
    private int kolikzivotu = 100;

    public float rychlostPohybu = 1750f;
    
    private float kterejJeAkce;
    // Start is called before the first frame update
    void Start()
    {
        kterejJeAkce = Max;
        zivotyString = kolikzivotu + "/100 HP";
    }

    // Update is called once per frame
    void Update()
    {
        
        MoveBar();
        if (bar.rectTransform.anchoredPosition.y >= Max)
        {
            kterejJeAkce = min;
        }
        if (bar.rectTransform.anchoredPosition.y <= min)
        {
            kterejJeAkce = Max;
        }
        if (Input.GetMouseButtonDown(0) && bezi == true)
        {
            bezi = false;
            StartCoroutine(uberzivoty());
        }
    }

    private void MoveBar()
    {
        if (bezi == true)
        {
            float currentY = bar.rectTransform.anchoredPosition.y;

            // Pohyb baru smìrem k promìnné kterejJeAkce
            float newY = Mathf.MoveTowards(currentY, kterejJeAkce, Time.deltaTime * rychlostPohybu);

            // Nastavení nové pozice Y
            bar.rectTransform.anchoredPosition = new Vector2(bar.rectTransform.anchoredPosition.x, newY);
        }
    }

    IEnumerator uberzivoty()
    {
        kolikzivotu = Mathf.RoundToInt(kolikzivotu - (bar.rectTransform.anchoredPosition.y/deleno));
        yield return new WaitForSeconds(2f);
        if (kolikzivotu <= 0)
        {
            Destroy(strom);
            loveniRyb.Klacek = true;
            sekaniStromu.mamSekeru = false;
            movement.povoleno = true;
            ListUkolu.kolikUkolu--;
            ListUkolu.promenaDoIf = ListUkolu.jakejtext_ukolStrom;
            ListUkolu.ukoltexty[ListUkolu.jakejtext_ukolStrom].text = "";
            ListUkolu.UpravitUkoly();
            hra.SetActive(false);
        }
        else
        {
            zivoty.text = kolikzivotu + "/100 HP";
            bezi = true;
        }
        
    }
}
