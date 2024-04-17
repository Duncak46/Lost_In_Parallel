using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class boss3sipky : MonoBehaviour
{
    public GameObject Reset;
    private Vector3 startPos;
    public GameObject mover;
    Color barva;
    Color barvaForReset;
    public AudioSource audioHra;

    
    private GameObject[] sipkyLevo;
    private GameObject[] sipkyPravo;
    private GameObject[] sipkyDolu;
    private GameObject[] sipkyNahoru;

    private int HP = 3;
    public SpriteRenderer HP1;
    public SpriteRenderer HP2;
    public SpriteRenderer HP3;
    string hexBarva = "615E5E";
    // Start is called before the first frame update
    void Start()
    {
        sipkyLevo = GameObject.FindGameObjectsWithTag("sipkaLeft");
        sipkyPravo = GameObject.FindGameObjectsWithTag("sipkaRight");
        sipkyDolu = GameObject.FindGameObjectsWithTag("sipkaDown");
        sipkyNahoru = GameObject.FindGameObjectsWithTag("sipkaUp");
        barvaForReset = HP1.color;
        barva = HexToColor(hexBarva);
        startPos = mover.transform.position;
    }
    Color HexToColor(string hex)
    {
        byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
        byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
        byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
        return new Color32(r, g, b, 255);
    }
    void Update()
    {
        foreach(GameObject sipka in sipkyDolu)
        {
            if (sipka.transform.position.y < 47.1f && sipka.activeSelf)
            {
                sipka.SetActive(false);
                UbiratHP();
            }
        }
        foreach (GameObject sipka in sipkyLevo)
        {
            if (sipka.transform.position.y < 47.1f && sipka.activeSelf)
            {
                sipka.SetActive(false);
                UbiratHP();
            }
        }
        foreach (GameObject sipka in sipkyNahoru)
        {
            if (sipka.transform.position.y < 47.1f && sipka.activeSelf)
            {
                sipka.SetActive(false);
                UbiratHP();
            }
        }
        foreach (GameObject sipka in sipkyPravo)
        {
            if (sipka.transform.position.y < 47.1f && sipka.activeSelf)
            {
                sipka.SetActive(false);
                UbiratHP();
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            foreach (GameObject sipka in sipkyDolu)
            {

                if (sipka.transform.position.y <= 47.6f && sipka.transform.position.y >= 47.1f)
                {
                    sipka.SetActive(false);
                    return;
                }
                else if (sipka.transform.position.y <= 48.3f && sipka.transform.position.y >= 46.5f)
                {
                    sipka.SetActive(false);
                    return;
                }
            }
            UbiratHP();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            foreach (GameObject sipka in sipkyNahoru)
            {

                if (sipka.transform.position.y <= 47.6f && sipka.transform.position.y >= 47.1f)
                {
                    sipka.SetActive(false);
                    return;
                }
                else if (sipka.transform.position.y <= 48.3f && sipka.transform.position.y >= 46.5f)
                {
                    sipka.SetActive(false);
                    return;
                }
            }
            UbiratHP();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            foreach (GameObject sipka in sipkyLevo)
            {

                if (sipka.transform.position.y <= 47.6f && sipka.transform.position.y >= 47.1f)
                {
                    sipka.SetActive(false);
                    return;
                }
                else if (sipka.transform.position.y <= 48.3f && sipka.transform.position.y >= 46.5f)
                {
                    sipka.SetActive(false);
                    return;
                }
            }
            UbiratHP();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            foreach (GameObject sipka in sipkyPravo)
            {
                
                if (sipka.transform.position.y <= 47.6f && sipka.transform.position.y >= 47.1f)
                {
                    sipka.SetActive(false);
                    return;
                }
                else if (sipka.transform.position.y <= 48.3f && sipka.transform.position.y >= 46.5f)
                {
                    sipka.SetActive(false);
                    return;
                }
            }
            UbiratHP();
        }
    }

    void UbiratHP()
    {
        HP--;
        if (HP == 2)
        {
            HP1.color = barva;
        }
        else if (HP == 1)
        {
            HP2.color = barva;
        }
        else if (HP == 0)
        {
            HP3.color = barva;
        }
        else
        {
            Prohra();
        }
    }
    void Prohra() 
    {
        mover.SetActive(false);
        SipkyMove.move = false;
        Reset.SetActive(true);

        // Postupné ztišení hudby
        StartCoroutine(ZtisitHudbu());

        // Zastavení videa
    }

    IEnumerator ZtisitHudbu()
    {
        
        while (audioHra.volume > 0)
        {
            audioHra.volume -= Time.deltaTime; 
            yield return null;
        }
        audioHra.Stop();
    }
    public void restartovat()
    {

        HP1.color = barvaForReset;
        HP2.color = barvaForReset;
        HP3.color = barvaForReset;
        SipkyMove.move = true;
        HP = 3;
        mover.SetActive(true);
        mover.transform.position = startPos;
        audioHra.volume = 0.5f;
        audioHra.Play();
        Reset.SetActive(false);
    }
}
