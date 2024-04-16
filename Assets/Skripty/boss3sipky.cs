using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss3sipky : MonoBehaviour
{
    private GameObject[] sipkyLevo;
    private GameObject[] sipkyPravo;
    private GameObject[] sipkyDolu;
    private GameObject[] sipkyNahoru;

    private int HP = 3;
    // Start is called before the first frame update
    void Start()
    {
        sipkyLevo = GameObject.FindGameObjectsWithTag("sipkaLeft");
        sipkyPravo = GameObject.FindGameObjectsWithTag("sipkaRight");
        sipkyDolu = GameObject.FindGameObjectsWithTag("sipkaDown");
        sipkyNahoru = GameObject.FindGameObjectsWithTag("sipkaUp");
    }

    // Update is called once per frame
    void Update()
    {
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
        if (HP <= 0)
        {
            Debug.Log("prohra");
        }
    }
}
