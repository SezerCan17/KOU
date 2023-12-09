using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI_patrolling : MonoBehaviour
{
    public Transform noktaA;
    public Transform noktaB;
    public float hareketHizi = 3f;

    private Transform hedefNokta;

    void Start()
    {
        if (noktaA == null || noktaB == null)
        {
            Debug.LogError("Lütfen A ve B noktalarýný doðru bir þekilde ayarlayýn.");
        }

        // Baþlangýçta hedef A noktasý olsun
        hedefNokta = noktaA;
    }

    void Update()
    {
        HedefeGit();
    }

    void HedefeGit()
    {
        if (hedefNokta == null)
            return;

        // Hedef noktaya doðru hareket et
        transform.position = Vector2.MoveTowards(transform.position, hedefNokta.position, hareketHizi * Time.deltaTime);

        // Eðer düþman hedef noktaya ulaþtýysa, hedefi deðiþtir
        if (Vector2.Distance(transform.position, hedefNokta.position) < 0.1f)
        {
            if (hedefNokta == noktaA)
            {
                hedefNokta = noktaB;
            }
            else
            {
                hedefNokta = noktaA;
            }
        }
    }
}
