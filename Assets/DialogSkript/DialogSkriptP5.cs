using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//SKRIPT KDE MLUVÍ I HRÁÈ
public class DialogSkriptP5 : MonoBehaviour
{
    //HUDBA
    [SerializeField]
    private AudioSource poprve;
    [SerializeField]
    private AudioSource poprveJa;
    [SerializeField]
    private AudioSource poprve1;
    [SerializeField]
    private AudioSource vyhra;
    [SerializeField]
    private AudioSource vyhraJa;
    //OBJEKTY
    [SerializeField]
    private GameObject bublina;
    [SerializeField]
    private GameObject bublinaJa;
    //Pomocný vìci
    private bool againcollision = true;
    private bool offobjekt = false;
    public static bool vyhraljsem = false;
    [SerializeField]
    private int WhichText = 0;
    [SerializeField]
    private TMP_Text Dialog;
    [SerializeField]
    private TMP_Text DialogJa;
    private string Text1HE = "Nazdárek, ty jsi tu nový?";
    private string Text1ME = "Jojo";
    private string Text2HE = "Tak to mì musíš porazit v piškvorkách, v našem svìtì jsem v tom mistr! Za odmìnu ti dám kartièku a drobák.";
    private string TextHeDone = "Aha, tak to jsem neèekal. Udìláme takovej obchod... Já ti dám tu kartu, protože si mì porazil a ty nikomu neøekneš, že jsem prohrál co ty na to?";
    private string TextMeDone = "Tak jo no.";

    // Update is called once per frame
    void Update()
    {
        if (offobjekt == true && Input.GetKeyDown(KeyCode.Space))
        {
            offobjekt = false;
            bublina.SetActive(false);
            poprve1.Stop();
            poprveJa.Stop();
            
            vyhra.Stop();
            vyhraJa.Stop();
            StopAllCoroutines();
            
            againcollision = true;
            if (WhichText == 5)
            {
                WhichText = 6;
                vyhraJa.Stop();
                DialogJa.text = "";
                Dialog.text = "";
                bublinaJa.SetActive(false);
                
            }
            if (WhichText == 4)
            {
                WhichText = 5;
                vyhra.Stop();
                bublina.SetActive(false);
                bublinaJa.SetActive(true);
                Dialog.text = "";
                DialogJa.text = "";
                vyhraJa.Play();
                StartCoroutine(textdoneME());
                offobjekt = true;
            }
            if (WhichText == 2)
            {
                WhichText = 3;
                poprve1.Stop();
                Dialog.text = "";
                DialogJa.text = "";
                bublina.SetActive(false);
                offobjekt = true;
                piskvorky.piskvorkyZapnuto = true;
            }
            if (WhichText == 1)
            {
                WhichText = 2;
                poprveJa.Stop();
                Dialog.text = "";
                DialogJa.text = "";
                bublinaJa.SetActive(false);
                bublina.SetActive(true);
                poprve1.Play();
                StartCoroutine(text2());
                offobjekt = true;
            }
            if (WhichText == 0)
            {
                WhichText = 1;
                poprve.Stop();
                Dialog.text = "";
                DialogJa.text = "";
                bublina.SetActive(false);
                bublinaJa.SetActive(true);
                poprveJa.Play();
                StartCoroutine(textJa());
                offobjekt = true;
            }
        }
        if (piskvorky.vyhra == true && WhichText == 3)
        {
            WhichText = 4;
            bublina.SetActive(true);
            vyhra.Play();
            StartCoroutine(textdoneHE());
            offobjekt = true;
        }
    }
    public void OnCollisionEnter2D(Collision2D col)
    {

        var player = col.gameObject.GetComponent<movement>();

        if (player != null)
        {

            if (WhichText == 0 && againcollision == true)
            {
                againcollision = false;
                offobjekt = true;
                bublina.SetActive(true);
                poprve.Play();
                StartCoroutine(text1());

            }
            
        }
    }

    private IEnumerator text1()
    {
        Dialog.fontSize = 36;
        yield return new WaitForSeconds(1f);
        for (int i = 0; i < Text1HE.Length; i++)
        {
            yield return new WaitForSeconds(0.05f);
            Dialog.text = Dialog.text + Text1HE[i];
        }



    }
    private IEnumerator textJa()
    {
        DialogJa.fontSize = 36;
        yield return new WaitForSeconds(0.6f);
        for (int i = 0; i < Text1ME.Length; i++)
        {
            yield return new WaitForSeconds(0.05f);
            DialogJa.text = DialogJa.text + Text1ME[i];
        }



    }
    private IEnumerator text2()
    {
        ListUkolu.pridejUkolPiskvorky();
        Dialog.fontSize = 36;
        for (int i = 0; i < Text2HE.Length; i++)
        {
            yield return new WaitForSeconds(0.06f);
            Dialog.text = Dialog.text + Text2HE[i];
        }

    }
    private IEnumerator textdoneHE()
    {
        yield return new WaitForSeconds(1f);
        Dialog.fontSize = 36;
        for (int i = 0; i < TextHeDone.Length; i++)
        {
            yield return new WaitForSeconds(0.05f);
            Dialog.text = Dialog.text + TextHeDone[i];
        }

    }
    private IEnumerator textdoneME()
    {
        ListUkolu.kolikUkolu--;
        ListUkolu.UpravitUkoly();
        ListUkolu.ukoltexty[ListUkolu.jakejtext_ukolPiskvorky].text = "";
        DialogJa.fontSize = 36;
        for (int i = 0; i < TextMeDone.Length; i++)
        {
            yield return new WaitForSeconds(0.05f);
            DialogJa.text = DialogJa.text + TextMeDone[i];
        }

    }
}
