using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogSkriptP3 : MonoBehaviour
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

    public static bool mam_psa = false;
    [SerializeField]
    private Transform pes;
    [SerializeField]
    private int WhichText = 0;
    [SerializeField]
    private TMP_Text Dialog;
    private string Text1HE = "Ahoj, ztratila jsem svého pejska.... Pomùžeš mi ho najít? Dostaneš dobrou odmìnu!";
    private string Text2HE = "Kde je mùj ètyønohý pøítel?";
    private string TextHeDone = "Díky moc, koneènì je mùj pøítel semnou!";
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
                ListUkolu.pridejUkolPes();
                StartCoroutine(text1());
                
            }
            else if (WhichText == 1 && againcollision == true)
            {
                againcollision = false;
                offobjekt = true;
                bublina.SetActive(true);
                if (mam_psa == true)
                {
                    pes.position = new Vector2(transform.position.x - 2f, transform.position.y);
                    sekaniStromu.mamSekeru = true;
                    PesMoving.muzeZacit = false;
                    PesMoving.MaKost = false;
                    pes.rotation = Quaternion.Euler(pes.rotation.x, 180f, pes.rotation.z);
                    hotovo.Play();
                    WhichText = 2;
                    
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
        ListUkolu.promenaDoIf = ListUkolu.jakejtext_ukolPes;
        ListUkolu.ukoltexty[ListUkolu.jakejtext_ukolPes].text = "";
        ListUkolu.UpravitUkoly();
        ListUkolu.pridejUkolStrom();

        Dialog.fontSize = 36;
        for (int i = 0; i < TextHeDone.Length; i++)
        {
            yield return new WaitForSeconds(0.05f);
            Dialog.text = Dialog.text + TextHeDone[i];
        }

    }
}
