using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ListUkolu : MonoBehaviour
{
    public static int pocet_orbu = 0;
    //IKONA
    [SerializeField]
    private GameObject ikonaUkoly;

    //Otevreno
    [SerializeField]
    private GameObject ukolyOtevreno;
    private bool otevreno = false;

    //Texty
    [SerializeField]
    private TMP_Text ukol0;
    [SerializeField]
    private TMP_Text ukol1;
    [SerializeField]
    private TMP_Text ukol2;
    [SerializeField]
    private TMP_Text ukol3;
    [SerializeField]
    private TMP_Text ukol4;
    [SerializeField]
    private TMP_Text ukol5;

    [SerializeField]
    public static TMP_Text[] ukoltexty = new TMP_Text[6];

    public static int kolikUkolu = -1;

    public static int promenaDoIf;
    //ukolkvetiny
    static string ukolpostava1 = "Natrhej starci kvìtiny   ";
    public static int jakejtext_ukolkvetiny;
   

    //ukolOrby
    static string ukolOrby = "Posbírej a vlož 3 orby do monumentu";
    public static int jakejtext_ukolorby;

    //ukolPiskvorky
    public bool piskvorkyhotovo = false;
    public static int jakejtext_ukolPiskvorky;
    static string ukolPiskvorky = "Poraž mistra v piškvorkách";

    //úkol 2 mince
    public static int jakejtext_ukolMince;
    static string ukolMince = "Sehnat 2 mince a koupit páku";

    //sehnat páku
    public static int jakejtext_ukolPaka;
    static string ukolPaka = "Sehnat páku a aktivovat minihru";

    //Chytit Rybu
    public static int jakejtext_ukolRyba;
    static string ukolRyba = "Sehnat rybu pro rybáøe";

    //Najdi psa
    public static int jakejtext_ukolPes;
    static string ukolPes = "Najít ztraceného psa";

    //Najdi karty
    public static int jakejtext_ukolKarty;
    static string ukolKarty = "Najdi 2 ztracené karty";

    //Najdi zvìrokruh
    static bool spustenoZverokruh = false;
    public static int jakejtext_ukolZverokruh;
    static string ukolZverokruh = "Najdi 3 èásti zvìrokruhu";

    //Rozluštit šifru
    static bool spustenoSifra = false;
    public static int jakejtext_ukolSifra;
    static string ukolSifra = "Rozlušti šifru u brány";

    //Posekat strom
    public static int jakejtext_ukolStrom;
    static string ukolStrom = "Posekej strom v temném lese";
    // Start is called before the first frame update
    void Start() 
    {
        ukoltexty[0] = ukol0;
        ukoltexty[1] = ukol1;
        ukoltexty[2] = ukol2;
        ukoltexty[3] = ukol3;
        ukoltexty[4] = ukol4;
        ukoltexty[5] = ukol5;
    }

    // Update is called once per frame
    void Update()
    {
        if (piskvorkyhotovo == true)
        {
            kolikUkolu--;
            ukoltexty[jakejtext_ukolPiskvorky].text = "";
            UpravitUkoly();
        }
        if (Input.GetKeyDown(KeyCode.Tab) && otevreno == false && movement.povoleno == true)
        {
            ikonaUkoly.SetActive(false);
            ukolyOtevreno.SetActive(true);
            otevreno = true;
        }
        else if (Input.GetKeyDown(KeyCode.Tab) && otevreno == true && movement.povoleno == true)
        {
            ikonaUkoly.SetActive(true);
            ukolyOtevreno.SetActive(false);
            otevreno = false;
        }
        if (movement.povoleno == false)
        {
            ikonaUkoly.SetActive(true);
            ukolyOtevreno.SetActive(false);
            otevreno = false;
        }
        if (DialogSkriptP6.ukolONkvetiny == true)
        {
            ukoltexty[jakejtext_ukolkvetiny].text = ukolpostava1 + POSTAVA6UKOL.nasbiranokvetintext;
        }
        
    }
    //Sehnat 2 mince a koupit páku
    public static void pridejUkolMince()
    {
        kolikUkolu++;
        ukoltexty[kolikUkolu].text = ukolMince;
        jakejtext_ukolMince = kolikUkolu;
    }
    //Sehnat páku - Není voláno
    public static void pridejSehnatPaku()
    {
        kolikUkolu++;
        ukoltexty[kolikUkolu].text = ukolPaka;
        jakejtext_ukolPaka = kolikUkolu;
    }
    //Chytit rybu
    public static void pridejUkolChytitRybu()
    {
        kolikUkolu++;
        ukoltexty[kolikUkolu].text = ukolRyba;
        jakejtext_ukolRyba = kolikUkolu;
    }
    //Najít psa
    public static void pridejUkolPes()
    {
        kolikUkolu++;
        ukoltexty[kolikUkolu].text = ukolPes;
        jakejtext_ukolPes = kolikUkolu;
    }
    //Najít zbývající karty
    public static void pridejUkolKarty()
    {
        kolikUkolu++;
        ukoltexty[kolikUkolu].text = ukolKarty;
        jakejtext_ukolKarty = kolikUkolu;
    }
    //Posbírat èásti zvìrokruhu - Není voláno u sbírání ze zemì
    public static void pridejUkolZverokruh()
    {
        if (spustenoZverokruh == false)
        {
            kolikUkolu++;
            ukoltexty[kolikUkolu].text = ukolZverokruh;
            jakejtext_ukolZverokruh = kolikUkolu;
            spustenoZverokruh = true;
        }
        
    }
    //Rozluštit šifru - Není voláno (1.2.3. èást kódu)
    public static void pridejUkolSifra()
    {
        if (spustenoSifra == false)
        {
            kolikUkolu++;
            ukoltexty[kolikUkolu].text = ukolSifra;
            jakejtext_ukolSifra = kolikUkolu;
            spustenoSifra = true;
        }
    }
    //posekej strom - Není voláno
    public static void pridejUkolStrom()
    {
        kolikUkolu++;
        ukoltexty[kolikUkolu].text = ukolStrom;
        jakejtext_ukolStrom = kolikUkolu;
    }
    //Posbírat kvìtiny
    public static void pridejUkolKvetiny()
    {

        ukoltexty[kolikUkolu].text = ukolpostava1 + POSTAVA6UKOL.nasbiranokvetintext;
        jakejtext_ukolkvetiny = kolikUkolu;
    }
    public static void pridejUkolOrby()
    {
        kolikUkolu++;
        ukoltexty[kolikUkolu].text = ukolOrby;
        jakejtext_ukolorby = kolikUkolu;
    }
    public static void pridejUkolPiskvorky()
    {
        kolikUkolu++;
        
        ukoltexty[kolikUkolu].text = ukolPiskvorky;
        jakejtext_ukolPiskvorky = kolikUkolu;
    }

    public static void UpravitUkoly()
    {
        Debug.Log(kolikUkolu);
        for (int i = promenaDoIf; i <= kolikUkolu; i++)
        {
            if (i<=5)
            {
                ukoltexty[i].text = ukoltexty[i + 1].text;
            }
        }
        for (int i = promenaDoIf; i <= kolikUkolu; i++)
        {
            if (ukoltexty[i].text == ukoltexty[i + 1].text)
            {
                ukoltexty[i + 1].text = "";
            }
        }
    }
}
