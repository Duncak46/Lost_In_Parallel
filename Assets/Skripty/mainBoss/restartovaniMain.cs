using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restartovaniMain : MonoBehaviour
{
    public GameObject originalPrefab;  // P�vodn� prefab
    private GameObject currentInstance;

    void Start()
    {
        // Vytvo��me prvn� instanci prefabu
        currentInstance = Instantiate(originalPrefab, originalPrefab.transform.position, originalPrefab.transform.rotation);
    }

    public void ResetObject()
    {
        // Zni��me aktu�ln� instanci
        Destroy(currentInstance);

        // Vytvo��me novou instanci prefabu
        currentInstance = Instantiate(originalPrefab, originalPrefab.transform.position, originalPrefab.transform.rotation);

        Debug.Log("GameObject has been reset to its original state.");
    }
}
