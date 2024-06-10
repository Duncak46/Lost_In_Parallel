using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMainBoss : MonoBehaviour
{
    
    public void TeleportZpet()
    {
        KontrolaJestliJeHraZapnuta.ZapnutaHra = true;
        HPSystem.HPplayer = 10;
        strileniOhne.HP = 5;
        SceneManager.LoadScene("HRA");
    }
}
