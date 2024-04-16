using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogSkriptP6 : MonoBehaviour
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
    //Pomocn˝ vÏci
    public static bool ukolONkvetiny = false;
    private bool againcollision = true;
    private bool offobjekt = false;
    [SerializeField]
    private int WhichText = 0;
    [SerializeField]
    private TMP_Text Dialog;
    
    [SerializeField]
     
    private string Text1HE = "Ahoj! ChtÏl jsem si natrhat p·r bylin na Ëaj... Jenûe se sotva ohnu, jsem uû dost star˝. Mohl bys mi nÏjakÈ natrhat?";
    private string Text2HE = "Natrh·ö mi je prosÌm?";
    private string TextHeDone = "DÏkuju ti moc! Kouk·m, ûe jsi tu nov˝... tady m·ö p·r informacÌ o naöem malÈm svÏtÏ. Existuje prad·vn˝ SOR, kter˝ n·s tu drûÌ a bude tu drûet i tebe! Jedin· moûnost jak se odsud dostat je ho porazit a otev¯Ìt port·l, ale nebude to jen tak. Pot¯ebujeö k tomu 3 orby, kterÈ zÌsk·ö zabitÌm jeho 3 poskok˘ v r˘zn˝ch Ë·stech naöeho svÏta. VÌc ti ne¯eknu moje pamÏù uû na tom nenÌ nejlÈpe. Na zaË·tek tu ode mÏ m·ö Ë·st zvÏrokruhu. UrËitÏ ho budeö pot¯ebovat.";
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
                ukolONkvetiny = true;
                againcollision = false;
                offobjekt = true;
                bublina.SetActive(true);
                poprve.Play();
                WhichText = 1;
                ListUkolu.kolikUkolu++;
                ListUkolu.pridejUkolKvetiny();
                StartCoroutine(text1());
                
            }
            else if (WhichText == 1 && againcollision == true)
            {
                againcollision = false;
                offobjekt = true;
                bublina.SetActive(true);
                if (POSTAVA6UKOL.nasbiranoKvetin == 6)
                {
                    hotovo.Play();
                    WhichText = 2;
                    ukolONkvetiny = false;
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
        ListUkolu.promenaDoIf = ListUkolu.jakejtext_ukolkvetiny;
        ListUkolu.ukoltexty[ListUkolu.jakejtext_ukolkvetiny].text = "";
        ListUkolu.UpravitUkoly();
        
        ListUkolu.pridejUkolOrby();
        Dialog.fontSize = 28;
        for (int i = 0; i < TextHeDone.Length; i++)
        {
            yield return new WaitForSeconds(0.05f);
            Dialog.text = Dialog.text + TextHeDone[i];
        }
        
    }
}
