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
    //Pomocnı vìci
    public static bool ukolONkvetiny = false;
    private bool againcollision = true;
    private bool offobjekt = false;
    [SerializeField]
    private int WhichText = 0;
    [SerializeField]
    private TMP_Text Dialog;
    
    [SerializeField]
     
    private string Text1HE = "Ahoj! Chtìl jsem si natrhat pár bylin na èaj... Jene se sotva ohnu, jsem u dost starı. Mohl bys mi nìjaké natrhat?";
    private string Text2HE = "Natrháš mi je prosím?";
    private string TextHeDone = "Dìkuju ti moc! Koukám, e jsi tu novı... tady máš pár informací o našem malém svìtì. Existuje pradávnı SOR, kterı nás tu drí a bude tu dret i tebe! Jediná monost jak se odsud dostat je ho porazit a otevøít portál, ale nebude to jen tak. Potøebuješ k tomu 3 orby, které získáš zabitím jeho 3 poskokù v rùznıch èástech našeho svìta. Víc ti neøeknu moje pamì u na tom není nejlépe. Na zaèátek tu ode mì máš èást zvìrokruhu. Urèitì ho budeš potøebovat.";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (offobjekt == true && Input.GetKeyDown(KeyCode.Space))
        {
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
                    ListUkolu.kolikUkolu--;
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
        Dialog.fontSize = 36;
        for (int i = 0; i < Text2HE.Length; i++)
        {
            yield return new WaitForSeconds(0.1f);
            Dialog.text = Dialog.text + Text2HE[i];
        }
        
    }
    private IEnumerator textdone()
    {
        
        ListUkolu.UpravitUkoly();
        ListUkolu.ukoltexty[ListUkolu.jakejtext_ukolkvetiny].text = "";
        ListUkolu.pridejUkolOrby();
        Dialog.fontSize = 28;
        for (int i = 0; i < TextHeDone.Length; i++)
        {
            yield return new WaitForSeconds(0.05f);
            Dialog.text = Dialog.text + TextHeDone[i];
        }
        
    }
}
