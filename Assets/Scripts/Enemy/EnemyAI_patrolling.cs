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
            Debug.LogError("L�tfen A ve B noktalar�n� do�ru bir �ekilde ayarlay�n.");
        }

        // Ba�lang��ta hedef A noktas� olsun
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

        // Hedef noktaya do�ru hareket et
        transform.position = Vector2.MoveTowards(transform.position, hedefNokta.position, hareketHizi * Time.deltaTime);

        // E�er d��man hedef noktaya ula�t�ysa, hedefi de�i�tir
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
