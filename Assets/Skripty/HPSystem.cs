using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HPSystem : MonoBehaviour
{
    public static int HPplayer = 10;
    public GameObject hra2;
    public GameObject hra3;
    public GameObject restart;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (HPplayer <= 0)
        {
            KontrolaJestliJeHraZapnuta.ZapnutaHra = false;
            SceneManager.LoadScene("RestartMainBossik");
        }
    }
    
}
