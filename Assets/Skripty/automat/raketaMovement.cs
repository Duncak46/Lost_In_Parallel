using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raketaMovement : MonoBehaviour
{
    

    private float raketaSpeed = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(verticalInput * -1, horizontalInput, 0) * raketaSpeed * Time.deltaTime;
        transform.transform.Translate(movement);
    }
}
