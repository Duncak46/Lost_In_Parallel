using UnityEngine;

public class posouvaniSten : MonoBehaviour
{
    [SerializeField]
    private GameObject prohra;

    [SerializeField]
    private RectTransform klic;
    [SerializeField]
    private RectTransform raketa;
    [SerializeField]
    private RectTransform konec;
    public static bool HraZapnuto = false;
    public static bool Nevypnuto = false;
    private float speed = 5f;

    [SerializeField]
    private RectTransform steny;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HraZapnuto == true)
        {
            Vector2 currentPosition = steny.anchoredPosition;
            currentPosition.x -= speed * Time.deltaTime;
            steny.anchoredPosition = currentPosition;
        }
    }
    //reset
    public void resetovat()
    {
        konec.anchoredPosition = new Vector2(3875, 427);
        steny.anchoredPosition = new Vector2(2315, 189);
        raketa.anchoredPosition = new Vector2(-252, 433);
        klic.anchoredPosition = new Vector2(824, 168);
        prohra.SetActive(false);
        raketa.gameObject.SetActive(true);
        klic.gameObject.SetActive(true);
        steny.gameObject.SetActive(true);
        konec.gameObject.SetActive(true);
        HraZapnuto = true;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<raketaMovement>();
        if (player != null)
        {
            HraZapnuto =false;
            klic.gameObject.SetActive(false);
            steny.gameObject.SetActive(false);
            raketa.gameObject.SetActive(false);
            konec.gameObject.SetActive(false);
            prohra.SetActive(true);
        }
    }

    
}
