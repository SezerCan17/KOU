using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI_patrolling : MonoBehaviour
{
    public Transform noktaA;
    public Transform noktaB;
    public float hareketHizi = 3f;
    public bool rlook;
    public Rigidbody2D rb;
    AITrigger aITrigger;

    private Transform hedefNokta;

    void Start()
    {
        if (noktaA == null || noktaB == null)
        {
            Debug.LogError("L�tfen A ve B noktalar�n� do�ru bir �ekilde ayarlay�n.");
        }

        // Ba�lang��ta hedef A noktas� olsun
        hedefNokta = noktaA;
        rlook = false;
    }

    void Update()
    {
        if(rb.velocity.x<0)
        {
            rlook = false;
        }
        else
        {
            rlook = true;
        }
        
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
                Debug.Log("A da");
                hedefNokta = noktaB;
                rlook = true;
            }
            else
            {
                Debug.Log("B de");
                hedefNokta = noktaA;
                rlook=false;
            }
        }

        // Hedef noktan�n y�n�ne g�re sprite'�n y�n�n� ayarla

        if (transform.position.x > hedefNokta.position.x )
        {

            // Hedef sol taraftaysa, karakteri sola bakacak �ekilde d�nd�r
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else 
        {
            // Hedef sa� taraftaysa, karakteri do�ru y�ne bakacak �ekilde d�nd�r
            transform.localScale = new Vector3(1, 1, 1);
        }
        
    }

}
