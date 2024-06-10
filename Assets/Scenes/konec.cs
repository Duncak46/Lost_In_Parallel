using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class konec : MonoBehaviour
{
    public GameObject hraNaSmazani;
    bool jenJednou = true;
    // Start is called before the first frame update
    public float fadeDuration = 2.0f; // Délka trvání ztmavování v sekundách
    public SpriteRenderer spriteRenderer;
    private Color originalColor;
    private float timer;// Reference na SpriteRenderer objektu

    void Start()
    {
        
        originalColor = spriteRenderer.color;
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (jenJednou && strileniOhne.HP <= 0)
        {
            jenJednou=false;
            Konec();
        }
        if (strileniOhne.HP <= 0)
        {
            timer += Time.deltaTime;

            // Vypoèítáme aktuální hodnotu alpha kanálu na základì èasu
            float alpha = Mathf.Lerp(0.0f, 1.0f, timer / fadeDuration);

            // Nastavíme novou barvu s aktuálním alphou
            Color newColor = originalColor;
            newColor.a = alpha;

            // Aplikujeme novou barvu na sprite renderer
            spriteRenderer.color = newColor;

            // Pokud jsme dosáhli konce ztmavování, mùžeme znièit tento skript nebo provést další akce
            if (timer >= fadeDuration)
            {
                SceneManager.LoadScene("End");
            } 
        }
        
    }
    
    public void Konec()
    {
        Destroy(hraNaSmazani);
    }
    
}
