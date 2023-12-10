using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class AITrigger : MonoBehaviour
{
   
    public EnemyAI enemyAi;
    public EnemyAI_patrolling enemyAI_Patrolling;
    public bool yon;
    

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="player") {
            Debug.Log("Geldi1");
            enemyAi.enabled = true;
            //enemyAI_Patrolling.enabled = false;
            //yon = enemyAI_Patrolling.rlook;
            Debug.Log("Geldi2");
           
            //hedefNesne.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "player")
        {
            enemyAi.enabled = false;
            //enemyAI_Patrolling.enabled = true;
            //yon = enemyAI_Patrolling.rlook;
        }
    }

    
}

