using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class piskvorky : MonoBehaviour
{
    public static bool vyhra = false;
    private bool konec = false;
    int chci;
    //Sprity - krizek a koleèko
    [SerializeField]
    private Sprite kolecko;
    [SerializeField]
    private Sprite krizek;

    //Pokolikaty AI
    private int pokolikaty = 0;
    //CELÝ OBJEKT NA AKTIVACI
    [SerializeField]
    private GameObject PiskvorkyGame;
    [SerializeField]
    private GameObject Win;
    [SerializeField]
    private GameObject Lose;
    [SerializeField]
    private GameObject Draw;


    //BUTTONY PRO PIŠKVORKY
    [SerializeField]
    private GameObject AA1;
    [SerializeField]
    private GameObject AA2;
    [SerializeField]
    private GameObject AA3;
    
    [SerializeField]
    private GameObject BB1;
    [SerializeField]
    private GameObject BB2;
    [SerializeField]
    private GameObject BB3;
    
    [SerializeField]
    private GameObject CC1;
    [SerializeField]
    private GameObject CC2;
    [SerializeField]
    private GameObject CC3;

    //POLE PRO PIŠKVORKY GAMEOBJEKT 
    
    [SerializeField]
    private Image A1;
    [SerializeField]
    private Image A2;
    [SerializeField]
    private Image A3;
    
    [SerializeField]
    private Image B1;
    [SerializeField]
    private Image B2;
    [SerializeField]
    private Image B3;
    
    [SerializeField]
    private Image C1;
    [SerializeField]
    private Image C2;
    [SerializeField]
    private Image C3;

    //POLE PRO PIŠKVORKY INT 0=JÁ 1=AI
    
    private int a1 = 2;
    private int a2 = 2;
    private int a3 = 2;
    private int b1 = 2;
    private int b2 = 2;
    private int b3 = 2;
    private int c1 = 2;
    private int c2 = 2;
    private int c3 = 2;
    //ZAPNUTO
    public static bool piskvorkyZapnuto = false;

    //JSEM Na tahu?
    private bool JsemNaTahu = true;




    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        if (piskvorkyZapnuto == true)
        {
            PiskvorkyGame.SetActive(true);
        }
    }

    private void AIhraje()
    {
        //1.KOLO
        if (pokolikaty == 1)
        {
            if (a1 == 0)
            {
                b2 = 1;
                B2.sprite = kolecko;
                BB2.SetActive(false);
                JsemNaTahu = true;
            }
            else if (a2 == 0)
            {
                b2 = 1;
                B2.sprite = kolecko;
                BB2.SetActive(false);
                JsemNaTahu = true;
            }
            else if (a3 == 0)
            {
                b2 = 1;
                B2.sprite = kolecko;
                BB2.SetActive(false);
                JsemNaTahu = true;
            }
            else if (b1 == 0)
            {
                b2 = 1;
                B2.sprite = kolecko;
                BB2.SetActive(false);
                JsemNaTahu = true;
            }
            else if (b2 == 0)
            {
                a2 = 1;
                A2.sprite = kolecko;
                AA2.SetActive(false);
                JsemNaTahu = true;
            }
            else if (b3 == 0)
            {
                b2 = 1;
                B2.sprite = kolecko;
                BB2.SetActive(false);
                JsemNaTahu = true;
            }
            else if (c1 == 0)
            {
                b2 = 1;
                B2.sprite = kolecko;
                BB2.SetActive(false);
                JsemNaTahu = true;
            }
            else if (c2 == 0)
            {
                b2 = 1;
                B2.sprite = kolecko;
                BB2.SetActive(false);
                JsemNaTahu = true;
            }
            else if (c3 == 0)
            {
                b2 = 1;
                B2.sprite = kolecko;
                BB2.SetActive(false);
                JsemNaTahu = true;
            }
            kontrola();
        }
        //2.KOLO
        if (pokolikaty == 2)
        {
            //MOŽNOST A
            if (a1 == 0 && a2 == 0 && b2 == 1)
            {
                a3 = 1;
                A3.sprite = kolecko;
                AA3.SetActive(false);
                JsemNaTahu = true;
            }
            else if (a1 == 0 && b1 == 0 && b2 == 1)
            {
                c1 = 1;
                C1.sprite = kolecko;
                CC1.SetActive(false);
                JsemNaTahu = true;
            }
            else if (a1 == 0 && b2 == 1 && c1 == 0)
            {
                b2 = 1;
                B1.sprite = kolecko;
                BB1.SetActive(false);
                JsemNaTahu = true;
            }
            else if(a1 == 0 && b2 == 1 && a3 == 0)
            {
                a2 = 1;
                A2.sprite = kolecko;
                AA2.SetActive(false);
                JsemNaTahu = true;
            }
            else if (a1 == 0 && b3 == 0 && b2 == 1 || a1 == 0 && c2 == 0 && b2 == 1 || a1 == 0 && c3 == 0 && b2 == 1)
            {
                c1 = 1;
                C1.sprite = kolecko;
                CC1.SetActive(false);
                JsemNaTahu = true;
            }
            //MOŽNOST B
            else if (a3 == 0 && a2 == 0 && b2 == 1)
            {
                a1 = 1;
                A1.sprite = kolecko;
                AA1.SetActive(false);
                JsemNaTahu = true;
            }
            else if (a2 == 0 && b2 == 1 && b1 == 0 || a2 == 0 && b2 == 1 && b3 == 0 || a2 == 0 && b2 == 1 && c1 == 0 || a2 == 0 && b2 == 1 && c2 == 0)
            {
                c3 = 1;
                C3.sprite = kolecko;
                CC3.SetActive(false);
                JsemNaTahu = true;
            }
            else if (a2 == 0 && b2 == 1 && b1 == 0 || a2 == 0 && b2 == 1 && b3 == 0 || a2 == 0 && b2 == 1 && c3 == 0 || a2 == 0 && b2 == 1 && c2 == 0)
            {
                c1 = 1;
                C1.sprite = kolecko;
                CC1.SetActive(false);
                JsemNaTahu = true;
            }
            //MOŽNOST C
            else if (a3 == 0 && b3 == 0 && b2 == 1)
            {
                c3 = 1;
                C3.sprite = kolecko;
                CC3.SetActive(false);
                JsemNaTahu = true;
            }
            else if (a1 == 0 && b2 == 1 && a3 == 0)
            {
                a2 = 1;
                A2.sprite = kolecko;
                AA2.SetActive(false);
                JsemNaTahu = true;
            }
            else if (a3 == 0 && b2 == 1 && c3 == 0)
            {
                b3 = 1;
                B3.sprite = kolecko;
                BB3.SetActive(false);
                JsemNaTahu = true;
            }
            else if (a3 == 0 && b1 == 0 && b2 == 1 || a3 == 0 && c1 == 0 && b2 == 1 || a3 == 0 && c2 == 0 && b2 == 1)
            {
                c3 = 1;
                C3.sprite = kolecko;
                CC3.SetActive(false);
                JsemNaTahu = true;
            }
            //MOŽNOST D
            else if (b1 == 0 && c1 == 0 && b2 == 1)
            {
                a1 = 1;
                A1.sprite = kolecko;
                AA1.SetActive(false);
                JsemNaTahu = true;
            }
            else if (b1 == 0 && b2 == 1 && a2 == 0 || b1 == 0 && b2 == 1 && a3 == 0 || b1 == 0 && b2 == 1 && b3 == 0 || b1 == 0 && b2 == 1 && c2 == 0)
            {
                c3 = 1;
                C3.sprite = kolecko;
                CC3.SetActive(false);
                JsemNaTahu = true;
            }
            else if (b1 == 0 && b2 == 1 && a2 == 0 || b1 == 0 && b2 == 1 && c3 == 0 || b1 == 0 && b2 == 1 && b3 == 0 || b1 == 0 && b2 == 1 && c2 == 0)
            {
                a3 = 1;
                A3.sprite = kolecko;
                AA3.SetActive(false);
                JsemNaTahu = true;
            }
            //MOŽNOST E
            else if (b2 == 0 && a2 == 1 && a3 == 0)
            {
                c1 = 1;
                C1.sprite = kolecko;
                CC1.SetActive(false);
            }
            else if (b2 == 0 && a2 == 1 && a1 == 0)
            {
                c3 = 1;
                C3.sprite = kolecko;
                CC3.SetActive(false);
            }
            else if (b2 == 0 && a2 == 1 && b1 == 0)
            {
                b3 = 1;
                B3.sprite = kolecko;
                BB3.SetActive(false);
            }
            else if (b2 == 0 && a2 == 1 && b3 == 0)
            {
                b1 = 1;
                B1.sprite = kolecko;
                BB1.SetActive(false);
            }
            else if (b2 == 0 && a2 == 1 && c1 == 0)
            {
                a3 = 1;
                A3.sprite = kolecko;
                AA3.SetActive(false);
            }
            else if (b2 == 0 && a2 == 1 && c3 == 0)
            {
                a1 = 1;
                A1.sprite = kolecko;
                AA1.SetActive(false);
            }
            else if (b2 == 0 && a2 == 1 && c2 == 0)
            {
                a1 = 1;
                A1.sprite = kolecko;
                AA1.SetActive(false);
            }
            //MOŽNOST F
            else if (b3 == 0 && b2 == 1 && a2 == 0 || b3 == 0 && b2 == 1 && c1 == 0 || b3 == 0 && b2 == 1 && b1 == 0 || b3 == 0 && b2 == 1 && c2 == 0)
            {
                a1 = 1;
                A1.sprite = kolecko;
                AA1.SetActive(false);
                JsemNaTahu = true;
            }
            else if (b3 == 0 && b2 == 1 && a2 == 0 || b3 == 0 && b2 == 1 && a1 == 0 || b3 == 0 && b2 == 1 && b1 == 0 || b3 == 0 && b2 == 1 && c2 == 0)
            {
                c1 = 1;
                C1.sprite = kolecko;
                CC1.SetActive(false);
                JsemNaTahu = true;
            }
            //MOŽNOST G
            else if (c1 == 0 && c2 == 0 && b2 == 1)
            {
                c3 = 1;
                C3.sprite = kolecko;
                CC3.SetActive(false);
                JsemNaTahu = true;
            }
            else if (c1 == 0 && c3 == 0 && b2 == 1)
            {
                c2 = 1;
                C2.sprite = kolecko;
                CC2.SetActive(false);
                JsemNaTahu = true;
            }
            else if (c3 == 0 && b3 == 0 && b2 == 1 || c3 == 0 && a3 == 0 && b2 == 1 || c3 == 0 && a2 == 0 && b2 == 1)
            {
                a1 = 1;
                A1.sprite = kolecko;
                AA1.SetActive(false);
                JsemNaTahu = true;
            }
            //MOŽNOST H
            else if (c3 == 0 && c2 == 0 && b2 == 1)
            {
                c1 = 1;
                C1.sprite = kolecko;
                CC1.SetActive(false);
                JsemNaTahu = true;
            }
            else if (c2 == 0 && b1 == 0 && b2 == 1)
            {
                c3 = 1;
                C3.sprite = kolecko;
                CC3.SetActive(false);
                JsemNaTahu = true;
            }
            else if (c2 == 0 && b3 == 0 && b2 == 1 || c2 == 0 && a3 == 0 && b2 == 1 || c2 == 0 && a2 == 0 && b2 == 1)
            {
                c3 = 1;
                C3.sprite = kolecko;
                CC3.SetActive(false);
                JsemNaTahu = true;
            }
            //MOŽNOST I
            else if (c3 == 0 && b1 == 0 && b2 == 1 || c3 == 0 && a2 == 0 && b2 == 1 || c3 == 0 && a1 == 0 && b2 == 1)
            {
                a3 = 1;
                A3.sprite = kolecko;
                AA3.SetActive(false);
                JsemNaTahu = true;
            }
            kontrola();
            if (konec == false)
            {
                JsemNaTahu = true;
            }
            
           
        }
        //3.KOLO
        if (pokolikaty == 3)
        {
            Kolo3();
        }
        //4.KOLO
        if (pokolikaty == 4)
        {
            Kolo3();
        }

    }

    public void chciA1()
    {
        if (JsemNaTahu == true)
        {
            a1 = 0;
            A1.sprite = krizek;
            AA1.SetActive(false);
            JsemNaTahu = false;
            StartCoroutine(cekej());
        }
    }
    public void chciA2()
    {
        if (JsemNaTahu == true)
        {
            a2 = 0;
            A2.sprite = krizek;
            AA2.SetActive(false);
            JsemNaTahu = false;
            StartCoroutine(cekej());
        }
    }
    public void chciA3()
    {
        if (JsemNaTahu == true)
        {
            a3 = 0;
            A3.sprite = krizek;
            AA3.SetActive(false);
            JsemNaTahu = false;
            StartCoroutine(cekej());
        }
    }
    public void chciB1()
    {
        if (JsemNaTahu == true)
        {
            b1 = 0;
            B1.sprite = krizek;
            BB1.SetActive(false);
            JsemNaTahu = false;
            StartCoroutine(cekej());
        }
    }
    public void chciB2()
    {
        if (JsemNaTahu == true)
        {
            b2 = 0;
            B2.sprite = krizek;
            BB2.SetActive(false);
            JsemNaTahu = false;
            StartCoroutine(cekej());
        }
    }
    public void chciB3()
    {
        if (JsemNaTahu == true)
        {
            b3 = 0;
            B3.sprite = krizek;
            BB3.SetActive(false);
            JsemNaTahu = false;
            StartCoroutine(cekej());
        }
    }
    public void chciC1()
    {
        if (JsemNaTahu == true)
        {
            c1 = 0;
            C1.sprite = krizek;
            CC1.SetActive(false);
            JsemNaTahu = false;
            StartCoroutine(cekej());
        }
    }
    public void chciC2()
    {
        if (JsemNaTahu == true)
        {
            c2 = 0;
            C2.sprite = krizek;
            CC2.SetActive(false);
            JsemNaTahu = false;
            StartCoroutine(cekej());
        }
    }
    public void chciC3()
    {
        if (JsemNaTahu == true)
        {
            c3 = 0;
            C3.sprite = krizek;
            CC3.SetActive(false);
            JsemNaTahu = false;
            StartCoroutine(cekej());
        }
    }

    IEnumerator cekej()
    {
        yield return new WaitForSeconds(2f);
        kontrola();
        pokolikaty++;
        if (konec == false)
        {
            AIhraje();
        }
        
    }

    private void Kolo3()
    {
        chci = Random.Range(1,9);
        switch (chci)
        {
            case 1:
                if (a1 == 2)
                {
                    a1 = 1;
                    A1.sprite = kolecko;
                    AA1.SetActive(false);
                    
                }
                else
                {
                    Kolo3();
                }
                break;
            case 2:
                if (a2 == 2)
                {
                    a2 = 1;
                    A2.sprite = kolecko;
                    AA2.SetActive(false);

                }
                else
                {
                    Kolo3();
                }
                break;
            case 3:
                if (a3 == 2)
                {
                    a3 = 1;
                    A3.sprite = kolecko;
                    AA3.SetActive(false);

                }
                else
                {
                    Kolo3();
                }
                break;
            case 4:
                if (b1 == 2)
                {
                    b1 = 1;
                    B1.sprite = kolecko;
                    BB1.SetActive(false);

                }
                else
                {
                    Kolo3();
                }
                break;
            case 5:
                if (b2 == 2)
                {
                    b2 = 1;
                    B2.sprite = kolecko;
                    BB2.SetActive(false);

                }
                else
                {
                    Kolo3();
                }
                break;
            case 6:
                if (b3 == 2)
                {
                    b3 = 1;
                    B3.sprite = kolecko;
                    BB3.SetActive(false);

                }
                else
                {
                    Kolo3();
                }
                break;
            case 7:
                if (c1 == 2)
                {
                    c1 = 1;
                    C1.sprite = kolecko;
                    CC1.SetActive(false);

                }
                else
                {
                    Kolo3();
                }
                break;
            case 8:
                if (c2 == 2)
                {
                    c2 = 1;
                    C2.sprite = kolecko;
                    CC2.SetActive(false);

                }
                else
                {
                    Kolo3();
                }
                break;
            case 9:
                if (c3 == 2)
                {
                    c3 = 1;
                    C3.sprite = kolecko;
                    CC3.SetActive(false);

                }
                else
                {
                    Kolo3();
                }
                break;
        }
        kontrola();
        if (konec == false)
        {
            JsemNaTahu = true;
        }
        
            
    }
    public void Resetovat()
    {
        //cisla
        a1 = 2;
        a2 = 2;
        a3 = 2;
        b1 = 2;
        b2 = 2;
        b3 = 2;
        c1 = 2;
        c2 = 2;
        c3 = 2;

        //resetovat sprite
        A1.sprite = null;
        A2.sprite = null;
        A3.sprite = null;
        B1.sprite = null;
        B2.sprite = null;
        B3.sprite = null;
        C1.sprite = null;
        C2.sprite = null;
        C3.sprite = null;

        //obnovit buttony
        AA1.SetActive(true);
        AA2.SetActive(true);
        AA2.SetActive(true);
        BB1.SetActive(true);
        BB2.SetActive(true);
        BB3.SetActive(true);
        CC1.SetActive(true);
        CC2.SetActive(true);
        CC3.SetActive(true);

        //resetovat hodnoty
        pokolikaty = 0;
        JsemNaTahu = true;
        piskvorkyZapnuto = true;

        Win.SetActive(false);
        Lose.SetActive(false);
        Draw.SetActive(false);

        konec = false;
    }

    private void kontrola()
    {
        if (a1 == 0 && a2 == 0 && a3 == 0 || b1 == 0 && b2 == 0 && b3 == 0 || c1 == 0 && c2 == 0 && c3 == 0 || a1 == 0 && b1 == 0 && c1 == 0 || a2 == 0 && b2 == 0 && c2 == 0 || a3 == 0 && b3 == 0 && c3 == 0 || a1 == 0 && b2 == 0 && c3 == 0 || a3 == 0 && b2 == 0 && c1 == 0)
        {
            konec = true;
            Win.gameObject.SetActive(true);
        }
        if (a1 == 1 && a2 == 1 && a3 == 1 || b1 == 1 && b2 == 1 && b3 == 1 || c1 == 1 && c2 == 1 && c3 == 1 || a1 == 1 && b1 == 1 && c1 == 1 || a2 == 1 && b2 == 1 && c2 == 1 || a3 == 1 && b3 == 1 && c3 == 1 || a1 == 1 && b2 == 1 && c3 == 1 || a3 == 1 && b2 == 1 && c1 == 1)
        {
            konec = true;
            Lose.SetActive(true);
        }
        if (pokolikaty == 5)
        {
            konec = true;
            Draw.SetActive(true);
        }
    }

    public void exit()
    {
        piskvorkyZapnuto = false;
        PiskvorkyGame.SetActive(false);
        vyhra = true;
    }
}
