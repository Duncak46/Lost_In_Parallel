using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pohybmainboss : MonoBehaviour
{
    public float speed = 5.0f; // Nastavte rychlost hr��e podle va�ich pot�eb.
    public static bool povoleno = true;
    private void Update()
    {
       
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontalInput, verticalInput, 0) * speed * Time.deltaTime;
            transform.Translate(movement);
    }
}
