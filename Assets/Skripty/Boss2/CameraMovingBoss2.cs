using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovingBoss2 : MonoBehaviour
{
    public GameObject player;
    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //POZICE1
        if (player.transform.position.y < -102.52f)
        {
            Camera.transform.position = new Vector3(Camera.transform.position.x, -109.2f, -7f);
        }
        //POZICE2
        if (player.transform.position.y > -102.51f && player.transform.position.y < -90.16f)
        {
            Camera.transform.position = new Vector3(Camera.transform.position.x, -96.74001f, -7f);
        }
        //POZICE3
        if (player.transform.position.y > -90.15f && player.transform.position.y < -78.11f)
        {
            Camera.transform.position = new Vector3(Camera.transform.position.x, -84.4f, -7f);
        }
        //POZICE4
        if (player.transform.position.y > -78.10f && player.transform.position.y < -65.62f)
        {
            Camera.transform.position = new Vector3(Camera.transform.position.x, -72.06f, -7f);
        }
        //POZICE5
        if (player.transform.position.y > -65.61f)
        {
            Camera.transform.position = new Vector3(Camera.transform.position.x, -59.22f, -7f);
        }
    }
}
