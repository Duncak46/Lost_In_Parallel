using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class konec : MonoBehaviour
{
    public GameObject hraNaSmazani;
    bool jenJednou = true;
    // Start is called before the first frame update
    public float fadeDuration = 2.0f; // D�lka trv�n� ztmavov�n� v sekund�ch
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

            // Vypo��t�me aktu�ln� hodnotu alpha kan�lu na z�klad� �asu
            float alpha = Mathf.Lerp(0.0f, 1.0f, timer / fadeDuration);

            // Nastav�me novou barvu s aktu�ln�m alphou
            Color newColor = originalColor;
            newColor.a = alpha;

            // Aplikujeme novou barvu na sprite renderer
            spriteRenderer.color = newColor;

            // Pokud jsme dos�hli konce ztmavov�n�, m��eme zni�it tento skript nebo prov�st dal�� akce
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
