using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PesMoving : MonoBehaviour
{

    public static bool MaKost = false;
    public static bool muzeZacit = false;

    [SerializeField]
    private Transform Hrac;
    public float rychlost = 5f;
    public float vzdalenostOdObjektu2 = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (muzeZacit == true)
        {
            PrenasledujObjekt();
        }
    }

    private void PrenasledujObjekt()
    {
        
        

        // Vypoèítání nové pozice objektu1 vedle objektu2
        Vector2 novaPozice = new Vector2(Hrac.position.x + 1.5f, Hrac.position.y);

        // Pohyb smìrem k nové pozici
        transform.position = Vector2.MoveTowards(transform.position, novaPozice, rychlost * Time.deltaTime);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<movement>();
        if (player != null)
        {
            if (MaKost == true)
            {
                DialogSkriptP3.mam_psa = true;
                muzeZacit = true;
            }
        }
    }

    //Dodìlat omezení na strkání do hráèe/distance od hráèe
}
