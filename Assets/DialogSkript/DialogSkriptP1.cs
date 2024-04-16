using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogSkriptP1 : MonoBehaviour
{
    //HUDBA
    [SerializeField]
    private AudioSource hotovo;
    [SerializeField]
    private AudioSource poprve;
    [SerializeField]
    private AudioSource podruhe;
    //OBJEKTY
    [SerializeField]
    private GameObject bublina;
    //Pomocný vìci
    private bool againcollision = true;
    private bool offobjekt = false;
    
    public static int pocet_karet = 0;
    [SerializeField]
    private int WhichText = 0;
    [SerializeField]
    private TMP_Text Dialog;
    private string Text1HE = "Pøineseš mi dva zbývající žolíky, bez nich si ty karty nikdy nezahraju..";
    private string Text2HE = "Máš ty karty?";
    private string TextHeDone = "Díkec, tady máš nìjakej kus zvìrokruhu.";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (offobjekt == true && Input.GetKeyDown(KeyCode.Space))
        {
            movement.povoleno = true;
            offobjekt = false;
            bublina.SetActive(false);
            hotovo.Stop();
            podruhe.Stop();
            poprve.Stop();
            StopAllCoroutines();
            Dialog.text = "";
            againcollision = true;

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
                WhichText = 1;
                ListUkolu.pridejUkolKarty();
                StartCoroutine(text1());

            }
            else if (WhichText == 1 && againcollision == true)
            {
                againcollision = false;
                offobjekt = true;
                bublina.SetActive(true);
                if (pocet_karet == 2)
                {
                    hotovo.Play();
                    WhichText = 2;
                    ListUkolu.pridejUkolZverokruh();
                    kolizeNaStartBoss1.pocet_zverokruhu++;
                    StartCoroutine(textdone());
                }
                else
                {
                    podruhe.Play();
                    StartCoroutine(text2());

                }
            }
        }
    }

    private IEnumerator text1()
    {
        movement.povoleno = false;
        Dialog.fontSize = 36;
        yield return new WaitForSeconds(1f);
        for (int i = 0; i < Text1HE.Length; i++)
        {
            yield return new WaitForSeconds(0.05f);
            Dialog.text = Dialog.text + Text1HE[i];
        }



    }
    private IEnumerator text2()
    {
        movement.povoleno = false;
        Dialog.fontSize = 36;
        for (int i = 0; i < Text2HE.Length; i++)
        {
            yield return new WaitForSeconds(0.1f);
            Dialog.text = Dialog.text + Text2HE[i];
        }

    }
    private IEnumerator textdone()
    {
        
        movement.povoleno = false;
        ListUkolu.kolikUkolu--;
        ListUkolu.promenaDoIf = ListUkolu.jakejtext_ukolKarty;
        ListUkolu.ukoltexty[ListUkolu.jakejtext_ukolKarty].text = "";
        ListUkolu.UpravitUkoly();
        Dialog.fontSize = 36;
        for (int i = 0; i < TextHeDone.Length; i++)
        {
            yield return new WaitForSeconds(0.05f);
            Dialog.text = Dialog.text + TextHeDone[i];
        }

    }
}