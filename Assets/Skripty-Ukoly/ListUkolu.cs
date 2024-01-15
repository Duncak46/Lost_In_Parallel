using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ListUkolu : MonoBehaviour
{
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

    //ukolkvetiny
    static string ukolpostava1 = "Natrhej starci kvìtiny   ";
    public static int jakejtext_ukolkvetiny;
   

    //ukolOrby
    static string ukolOrby = "Posbírej a vlož orby do monumentu    0/3";
    static int jakejtext_ukolorby;

    //ukolPiskvorky
    
    public bool piskvorkyhotovo = false;
    public static int jakejtext_ukolPiskvorky;
    static string ukolPiskvorky = "Poraž mistra v piškvorkách";

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
        if (Input.GetKeyDown(KeyCode.Tab) && otevreno == false)
        {
            ikonaUkoly.SetActive(false);
            ukolyOtevreno.SetActive(true);
            otevreno = true;
        }
        else if (Input.GetKeyDown(KeyCode.Tab) && otevreno == true)
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

    public static void pridejUkolKvetiny()
    {
        ukoltexty[kolikUkolu].text = ukolpostava1 + POSTAVA6UKOL.nasbiranokvetintext;
        jakejtext_ukolkvetiny = kolikUkolu;
    }
    public static void pridejUkolOrby()
    {
        kolikUkolu++;
        ukoltexty[kolikUkolu].fontSize = 33;
        ukoltexty[kolikUkolu].text = ukolOrby;
        jakejtext_ukolorby = kolikUkolu;
    }
    public static void pridejUkolPiskvorky()
    {
        kolikUkolu++;
        ukoltexty[kolikUkolu].fontSize = 36;
        ukoltexty[kolikUkolu].text = ukolPiskvorky;
        jakejtext_ukolPiskvorky = kolikUkolu;
    }

    public static void UpravitUkoly()
    {
        for (int i = 2; i <= 6; i++)
        {
            if (kolikUkolu < i)
            {
                ukoltexty[i-2].text = ukoltexty[i-1].text;
            }
        }
    }
}
