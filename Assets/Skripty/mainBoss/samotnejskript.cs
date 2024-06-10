using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class samotnejskript : MonoBehaviour
{
    // Struct to store the initial position and rotation
    [System.Serializable]
    public struct InitialTransform
    {
        public Vector3 position;
        public Quaternion rotation;
    }

    // List of game objects to reset
    public GameObject[] gameObjectsToReset;

    // Array to store the initial transforms
    private InitialTransform[] initialTransforms;

    void Start()
    {
        // Initialize the array
        initialTransforms = new InitialTransform[gameObjectsToReset.Length];

        // Store the initial positions and rotations
        for (int i = 0; i < gameObjectsToReset.Length; i++)
        {
            initialTransforms[i] = new InitialTransform
            {
                position = gameObjectsToReset[i].transform.position,
                rotation = gameObjectsToReset[i].transform.rotation
            };
        }
    }

    // Method to reset the game objects
    public void ResetGame()
    {
        for (int i = 0; i < gameObjectsToReset.Length; i++)
        {
            gameObjectsToReset[i].transform.position = initialTransforms[i].position;
            gameObjectsToReset[i].transform.rotation = initialTransforms[i].rotation;
            gameObjectsToReset[i].SetActive(true); // Assuming you want to reactivate them as well
        }
    }
}
