using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack1 : MonoBehaviour
{

    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Attack1();
        }
		
	}
    void Attack1()
    {
        animator.SetTrigger("Attack1");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position,attackRange,enemyLayer);
        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("we hit" + enemy.name);
        }
    }
	void OnDrawGizmosSelected()
	{   
        if(attackPoint == null)
        {
            return;
        }
		Gizmos.DrawWireSphere(attackPoint.position, attackRange);
	}
}
