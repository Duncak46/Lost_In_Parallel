using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restartovaniMain : MonoBehaviour
{
    public GameObject originalPrefab;  // Pùvodní prefab
    private GameObject currentInstance;

    void Start()
    {
        // Vytvoøíme první instanci prefabu
        currentInstance = Instantiate(originalPrefab, originalPrefab.transform.position, originalPrefab.transform.rotation);
    }

    public void ResetObject()
    {
        // Znièíme aktuální instanci
        Destroy(currentInstance);

        // Vytvoøíme novou instanci prefabu
        currentInstance = Instantiate(originalPrefab, originalPrefab.transform.position, originalPrefab.transform.rotation);

        Debug.Log("GameObject has been reset to its original state.");
    }
}
