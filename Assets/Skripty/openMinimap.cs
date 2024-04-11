using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openMinimap : MonoBehaviour
{
    [SerializeField]
    private GameObject Minimap;

    [SerializeField]
    private GameObject LogoMap;

    private bool mapIsOpen = false;

    [SerializeField]
    private Transform Player;
    [SerializeField]
    private Transform PlayerMinimap;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && mapIsOpen == true && movement.povoleno == true)
        {
            Minimap.SetActive(false);
            LogoMap.SetActive(true);
            mapIsOpen = false;
        }
        else if (Input.GetKeyDown(KeyCode.M) && mapIsOpen == false && movement.povoleno == true)
        {
            Minimap.SetActive(true);
            LogoMap.SetActive(false);
            mapIsOpen = true;
        }
        if (movement.povoleno == false)
        {
            Minimap.SetActive(false);
            LogoMap.SetActive(true);
            mapIsOpen = false;
        }


        //X1
        if (Player.position.x >= -10f && Player.position.x <= 7.5f && Player.position.y <= 9f && Player.position.y >= -5.7f )
        {
            PlayerMinimap.position = Player.TransformPoint(new Vector2(-5.51f, -5.89f));
        }
        if (Player.position.x > 7.5f && Player.position.x <= 34.1f && Player.position.y <= 9f && Player.position.y >= -5.7f)
        {
            PlayerMinimap.position = Player.TransformPoint(new Vector2(-0.1f, -5.6f));
        }
        if (Player.position.x > 34.1f && Player.position.x <= 73f && Player.position.y <= 9f && Player.position.y >= -5.7f)
        {
            PlayerMinimap.position = Player.TransformPoint(new Vector2(4.3f, -4.9f));
        }

        //X2
        if (Player.position.x >= -10f && Player.position.x <= 7.5f && Player.position.y <= 25.8f && Player.position.y > 9f)
        {
            PlayerMinimap.position = Player.TransformPoint(new Vector2(-3.5f, -3f));
        }
        if (Player.position.x > 7.5f && Player.position.x <= 34.1f && Player.position.y <= 25.8f && Player.position.y > 9f)
        {
            PlayerMinimap.position = Player.TransformPoint(new Vector2(0.4f, -1.5f));
        }
        if (Player.position.x > 34.1f && Player.position.x <= 73f && Player.position.y <= 25.8f && Player.position.y > 9f)
        {
            PlayerMinimap.position = Player.TransformPoint(new Vector2(4.1f, -1.5f));
        }

        //X3
        if (Player.position.x >= -10f && Player.position.x <= 7.5f && Player.position.y <= 61.5f && Player.position.y > 25.8f)
        {
            PlayerMinimap.position = Player.TransformPoint(new Vector2(-3.54f, 3.5f));
        }
        if (Player.position.x > 7.5f && Player.position.x <= 34.1f && Player.position.y <= 61.5f && Player.position.y > 25.8f)
        {
            PlayerMinimap.position = Player.TransformPoint(new Vector2(0f, 3.5f));
        }
        if (Player.position.x > 34.1f && Player.position.x <= 73f && Player.position.y <= 61.5f && Player.position.y > 25.8f)
        {
            PlayerMinimap.position = Player.TransformPoint(new Vector2(4.1f, 5.4f));
        }
    }
}
