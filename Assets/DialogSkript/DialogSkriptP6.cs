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
    //Pomocn� v�ci
    public static bool ukolONkvetiny = false;
    private bool againcollision = true;
    private bool offobjekt = false;
    [SerializeField]
    private int WhichText = 0;
    [SerializeField]
    private TMP_Text Dialog;
    
    [SerializeField]
     
    private string Text1HE = "Ahoj! Cht�l jsem si natrhat p�r bylin na �aj... Jen�e se sotva ohnu, jsem u� dost star�. Mohl bys mi n�jak� natrhat?";
    private string Text2HE = "Natrh� mi je pros�m?";
    private string TextHeDone = "D�kuju ti moc! Kouk�m, �e jsi tu nov�... tady m� p�r informac� o na�em mal�m sv�t�. Existuje prad�vn� SOR, kter� n�s tu dr�� a bude tu dr�et i tebe! Jedin� mo�nost jak se odsud dostat je ho porazit a otev��t port�l, ale nebude to jen tak. Pot�ebuje� k tomu 3 orby, kter� z�sk� zabit�m jeho 3 poskok� v r�zn�ch ��stech na�eho sv�ta. V�c ti ne�eknu moje pam� u� na tom nen� nejl�pe. Na za��tek tu ode m� m� ��st zv�rokruhu. Ur�it� ho bude� pot�ebovat.";
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
