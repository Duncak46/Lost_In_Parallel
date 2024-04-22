using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vyhejbaniLaseru : MonoBehaviour
{
    [SerializeField]
    private GameObject resetUI;

    void Update()
    {

        if (lasers.kolikatyLaser == 1)
        {
            if (lasers.pozice == 3 || lasers.pozice == 6 || lasers.pozice == 9)
            {

            }
            else
            {
                prohra();
            }
        }
        if (lasers.kolikatyLaser == 2)
        {
            if (lasers.pozice == 7 || lasers.pozice == 8 || lasers.pozice == 9)
            {
                
            }
            else
            {
                prohra();
            }
        }
        if (lasers.kolikatyLaser == 3)
        {
            if (lasers.pozice != 4)
            {
                prohra();
            }
        }
        if (lasers.kolikatyLaser == 4)
        {
            if (lasers.pozice != 2)
            {
                prohra();
            }
        }
        if (lasers.kolikatyLaser == 5)
        {
            if (lasers.pozice != 6)
            {
                prohra();
            }
        }
        if (lasers.kolikatyLaser == 6)
        {
            if (lasers.pozice != 7)
            {
                prohra();
            }
        }
    }
    void prohra()
    {
        lasers.movement = false;
        resetUI.SetActive(true);
    }
}
