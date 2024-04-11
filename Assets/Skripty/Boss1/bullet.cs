using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Znicit());
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    IEnumerator Znicit()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
