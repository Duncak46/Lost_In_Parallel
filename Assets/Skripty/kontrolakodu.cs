using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class kontrolakodu : MonoBehaviour
{
    //Texty na kód
    [SerializeField]
    private TMP_Text kodcislo1;
    [SerializeField]
    private TMP_Text kodcisla2;
    [SerializeField]
    private TMP_Text kodcislo3;
    [SerializeField]
    private TMP_Text kodcisla4;
    [SerializeField]
    private TMP_Text kodcislo5;
    [SerializeField]
    private TMP_Text kodcisla6;
    [SerializeField]
    private TMP_Text kodcislo7;
    [SerializeField]
    private TMP_Text kodcisla8;

    //OBJEKTY
    [SerializeField]
    private GameObject pravaBrana;
    [SerializeField]
    private GameObject levaBrana;
    [SerializeField]
    private GameObject kodNaCanvas;
    [SerializeField]
    private GameObject krizek;

    private BoxCollider2D naDelete;
    
    // Start is called before the first frame update
    void Start()
    {
        naDelete = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (kodNaCanvas != null)
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.W))
            {
                kodNaCanvas.SetActive(false);
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        var player = col.gameObject.GetComponent<movement>();
        if (player != null)
        {
            kodNaCanvas.SetActive(true);
        }

    }
    public void potvrzeniKodu()
    {
        StartCoroutine(PotvrzeniKodu());
    }

    IEnumerator PotvrzeniKodu()
    {
        if (kodcislo1.text == "4"
            && kodcisla2.text == "5"
            && kodcislo3.text == "8"
            && kodcisla4.text == "9"
            && kodcislo5.text == "2"
            && kodcisla6.text == "3"
            && kodcislo7.text == "0"
            && kodcisla8.text == "1")
        {
            levaBrana.transform.Rotate(5f, 420f, 30f);
            pravaBrana.transform.Rotate(5f, 60f, 30f);
            Destroy(naDelete);
            Destroy(kodNaCanvas);
        }
        else
        {
            krizek.SetActive(true);
            yield return new WaitForSeconds(2f);
            krizek.SetActive(false);
        }
    }
}
