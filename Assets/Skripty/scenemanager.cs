using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    // N�zev c�lov� sc�ny
    

    // Metoda pro p�echod na c�lovou sc�nu
    public void dohry()
    {
        SceneManager.LoadScene("HRA");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
