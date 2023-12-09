using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITrigger : MonoBehaviour
{
    
    public EnemyAI enemyAi;
    public EnemyAI_patrolling enemyAI_Patrolling;

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="Player") {
            Debug.Log("Geldi1");
            enemyAi.enabled = true;
            enemyAI_Patrolling.enabled = false;
            Debug.Log("Geldi2");
           //hedefNesne.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            enemyAi.enabled = false;
            enemyAI_Patrolling.enabled = true;
        }
    }
}
