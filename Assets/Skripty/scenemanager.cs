using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    // Název cílové scény
    

    // Metoda pro pøechod na cílovou scénu
    public void dohry()
    {
        SceneManager.LoadScene("HRA");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
