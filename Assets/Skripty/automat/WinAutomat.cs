using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinAutomat : MonoBehaviour
{

    [SerializeField]
    private GameObject Win;

    [SerializeField]
    private GameObject stenyList;
    [SerializeField]
    private GameObject automat;
    [SerializeField]
    private GameObject raketa;

    [SerializeField]
    private RectTransform stena;

    [SerializeField]
    private GameObject canvas;

    private float speed = 85f;
    // Start is called before the first frame update
    void Start()
    {
        canvas.transform.position = new Vector3(0,-50, -10);
    }

    // Update is called once per frame
    void Update()
    {
        if (posouvaniSten.HraZapnuto == true)
        {
            Vector2 currentPosition = stena.anchoredPosition;
            currentPosition.x -= speed * Time.deltaTime;
            stena.anchoredPosition = currentPosition;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {

        var player = collision.gameObject.GetComponent<raketaMovement>();
        if (player != null)
        {
            Win.SetActive(true);
            posouvaniSten.HraZapnuto = false;
            stenyList.SetActive(false);
            raketa.SetActive(false);
        }
    }

    public void ExitWin()
    {
        posouvaniSten.Nevypnuto = false;
        canvas.transform.position = new Vector3(-4.33f, 0.2f, -10);
        automat.SetActive(false);
    }
}
