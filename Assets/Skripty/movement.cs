using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f; // Nastavte rychlost hráèe podle vašich potøeb.
    public static bool povoleno = true;
    private void Update()
    {
        if (posouvaniSten.HraZapnuto == false && posouvaniSten.Nevypnuto == false && povoleno == true)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontalInput, verticalInput, 0) * speed * Time.deltaTime;
            transform.Translate(movement);
        }
    }
}
