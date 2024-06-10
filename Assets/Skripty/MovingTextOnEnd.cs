using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTextOnEnd : MonoBehaviour
{
    public float speed = 0.7f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(konechry());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }

    IEnumerator konechry()
    {
        yield return new WaitForSeconds(70f);
        Debug.Log("bruh");
        Application.Quit();
    }
}
